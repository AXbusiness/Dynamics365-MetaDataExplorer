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
using System.Windows.Forms;
using AXBusiness.D365MetaExplorer.Core;

namespace AXBusiness.D365MetaExplorer.WinFormUI
{
    /// <summary>
    /// This form is just for debug purposes for the time of development. It has to be removed in the final version.
    /// </summary>
    public partial class DebugForm : Form
    {
        Package selectedPackage = null;
        Model selectedModel = null;

        public MetaDataStore MetaStore { get; set; }

        public DebugForm()
        {
            InitializeComponent();
            lstPackages.DisplayMember = "AssemblyName";
            lstModels.DisplayMember = "Name";
        }

        private void populatePackages()
        {
            lstPackages.Items.Clear();
            foreach (Package p in MetaStore.Packages)
            {
                lstPackages.Items.Add(p);
            }
            selectedPackage = null;
            txtPackageDetails.Text = "";
        }

        private void populateModels()
        {
            lstModels.Items.Clear();
            foreach (Model m in selectedPackage.Models)
            {
                lstModels.Items.Add(m);
            }
            selectedModel = null;
            txtModelDetails.Text = "";
        }

        private void populatePackageDetails()
        {
            txtPackageDetails.Text = "Assembly: " + selectedPackage.AssemblyName + Environment.NewLine +
                "Number of models: " + selectedPackage.Models.Count.ToString();
        }

        private void populateModelDetails()
        {
            txtModelDetails.Text = "Id: " + selectedModel.Id.ToString() + Environment.NewLine +
                "Name: " + selectedModel.Name + Environment.NewLine +
                "DisplayName: " + selectedModel.DisplayName + Environment.NewLine +
                "Description: " + selectedModel.Description + Environment.NewLine +

                "Customization: " + selectedModel.Customization + Environment.NewLine +
                "Layer: " + selectedModel.Layer + Environment.NewLine +
                "Locked: " + selectedModel.Locked + Environment.NewLine +
                "ModelModule: " + selectedModel.ModelModule + Environment.NewLine +
                "Publisher: " + selectedModel.Publisher + Environment.NewLine +
                "Version: " + string.Format("{0}.{1}.{2}.{3}", selectedModel.VersionBuild, selectedModel.VersionMajor, selectedModel.VersionMinor, selectedModel.VersionRevision);
        }


        private void DebugForm_Load(object sender, EventArgs e)
        {
            if (MetaStore != null)
            {
                populatePackages();
            }
        }

        private void lstPackages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPackages.SelectedItem != null)
            {
                selectedPackage = lstPackages.SelectedItem as Package;
                populatePackageDetails();
                populateModels();
            }
        }

        private void lstModels_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstModels.SelectedItem != null)
            {
                selectedModel = lstModels.SelectedItem as Model;
                populateModelDetails();
            }
        }
    }
}
