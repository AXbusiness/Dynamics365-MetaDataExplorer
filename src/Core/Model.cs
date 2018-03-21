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

using System.Collections.Generic;

namespace AXBusiness.D365MetaExplorer.Core
{
    public class Model
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public string OriginLocation { get; set; }
        public string DescriptorFilename { get; set; }
        public string Customization { get; set; }
        public Layer Layer { get; set; }
        public string Locked { get; set; }
        public string ModelModule { get; set; }
        public string Publisher { get; set; }
        public string VersionBuild { get; set; }
        public string VersionMajor { get; set; }
        public string VersionMinor { get; set; }
        public string VersionRevision { get; set; }
        public List<ModuleReference> ModuleReferences { get; private set; }
        public List<ModelReference> ModelReferences { get; private set; }
        public List<string> AppliedUpdates { get; private set; }  // TODO: Determine data type later
        public List<string> InternalsVisibleTo { get; private set; }  // TODO: Determine data type later

        public Model(string name)
        {
            Id = 0;
            Name = name;
            DisplayName = "";
            Description = "";
            OriginLocation = "";
            DescriptorFilename = "";
            Customization = "";
            Layer = new Layer();
            Locked = "";
            ModelModule = "";
            Publisher = "";
            VersionBuild = "";
            VersionMajor = "";
            VersionMinor = "";
            VersionRevision = "";
            ModuleReferences = new List<ModuleReference>();
            ModelReferences = new List<ModelReference>();
            AppliedUpdates = new List<string>();
            InternalsVisibleTo = new List<string>();
        }
    }
}
