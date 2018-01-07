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
using System.Windows.Forms;
using AXBusiness.D365MetaExplorer.Core;

namespace AXBusiness.D365MetaExplorer.WinFormUI
{
    public partial class MainForm : Form
    {
        MetaDataStore metaDataStore = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void OnMetadataStoreLoaded(MetaDataStore store)
        {
            metaDataStore = store;
            populateTree();
            showJustPackages();
            refreshTreeText();
            showMessages();
        }

        private void OnFilterChanged(object sender)
        {
            refreshTreeText();
        }

        private void populateTree()
        {
            TV.Nodes.Clear();
            TreeNode rootNode = new TreeNode("AOT");
            TV.Nodes.Add(rootNode);

            foreach (Package p in metaDataStore.Packages)
            {
                TreeNode nodePackage = new TreeNode();
                nodePackage.Tag = p;
                rootNode.Nodes.Add(nodePackage);
                foreach (Model m in p.Models)
                {
                    TreeNode nodeModel = new TreeNode();
                    nodeModel.Tag = m;
                    nodePackage.Nodes.Add(nodeModel);
                }
            }

            grpFilter.Enabled = true;
            grpTreeButtons.Enabled = true;
        }

        private string getTreeTextForPackage(Package package)
        {
            return package.AssemblyName;
        }

        private void refreshTreeText()
        {
            // After changing any filter, parse all nodes and re-evaluate the text
            TreeNode rootNode = TV.Nodes[0];
            Package package;
            Model model;

            foreach (TreeNode nodePackage in rootNode.Nodes)
            {
                package = null;
                if (nodePackage.Tag != null && nodePackage.Tag is Package)
                {
                    package = (Package)nodePackage.Tag;
                    nodePackage.Text = getTreeTextForPackage(package);
                }
                foreach (TreeNode nodeModel in nodePackage.Nodes)
                {
                    model = null;
                    if (nodeModel.Tag != null && nodeModel.Tag is Model)
                    {
                        model = (Model)nodeModel.Tag;
                        nodeModel.Text = getTreeTextForModel(null, model);
                    }
                }
            }
        }

        private void showMessages()
        {
            if (metaDataStore == null)
            {
                return;
            }

            List<string> lines = new List<string>();
            List<DiagnosticMessageType> orderedTypeList = new List<DiagnosticMessageType>() { DiagnosticMessageType.Error, DiagnosticMessageType.Warning, DiagnosticMessageType.Information };
            if (chkShowDebugMessages.Checked)
            {
                orderedTypeList.Add(DiagnosticMessageType.Debug);
            }

            // Go through the ordered types list to show most important messages first
            foreach (DiagnosticMessageType dmt in orderedTypeList)
            {
                foreach (DiagnosticMessage msg in metaDataStore.Messages)
                {
                    if (dmt == msg.Type)
                    {
                        lines.Add(string.Format("{0}: {1}", msg.Type.ToString(), msg.Text));
                    }
                }
            }
            txtMessages.Text = string.Join(Environment.NewLine, lines);
        }

        private string getTreeTextForModel(Package package, Model model)
        {
            string text = chkShowModelName.Checked ? model.Name : model.DisplayName;

            if (chkShowVersion.Checked)
            {
                string version = string.Format("{0}.{1}.{2}.{3}", model.VersionMajor, model.VersionMinor, model.VersionRevision, model.VersionBuild);
                text = string.Format("{0} ({1})", text, version);
            }

            return text;
        }

        private void showJustPackages()
        {
            TV.CollapseAll();
            TV.Nodes[0].Expand();
        }


        private void cmdLoad_Click(object sender, EventArgs e)
        {
            MetaDataStore store = null;
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.ShowNewFolderButton = false;
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                string directory = dlg.SelectedPath;

                try
                {
                    store = MetaDataStoreLoader.Load(directory);
                    txtMetaDataStoreLocation.Text = directory;
                    this.OnMetadataStoreLoaded(store);
                }
                catch (CoreCommonException ex)
                {
                    MessageBox.Show(ex.Message, "Application error");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "System error");
                }
            }
        }

        private void cmdDebugForm_Click(object sender, EventArgs e)
        {
            DebugForm debugForm = new DebugForm();
            debugForm.MetaStore = metaDataStore;
            debugForm.Show(this);
        }

        private void FilterCheckboxes_CheckedChanged(object sender, EventArgs e)
        {
            OnFilterChanged(sender);
        }

        private void cmdExpandPackages_Click(object sender, EventArgs e)
        {
            showJustPackages();
        }

        private void cmdExpandModels_Click(object sender, EventArgs e)
        {
            TV.ExpandAll();
        }

        private void chkShowDebugMessages_CheckedChanged(object sender, EventArgs e)
        {
            showMessages();
        }

        private void cmdLoadDemoData_Click(object sender, EventArgs e)
        {
            OnMetadataStoreLoaded(DemoDataUtil.GetModelStore(3, true));
        }
    }
}
