﻿namespace AXBusiness.D365MetaExplorer.WinFormUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMetaDataStoreLocation = new System.Windows.Forms.TextBox();
            this.cmdLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Metadata store location:";
            // 
            // txtMetaDataStoreLocation
            // 
            this.txtMetaDataStoreLocation.Location = new System.Drawing.Point(12, 25);
            this.txtMetaDataStoreLocation.Name = "txtMetaDataStoreLocation";
            this.txtMetaDataStoreLocation.Size = new System.Drawing.Size(463, 20);
            this.txtMetaDataStoreLocation.TabIndex = 1;
            // 
            // cmdLoad
            // 
            this.cmdLoad.Location = new System.Drawing.Point(481, 23);
            this.cmdLoad.Name = "cmdLoad";
            this.cmdLoad.Size = new System.Drawing.Size(42, 23);
            this.cmdLoad.TabIndex = 2;
            this.cmdLoad.Text = "Load";
            this.cmdLoad.UseVisualStyleBackColor = true;
            this.cmdLoad.Click += new System.EventHandler(this.cmdLoad_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 181);
            this.Controls.Add(this.cmdLoad);
            this.Controls.Add(this.txtMetaDataStoreLocation);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMetaDataStoreLocation;
        private System.Windows.Forms.Button cmdLoad;
    }
}

