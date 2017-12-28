#region License
// MIT License
// 
// Copyright (c) 2017 Stefan Ebert
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
                Package p = ReadPackage(packageDir);
                if (p != null)
                {
                    m.Packages.Add(p);
                }
            }

            return m;
        }

        private static Package ReadPackage(DirectoryInfo folder)
        {
            string descriptorFolder = folder.FullName + "\\Descriptor";
            if (!Directory.Exists(descriptorFolder))
            {
                // If no 'Descriptor' subfolder exists, the folder is not a package folder
                return null;
            }

            Package p = new Package(folder.Name);
            foreach (FileInfo modelFile in new DirectoryInfo(descriptorFolder).EnumerateFiles("*.xml"))
            {
                Model m = ReadModel(folder.FullName, modelFile);
                if (m != null)
                {
                    p.Models.Add(m);
                }
            }
            if (p.Models.Count == 0)
            {
                // TODO: By having 'Descriptor' folder but not any valid model, notify for a potentional error in structure
            }
            return p;
        }

        private static Model ReadModel(string packageFolder, FileInfo modelFile)
        {
            XmlDocument modelXml = new XmlDocument();
            try
            {
                modelXml.Load(modelFile.FullName);
            }
            catch (Exception ex)
            {
                // TODO: Notify an model descriptor structural error
                return null;
            }
            XmlElement root = modelXml["AxModelInfo"];
            if (root == null)
            {
                return null;
            }
            XmlElement e = root["Name"];
            if (e == null)
            {
                // TODO: Notify an model descriptor structural error
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
                m.Layer = e.InnerText;
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

            // TODO: Handle following elements which are lists: AppliedUpdates, ModelReferences, ModuleReferences, InternalsVisibleTo

            return m;
        }
    }
}
