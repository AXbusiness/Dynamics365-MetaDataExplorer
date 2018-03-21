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

namespace AXBusiness.D365MetaExplorer.Core
{
    /// <summary>
    /// Data type represents a layer information.
    /// </summary>
    public class Layer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Layer()
        {
            this.Id = -1;
            this.Name = Id2Name(this.Id);
        }

        public Layer(int id)
        {
            this.Id = id;
            this.Name = Id2Name(id);
        }

        public Layer(string name)
        {
            this.Name = name;
            this.Id = Name2Id(name);
        }

        public static int Name2Id(string name)
        {
            switch (name.ToUpper())
            {
                case "SYS": return 0;
                case "SYP": return 1;
            }
            return -1;
        }

        public static string Id2Name(int id)
        {
            switch (id)
            {
                case 0: return "SYS";
                case 1: return "SYP";
            }
            return "NN!";
        }
    }
}
