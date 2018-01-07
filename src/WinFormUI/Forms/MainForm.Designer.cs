namespace AXBusiness.D365MetaExplorer.WinFormUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMetaDataStoreLocation = new System.Windows.Forms.TextBox();
            this.cmdLoad = new System.Windows.Forms.Button();
            this.TV = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdLoadDemoData = new System.Windows.Forms.Button();
            this.cmdDebugForm = new System.Windows.Forms.Button();
            this.cmdImport = new System.Windows.Forms.Button();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.chkShowModelCount = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.chkShowVersion = new System.Windows.Forms.CheckBox();
            this.chkShowModelName = new System.Windows.Forms.CheckBox();
            this.cmdExpandAll = new System.Windows.Forms.Button();
            this.cmdExpandPackages = new System.Windows.Forms.Button();
            this.grpTreeButtons = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMessages = new System.Windows.Forms.TextBox();
            this.chkShowDebugMessages = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.grpFilter.SuspendLayout();
            this.grpTreeButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMetaDataStoreLocation
            // 
            this.txtMetaDataStoreLocation.Location = new System.Drawing.Point(6, 41);
            this.txtMetaDataStoreLocation.Name = "txtMetaDataStoreLocation";
            this.txtMetaDataStoreLocation.ReadOnly = true;
            this.txtMetaDataStoreLocation.Size = new System.Drawing.Size(494, 20);
            this.txtMetaDataStoreLocation.TabIndex = 1;
            // 
            // cmdLoad
            // 
            this.cmdLoad.Location = new System.Drawing.Point(439, 16);
            this.cmdLoad.Name = "cmdLoad";
            this.cmdLoad.Size = new System.Drawing.Size(61, 23);
            this.cmdLoad.TabIndex = 2;
            this.cmdLoad.Text = "Load...";
            this.cmdLoad.UseVisualStyleBackColor = true;
            this.cmdLoad.Click += new System.EventHandler(this.cmdLoad_Click);
            // 
            // TV
            // 
            this.TV.Location = new System.Drawing.Point(12, 198);
            this.TV.Name = "TV";
            this.TV.Size = new System.Drawing.Size(392, 341);
            this.TV.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Metadata store location:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdLoadDemoData);
            this.groupBox1.Controls.Add(this.cmdDebugForm);
            this.groupBox1.Controls.Add(this.cmdImport);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmdLoad);
            this.groupBox1.Controls.Add(this.txtMetaDataStoreLocation);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 74);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Load Metadata store ";
            // 
            // cmdLoadDemoData
            // 
            this.cmdLoadDemoData.Location = new System.Drawing.Point(241, 16);
            this.cmdLoadDemoData.Name = "cmdLoadDemoData";
            this.cmdLoadDemoData.Size = new System.Drawing.Size(95, 23);
            this.cmdLoadDemoData.TabIndex = 8;
            this.cmdLoadDemoData.Text = "Load demo data";
            this.cmdLoadDemoData.UseVisualStyleBackColor = true;
            this.cmdLoadDemoData.Click += new System.EventHandler(this.cmdLoadDemoData_Click);
            // 
            // cmdDebugForm
            // 
            this.cmdDebugForm.Location = new System.Drawing.Point(174, 16);
            this.cmdDebugForm.Name = "cmdDebugForm";
            this.cmdDebugForm.Size = new System.Drawing.Size(61, 23);
            this.cmdDebugForm.TabIndex = 7;
            this.cmdDebugForm.Text = "Debug";
            this.cmdDebugForm.UseVisualStyleBackColor = true;
            this.cmdDebugForm.Click += new System.EventHandler(this.cmdDebugForm_Click);
            // 
            // cmdImport
            // 
            this.cmdImport.Enabled = false;
            this.cmdImport.Location = new System.Drawing.Point(372, 16);
            this.cmdImport.Name = "cmdImport";
            this.cmdImport.Size = new System.Drawing.Size(61, 23);
            this.cmdImport.TabIndex = 6;
            this.cmdImport.Text = "Import...";
            this.cmdImport.UseVisualStyleBackColor = true;
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.checkBox5);
            this.grpFilter.Controls.Add(this.chkShowModelCount);
            this.grpFilter.Controls.Add(this.checkBox3);
            this.grpFilter.Controls.Add(this.checkBox2);
            this.grpFilter.Controls.Add(this.checkBox1);
            this.grpFilter.Controls.Add(this.chkShowVersion);
            this.grpFilter.Controls.Add(this.chkShowModelName);
            this.grpFilter.Enabled = false;
            this.grpFilter.Location = new System.Drawing.Point(12, 92);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(511, 100);
            this.grpFilter.TabIndex = 6;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = " Filter ";
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(285, 51);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(287, 17);
            this.checkBox5.TabIndex = 14;
            this.checkBox5.Text = "TODO: Hide package if no model is currently contained";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // chkShowModelCount
            // 
            this.chkShowModelCount.AutoSize = true;
            this.chkShowModelCount.Location = new System.Drawing.Point(285, 35);
            this.chkShowModelCount.Name = "chkShowModelCount";
            this.chkShowModelCount.Size = new System.Drawing.Size(199, 17);
            this.chkShowModelCount.TabIndex = 13;
            this.chkShowModelCount.Text = "Show model count in package name";
            this.chkShowModelCount.UseVisualStyleBackColor = true;
            this.chkShowModelCount.CheckedChanged += new System.EventHandler(this.FilterCheckboxes_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(285, 19);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(186, 17);
            this.checkBox3.TabIndex = 12;
            this.checkBox3.Text = "TODO: Show layer in model name";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(9, 67);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(215, 17);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "TODO: Show only customization models";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 51);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(183, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "TODO: Show only system models";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // chkShowVersion
            // 
            this.chkShowVersion.AutoSize = true;
            this.chkShowVersion.Location = new System.Drawing.Point(9, 35);
            this.chkShowVersion.Name = "chkShowVersion";
            this.chkShowVersion.Size = new System.Drawing.Size(168, 17);
            this.chkShowVersion.TabIndex = 9;
            this.chkShowVersion.Text = "Display version in model name";
            this.chkShowVersion.UseVisualStyleBackColor = true;
            this.chkShowVersion.CheckedChanged += new System.EventHandler(this.FilterCheckboxes_CheckedChanged);
            // 
            // chkShowModelName
            // 
            this.chkShowModelName.AutoSize = true;
            this.chkShowModelName.Location = new System.Drawing.Point(9, 19);
            this.chkShowModelName.Name = "chkShowModelName";
            this.chkShowModelName.Size = new System.Drawing.Size(270, 17);
            this.chkShowModelName.TabIndex = 8;
            this.chkShowModelName.Text = "Display model internal name instead of display name";
            this.chkShowModelName.UseVisualStyleBackColor = true;
            this.chkShowModelName.CheckedChanged += new System.EventHandler(this.FilterCheckboxes_CheckedChanged);
            // 
            // cmdExpandAll
            // 
            this.cmdExpandAll.Location = new System.Drawing.Point(0, 29);
            this.cmdExpandAll.Name = "cmdExpandAll";
            this.cmdExpandAll.Size = new System.Drawing.Size(113, 23);
            this.cmdExpandAll.TabIndex = 8;
            this.cmdExpandAll.Text = "Expand models";
            this.cmdExpandAll.UseVisualStyleBackColor = true;
            this.cmdExpandAll.Click += new System.EventHandler(this.cmdExpandModels_Click);
            // 
            // cmdExpandPackages
            // 
            this.cmdExpandPackages.Location = new System.Drawing.Point(0, 0);
            this.cmdExpandPackages.Name = "cmdExpandPackages";
            this.cmdExpandPackages.Size = new System.Drawing.Size(113, 23);
            this.cmdExpandPackages.TabIndex = 10;
            this.cmdExpandPackages.Text = "Expand packages";
            this.cmdExpandPackages.UseVisualStyleBackColor = true;
            this.cmdExpandPackages.Click += new System.EventHandler(this.cmdExpandPackages_Click);
            // 
            // grpTreeButtons
            // 
            this.grpTreeButtons.Controls.Add(this.cmdExpandAll);
            this.grpTreeButtons.Controls.Add(this.cmdExpandPackages);
            this.grpTreeButtons.Enabled = false;
            this.grpTreeButtons.Location = new System.Drawing.Point(410, 198);
            this.grpTreeButtons.Name = "grpTreeButtons";
            this.grpTreeButtons.Size = new System.Drawing.Size(113, 172);
            this.grpTreeButtons.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 565);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Metadata store messages:";
            // 
            // txtMessages
            // 
            this.txtMessages.Location = new System.Drawing.Point(12, 581);
            this.txtMessages.Multiline = true;
            this.txtMessages.Name = "txtMessages";
            this.txtMessages.ReadOnly = true;
            this.txtMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessages.Size = new System.Drawing.Size(511, 65);
            this.txtMessages.TabIndex = 8;
            // 
            // chkShowDebugMessages
            // 
            this.chkShowDebugMessages.AutoSize = true;
            this.chkShowDebugMessages.Location = new System.Drawing.Point(387, 564);
            this.chkShowDebugMessages.Name = "chkShowDebugMessages";
            this.chkShowDebugMessages.Size = new System.Drawing.Size(136, 17);
            this.chkShowDebugMessages.TabIndex = 15;
            this.chkShowDebugMessages.Text = "Show debug messages";
            this.chkShowDebugMessages.UseVisualStyleBackColor = true;
            this.chkShowDebugMessages.CheckedChanged += new System.EventHandler(this.chkShowDebugMessages_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 658);
            this.Controls.Add(this.chkShowDebugMessages);
            this.Controls.Add(this.txtMessages);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpTreeButtons);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TV);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.grpTreeButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMetaDataStoreLocation;
        private System.Windows.Forms.Button cmdLoad;
        private System.Windows.Forms.TreeView TV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdImport;
        private System.Windows.Forms.Button cmdDebugForm;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.CheckBox chkShowVersion;
        private System.Windows.Forms.CheckBox chkShowModelName;
        private System.Windows.Forms.Button cmdExpandAll;
        private System.Windows.Forms.Button cmdExpandPackages;
        private System.Windows.Forms.Panel grpTreeButtons;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox chkShowModelCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMessages;
        private System.Windows.Forms.CheckBox chkShowDebugMessages;
        private System.Windows.Forms.Button cmdLoadDemoData;
    }
}

