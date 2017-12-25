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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXBusiness.D365MetaExplorer.Core
{
    public static class MetaDataStoreLoader
    {
        public static MetaDataStore Load(string path)
        {
            MetaDataStore m = new MetaDataStore(path);
            if (!System.IO.Directory.Exists(path))
            {
                throw new CoreCommonException("Provided path could not be read.");
            }

            // TODO: Implement reading the folder structure


            // For each top level folder (package)
            // ... Find the descriptor subfolder
            // ... Search for xml files which are model descriptors
            // ... check (quick / complete) the model implementation directory

            return m;
        }
    }
}
