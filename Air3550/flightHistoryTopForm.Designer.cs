﻿/*
 Air 3550 Project Team 7

This program is a basic flight reservation system for a fake airline company
It allows customers to book, manage, cancel, and browse flights within a database.
It also allows employee accounts to update and manage flights and view business statistics.

Written by: Harrison Kania, Tyler Ehlert, Daniel Wellons
For EECS3550-001 Software Engineering, Instructor: Dr. Thomas 
 */
namespace Air3550
{
    //autogenerated by winforms
    partial class flightHistoryTopForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pointsUsedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Air3550.Properties.Resources.history;
            this.pictureBox1.Location = new System.Drawing.Point(380, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pointsUsedLabel
            // 
            this.pointsUsedLabel.AutoSize = true;
            this.pointsUsedLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pointsUsedLabel.ForeColor = System.Drawing.Color.White;
            this.pointsUsedLabel.Location = new System.Drawing.Point(12, 9);
            this.pointsUsedLabel.Name = "pointsUsedLabel";
            this.pointsUsedLabel.Size = new System.Drawing.Size(154, 29);
            this.pointsUsedLabel.TabIndex = 77;
            this.pointsUsedLabel.Text = "Points Used";
            this.pointsUsedLabel.Click += new System.EventHandler(this.pointsUsedLabel_Click);
            // 
            // flightHistoryTopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(940, 102);
            this.Controls.Add(this.pointsUsedLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "flightHistoryTopForm";
            this.Text = "flightHistoryTopForm";
            this.Load += new System.EventHandler(this.flightHistoryTopForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label pointsUsedLabel;
    }
}