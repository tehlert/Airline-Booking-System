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
    //This is all autogenerated code from winforms
    partial class AccountantTicketForm
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
            this.flightDateLabel = new System.Windows.Forms.Label();
            this.maxCapacityFlightLabel = new System.Windows.Forms.Label();
            this.ticketsSoldFlightLabel = new System.Windows.Forms.Label();
            this.percentFullFlightLabel = new System.Windows.Forms.Label();
            this.totalIncomeFlightLabel = new System.Windows.Forms.Label();
            this.flightNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Air3550.Properties.Resources.airplane;
            this.pictureBox1.Location = new System.Drawing.Point(12, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 78;
            this.pictureBox1.TabStop = false;
            // 
            // flightDateLabel
            // 
            this.flightDateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flightDateLabel.AutoSize = true;
            this.flightDateLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.flightDateLabel.ForeColor = System.Drawing.Color.White;
            this.flightDateLabel.Location = new System.Drawing.Point(137, 12);
            this.flightDateLabel.Name = "flightDateLabel";
            this.flightDateLabel.Size = new System.Drawing.Size(131, 29);
            this.flightDateLabel.TabIndex = 82;
            this.flightDateLabel.Text = "1/5/2021";
            // 
            // maxCapacityFlightLabel
            // 
            this.maxCapacityFlightLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maxCapacityFlightLabel.AutoSize = true;
            this.maxCapacityFlightLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.maxCapacityFlightLabel.ForeColor = System.Drawing.Color.White;
            this.maxCapacityFlightLabel.Location = new System.Drawing.Point(137, 56);
            this.maxCapacityFlightLabel.Name = "maxCapacityFlightLabel";
            this.maxCapacityFlightLabel.Size = new System.Drawing.Size(182, 29);
            this.maxCapacityFlightLabel.TabIndex = 83;
            this.maxCapacityFlightLabel.Text = "Max Capacity:";
            // 
            // ticketsSoldFlightLabel
            // 
            this.ticketsSoldFlightLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ticketsSoldFlightLabel.AutoSize = true;
            this.ticketsSoldFlightLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ticketsSoldFlightLabel.ForeColor = System.Drawing.Color.White;
            this.ticketsSoldFlightLabel.Location = new System.Drawing.Point(137, 85);
            this.ticketsSoldFlightLabel.Name = "ticketsSoldFlightLabel";
            this.ticketsSoldFlightLabel.Size = new System.Drawing.Size(166, 29);
            this.ticketsSoldFlightLabel.TabIndex = 84;
            this.ticketsSoldFlightLabel.Text = "Tickets Sold:";
            // 
            // percentFullFlightLabel
            // 
            this.percentFullFlightLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.percentFullFlightLabel.AutoSize = true;
            this.percentFullFlightLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.percentFullFlightLabel.ForeColor = System.Drawing.Color.White;
            this.percentFullFlightLabel.Location = new System.Drawing.Point(369, 88);
            this.percentFullFlightLabel.Name = "percentFullFlightLabel";
            this.percentFullFlightLabel.Size = new System.Drawing.Size(87, 29);
            this.percentFullFlightLabel.TabIndex = 85;
            this.percentFullFlightLabel.Text = "% full";
            // 
            // totalIncomeFlightLabel
            // 
            this.totalIncomeFlightLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalIncomeFlightLabel.AutoSize = true;
            this.totalIncomeFlightLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalIncomeFlightLabel.ForeColor = System.Drawing.Color.White;
            this.totalIncomeFlightLabel.Location = new System.Drawing.Point(274, 12);
            this.totalIncomeFlightLabel.Name = "totalIncomeFlightLabel";
            this.totalIncomeFlightLabel.Size = new System.Drawing.Size(182, 29);
            this.totalIncomeFlightLabel.TabIndex = 86;
            this.totalIncomeFlightLabel.Text = "Total Income:";
            // 
            // flightNumberLabel
            // 
            this.flightNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flightNumberLabel.AutoSize = true;
            this.flightNumberLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.flightNumberLabel.ForeColor = System.Drawing.Color.White;
            this.flightNumberLabel.Location = new System.Drawing.Point(12, 9);
            this.flightNumberLabel.Name = "flightNumberLabel";
            this.flightNumberLabel.Size = new System.Drawing.Size(43, 29);
            this.flightNumberLabel.TabIndex = 87;
            this.flightNumberLabel.Text = "00";
            // 
            // AccountantTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(558, 126);
            this.Controls.Add(this.flightNumberLabel);
            this.Controls.Add(this.totalIncomeFlightLabel);
            this.Controls.Add(this.percentFullFlightLabel);
            this.Controls.Add(this.ticketsSoldFlightLabel);
            this.Controls.Add(this.maxCapacityFlightLabel);
            this.Controls.Add(this.flightDateLabel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountantTicketForm";
            this.Text = "AccountantTicketForm";
            this.Load += new System.EventHandler(this.AccountantTicketForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label flightDateLabel;
        private System.Windows.Forms.Label maxCapacityFlightLabel;
        private System.Windows.Forms.Label ticketsSoldFlightLabel;
        private System.Windows.Forms.Label percentFullFlightLabel;
        private System.Windows.Forms.Label totalIncomeFlightLabel;
        private System.Windows.Forms.Label flightNumberLabel;
    }
}