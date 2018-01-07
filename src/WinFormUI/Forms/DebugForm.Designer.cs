namespace AXBusiness.D365MetaExplorer.WinFormUI
{
    partial class DebugForm
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
            this.lstPackages = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstModels = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModelDetails = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPackageDetails = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstPackages
            // 
            this.lstPackages.FormattingEnabled = true;
            this.lstPackages.Location = new System.Drawing.Point(15, 25);
            this.lstPackages.Name = "lstPackages";
            this.lstPackages.Size = new System.Drawing.Size(213, 472);
            this.lstPackages.TabIndex = 0;
            this.lstPackages.SelectedIndexChanged += new System.EventHandler(this.lstPackages_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Packages:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Models:";
            // 
            // lstModels
            // 
            this.lstModels.FormattingEnabled = true;
            this.lstModels.Location = new System.Drawing.Point(251, 25);
            this.lstModels.Name = "lstModels";
            this.lstModels.Size = new System.Drawing.Size(213, 472);
            this.lstModels.TabIndex = 2;
            this.lstModels.SelectedIndexChanged += new System.EventHandler(this.lstModels_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(484, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Package Details:";
            // 
            // txtModelDetails
            // 
            this.txtModelDetails.Location = new System.Drawing.Point(487, 120);
            this.txtModelDetails.Multiline = true;
            this.txtModelDetails.Name = "txtModelDetails";
            this.txtModelDetails.ReadOnly = true;
            this.txtModelDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtModelDetails.Size = new System.Drawing.Size(346, 377);
            this.txtModelDetails.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(484, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Model Details:";
            // 
            // txtPackageDetails
            // 
            this.txtPackageDetails.Location = new System.Drawing.Point(487, 25);
            this.txtPackageDetails.Multiline = true;
            this.txtPackageDetails.Name = "txtPackageDetails";
            this.txtPackageDetails.ReadOnly = true;
            this.txtPackageDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPackageDetails.Size = new System.Drawing.Size(346, 64);
            this.txtPackageDetails.TabIndex = 7;
            // 
            // DebugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 514);
            this.Controls.Add(this.txtPackageDetails);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtModelDetails);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstModels);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstPackages);
            this.Name = "DebugForm";
            this.Text = "DebugForm";
            this.Load += new System.EventHandler(this.DebugForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPackages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstModels;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtModelDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPackageDetails;
    }
}