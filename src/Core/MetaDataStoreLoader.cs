#region License
// MIT License
//
// Copyright (c) 2018 Stefan Ebert
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
#endregion

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace AXBusiness.D365MetaExplorer.Core
{
    public static class MetaDataStoreLoader
    {
        public static MetaDataStore Load(string path)
        {
            MetaDataStore m = new MetaDataStore(path);
            if (!Directory.Exists(path))
            {
                throw new CoreCommonException("Provided path could not be read.");
            }

            foreach (DirectoryInfo packageDir in new DirectoryInfo(path).EnumerateDirectories())
            {
                Package p = ReadPackage(m, packageDir);
                if (p != null)
                {
                    m.Packages.Add(p);
                }
            }
            m.Messages.Add(new DiagnosticMessage(string.Format("Metadata store was loaded with {0} packages.", m.Packages.Count),
                DiagnosticMessageType.Information));

            List<DiagnosticMessage> referenceErrors = ResolveReferences(m);
            if (referenceErrors.Count > 0)
            {
                m.Messages.AddRange(referenceErrors);
            }

            return m;
        }

        private static Package ReadPackage(MetaDataStore store, DirectoryInfo folder)
        {
            string descriptorFolder = folder.FullName + "\\Descriptor";
            if (!Directory.Exists(descriptorFolder))
            {
                // If no 'Descriptor' subfolder exists, the folder is not a package folder
                store.Messages.Add(new DiagnosticMessage(string.Format("Possible package '{0}' is missing 'Descriptor' subfolder.",
                    folder.FullName), DiagnosticMessageType.Debug));
                return null;

                // TODO: Avoid this "error" for well-known folders like [ Datastack, InstallationRecords, Plugins, StaticMetadata ]
            }

            Package p = new Package(folder.Name);
            foreach (FileInfo modelFile in new DirectoryInfo(descriptorFolder).EnumerateFiles("*.xml"))
            {
                Model m = ReadModel(store, folder.FullName, modelFile);
                if (m != null)
                {
                    p.Models.Add(m);
                }
            }
            if (p.Models.Count == 0)
            {
                // By having 'Descriptor' folder but not any valid model, notify for a potentional error in structure
                store.Messages.Add(new DiagnosticMessage(
                    string.Format("Package '{0}' has not any model, which may point out error in model structure.",
                    p.AssemblyName), DiagnosticMessageType.Warning));
            }
            return p;
        }

        private static Model ReadModel(MetaDataStore store, string packageFolder, FileInfo modelFile)
        {
            XmlDocument modelXml = new XmlDocument();
            try
            {
                modelXml.Load(modelFile.FullName);
            }
            catch (Exception ex)
            {
                // Notify a structural model descriptor error
                store.Messages.Add(new DiagnosticMessage(string.Format("Package '{0}': Ignoring model '{1}' due to error by XML loading.",
                    packageFolder, modelFile.Name), DiagnosticMessageType.Warning));
                store.Messages.Add(new DiagnosticMessage(string.Format("Package '{0}': XML loading of model '{1}' exception: '{2}'.",
                    packageFolder, modelFile.Name, ex.Message), DiagnosticMessageType.Debug));
                return null;
            }
            XmlElement root = modelXml["AxModelInfo"];
            if (root == null)
            {
                // Notify an model descriptor structural error
                store.Messages.Add(new DiagnosticMessage(string.Format("Package '{0}': Ignoring model '{1}' due to XML does not contain " +
                    "the 'AxModelInfo' element.", packageFolder, modelFile.Name), DiagnosticMessageType.Error));
                return null;
            }
            XmlElement e = root["Name"];
            if (e == null)
            {
                // Notify an model descriptor structural error
                store.Messages.Add(new DiagnosticMessage(string.Format("Package '{0}': Ignoring model '{1}' due to XML does not contain " +
                    "the 'Name' element as part of 'AxModelInfo' element.", packageFolder, modelFile.Name), DiagnosticMessageType.Error));
                return null;
            }

            Model m = new Model(e.InnerText);
            m.OriginLocation = packageFolder + "\\" + m.Name;
            m.DescriptorFilename = modelFile.FullName;

            e = root["DisplayName"];
            if (e != null)
            {
                m.DisplayName = e.InnerText;
            }
            e = root["Description"];
            if (e != null)
            {
                m.Description = e.InnerText;
            }
            e = root["Id"];
            if (e != null && long.TryParse(e.InnerText, out long id))
            {
                m.Id = id;
            }
            e = root["Customization"];
            if (e != null)
            {
                m.Customization = e.InnerText;
            }
            e = root["Layer"];
            if (e != null)
            {
                m.Layer = new Layer(e.InnerText);
            }
            e = root["Locked"];
            if (e != null)
            {
                m.Locked = e.InnerText;
            }
            e = root["ModelModule"];
            if (e != null)
            {
                m.ModelModule = e.InnerText;
            }
            e = root["Publisher"];
            if (e != null)
            {
                m.Publisher = e.InnerText;
            }
            e = root["VersionBuild"];
            if (e != null)
            {
                m.VersionBuild = e.InnerText;
            }
            e = root["VersionMajor"];
            if (e != null)
            {
                m.VersionMajor = e.InnerText;
            }
            e = root["VersionMinor"];
            if (e != null)
            {
                m.VersionMinor = e.InnerText;
            }
            e = root["VersionRevision"];
            if (e != null)
            {
                m.VersionRevision = e.InnerText;
            }

            // Lists
            e = root["ModuleReferences"];
            if (e != null && e.HasChildNodes)
            {
                foreach (XmlNode nodeReference in e.ChildNodes)
                {
                    ModuleReference r = new ModuleReference { Name = nodeReference.InnerText };
                    m.ModuleReferences.Add(r);
                }
            }

            // TODO: Handle following elements which are lists: AppliedUpdates, InternalsVisibleTo

            return m;
        }

        /// <summary>
        /// Method validates, if the name-based module references are present in the metadata store.
        /// </summary>
        /// <param name="metaDataStore">The metadata store to be validated.</param>
        /// <returns>List of validation messages to be presented in user interface.</returns>
        private static List<DiagnosticMessage> ResolveReferences(MetaDataStore metaDataStore)
        {
            List<DiagnosticMessage> errors = new List<DiagnosticMessage>();
            Dictionary<string, Package> packages = GetPackagesList(metaDataStore);

            foreach (Package p in metaDataStore.Packages)
            {
                foreach (Model m in p.Models)
                {
                    foreach (ModuleReference refModule in m.ModuleReferences)
                    {
                        // Task is to resolve existing referenced package name to package instance
                        if (packages.ContainsKey(refModule.Name))
                        {
                            refModule.ReferencedPackage = packages[refModule.Name];
                        }
                        else
                        {
                            refModule.ReferencedPackage = null;
                            errors.Add(new DiagnosticMessage(string.Format("Package {0}, model {1} references module '{2}' which was not found.",
                                p.AssemblyName, m.DisplayName, refModule.Name), DiagnosticMessageType.Error));
                        }
                    }
                }
            }
            return errors;
        }

        /// <summary>
        /// Retrieve a Dictionary, which contains the 'Package' data type for its name.
        /// </summary>
        /// <param name="metaDataStore">The metadata store for which the packages list should be listed.</param>
        /// <returns>Dictionary with key=package name and value=package data type.</returns>
        private static Dictionary<string, Package> GetPackagesList(MetaDataStore metaDataStore)
        {
            Dictionary<string, Package> packages = new Dictionary<string, Package>();
            foreach (Package p in metaDataStore.Packages)
            {
                packages.Add(p.AssemblyName, p);
            }
            return packages;
        }
    }
}
