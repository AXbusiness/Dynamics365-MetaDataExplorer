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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AXBusiness.D365MetaExplorer.Core;

namespace AXBusiness.D365MetaExplorer.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Run(args);
            }
            catch (CoreCommonException ex)
            {
                System.Console.WriteLine("*ERROR*: " + ex.Message);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("*ERROR*: " + ex.Message);
                System.Console.WriteLine(ex.ToString());
            }
        }

        private static void Run(string[] args)
        {
            // For now, lets assume the modelstore path is provided as first and only argument. If left out, switch to demo data mode
            MetaDataStore m;
            if (args.Count() > 0)
            {
                string path = args[0];
                m = MetaDataStoreLoader.Load(path);
                System.Console.WriteLine("Finished loading modelstore from " + path);
            }
            else
            {
                m = DemoDataUtil.GetModelStore(3);
                System.Console.WriteLine("Demo data modelstore loaded.");
            }

            System.Console.WriteLine("Contained packages: " + m.Packages.Count().ToString());
        }
    }
}
