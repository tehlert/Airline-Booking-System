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
    partial class TicketForm
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
            this.priceLabel = new System.Windows.Forms.Label();
            this.departLabel = new System.Windows.Forms.Label();
            this.arrivalLabel = new System.Windows.Forms.Label();
            this.flightTimeLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.legsLabel = new System.Windows.Forms.Label();
            this.bookFlightButton = new System.Windows.Forms.Button();
            this.departAirportLabel = new System.Windows.Forms.Label();
            this.arrivalAirportLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // priceLabel
            // 
            this.priceLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.priceLabel.ForeColor = System.Drawing.Color.White;
            this.priceLabel.Location = new System.Drawing.Point(770, 64);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(58, 29);
            this.priceLabel.TabIndex = 73;
            this.priceLabel.Text = "$20";
            // 
            // departLabel
            // 
            this.departLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.departLabel.AutoSize = true;
            this.departLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.departLabel.ForeColor = System.Drawing.Color.White;
            this.departLabel.Location = new System.Drawing.Point(30, 64);
            this.departLabel.Name = "departLabel";
            this.departLabel.Size = new System.Drawing.Size(67, 29);
            this.departLabel.TabIndex = 74;
            this.departLabel.Text = "6:47";
            // 
            // arrivalLabel
            // 
            this.arrivalLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.arrivalLabel.AutoSize = true;
            this.arrivalLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.arrivalLabel.ForeColor = System.Drawing.Color.White;
            this.arrivalLabel.Location = new System.Drawing.Point(355, 64);
            this.arrivalLabel.Name = "arrivalLabel";
            this.arrivalLabel.Size = new System.Drawing.Size(67, 29);
            this.arrivalLabel.TabIndex = 75;
            this.arrivalLabel.Text = "8:57";
            // 
            // flightTimeLabel
            // 
            this.flightTimeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flightTimeLabel.AutoSize = true;
            this.flightTimeLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.flightTimeLabel.ForeColor = System.Drawing.Color.White;
            this.flightTimeLabel.Location = new System.Drawing.Point(156, 64);
            this.flightTimeLabel.Name = "flightTimeLabel";
            this.flightTimeLabel.Size = new System.Drawing.Size(50, 29);
            this.flightTimeLabel.TabIndex = 76;
            this.flightTimeLabel.Text = "2 h";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Air3550.Properties.Resources.airplane;
            this.pictureBox1.Location = new System.Drawing.Point(199, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            // 
            // legsLabel
            // 
            this.legsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.legsLabel.AutoSize = true;
            this.legsLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.legsLabel.ForeColor = System.Drawing.Color.White;
            this.legsLabel.Location = new System.Drawing.Point(480, 64);
            this.legsLabel.Name = "legsLabel";
            this.legsLabel.Size = new System.Drawing.Size(117, 29);
            this.legsLabel.TabIndex = 78;
            this.legsLabel.Text = "NonStop";
            // 
            // bookFlightButton
            // 
            this.bookFlightButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bookFlightButton.BackColor = System.Drawing.Color.Red;
            this.bookFlightButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
            this.bookFlightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookFlightButton.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bookFlightButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bookFlightButton.Location = new System.Drawing.Point(744, 97);
            this.bookFlightButton.Name = "bookFlightButton";
            this.bookFlightButton.Size = new System.Drawing.Size(132, 32);
            this.bookFlightButton.TabIndex = 80;
            this.bookFlightButton.Text = "Book Flight";
            this.bookFlightButton.UseVisualStyleBackColor = false;
            this.bookFlightButton.Click += new System.EventHandler(this.bookFlightButton_Click);
            // 
            // departAirportLabel
            // 
            this.departAirportLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.departAirportLabel.AutoSize = true;
            this.departAirportLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.departAirportLabel.ForeColor = System.Drawing.Color.White;
            this.departAirportLabel.Location = new System.Drawing.Point(6, 9);
            this.departAirportLabel.Name = "departAirportLabel";
            this.departAirportLabel.Size = new System.Drawing.Size(61, 29);
            this.departAirportLabel.TabIndex = 81;
            this.departAirportLabel.Text = "AAA";
            // 
            // arrivalAirportLabel
            // 
            this.arrivalAirportLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.arrivalAirportLabel.AutoSize = true;
            this.arrivalAirportLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.arrivalAirportLabel.ForeColor = System.Drawing.Color.White;
            this.arrivalAirportLabel.Location = new System.Drawing.Point(315, 9);
            this.arrivalAirportLabel.Name = "arrivalAirportLabel";
            this.arrivalAirportLabel.Size = new System.Drawing.Size(58, 29);
            this.arrivalAirportLabel.TabIndex = 82;
            this.arrivalAirportLabel.Text = "ZZZ";
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(888, 141);
            this.Controls.Add(this.arrivalAirportLabel);
            this.Controls.Add(this.departAirportLabel);
            this.Controls.Add(this.bookFlightButton);
            this.Controls.Add(this.legsLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flightTimeLabel);
            this.Controls.Add(this.arrivalLabel);
            this.Controls.Add(this.departLabel);
            this.Controls.Add(this.priceLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TicketForm";
            this.Text = "TicketForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label departLabel;
        private System.Windows.Forms.Label arrivalLabel;
        private System.Windows.Forms.Label flightTimeLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label legsLabel;
        private System.Windows.Forms.Button bookFlightButton;
        private System.Windows.Forms.Label departAirportLabel;
        private System.Windows.Forms.Label arrivalAirportLabel;
    }
}