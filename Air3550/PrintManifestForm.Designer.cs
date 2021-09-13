/*
 Air 3550 Project Team 7

This program is a basic flight reservation system for a fake airline company
It allows customers to book, manage, cancel, and browse flights within a database.
It also allows employee accounts to update and manage flights and view business statistics.

Written by: Harrison Kania, Tyler Ehlert, Daniel Wellons
For EECS3550-001 Software Engineering, Instructor: Dr. Thomas 
 */
namespace Air3550
{
    //autogen code from winforms
    partial class PrintManifestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintManifestForm));
            this.label1 = new System.Windows.Forms.Label();
            this.manifestFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 29);
            this.label1.TabIndex = 91;
            this.label1.Text = "Customer List:";
            this.label1.UseMnemonic = false;
            // 
            // manifestFlowLayoutPanel
            // 
            this.manifestFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.manifestFlowLayoutPanel.AutoScroll = true;
            this.manifestFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.manifestFlowLayoutPanel.Location = new System.Drawing.Point(12, 41);
            this.manifestFlowLayoutPanel.Name = "manifestFlowLayoutPanel";
            this.manifestFlowLayoutPanel.Size = new System.Drawing.Size(852, 502);
            this.manifestFlowLayoutPanel.TabIndex = 92;
            this.manifestFlowLayoutPanel.WrapContents = false;
            this.manifestFlowLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.manifestFlowLayoutPanel_Paint);
            // 
            // PrintManifestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(876, 559);
            this.Controls.Add(this.manifestFlowLayoutPanel);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrintManifestForm";
            this.Text = "PrintManifestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel manifestFlowLayoutPanel;
    }
}