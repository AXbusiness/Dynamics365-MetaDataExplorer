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
    /// <summary>
    /// Data type which reflects a complete metadata store with all properties.
    /// </summary>
    public class MetaDataStore
    {
        public string OriginLocation { get; private set; }
        public List<Package> Packages { get; private set; }
        public List<DiagnosticMessage> Messages { get; private set; }


        public MetaDataStore()
        {
            Packages = new List<Package>();
            Messages = new List<DiagnosticMessage>();
        }
        public MetaDataStore(string path) : this()
        {
            OriginLocation = path;
        }

        public Package GetPackageForModel(Model model)
        {
            foreach (Package p in Packages)
            {
                foreach (Model m in p.Models)
                {
                    if (m.Id == model.Id)
                    {
                        return p;
                    }
                }
            }
            return null;
        }
    }
}
