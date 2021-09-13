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
    partial class FlightManagerTicketForm
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
            this.originAirportLabel = new System.Windows.Forms.Label();
            this.destinationAirportLabel = new System.Windows.Forms.Label();
            this.dateOfFlightLabel = new System.Windows.Forms.Label();
            this.numberOfPassengersLabel = new System.Windows.Forms.Label();
            this.printManifestButton = new System.Windows.Forms.Button();
            this.flightNumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // originAirportLabel
            // 
            this.originAirportLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.originAirportLabel.AutoSize = true;
            this.originAirportLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.originAirportLabel.ForeColor = System.Drawing.Color.White;
            this.originAirportLabel.Location = new System.Drawing.Point(211, 37);
            this.originAirportLabel.Name = "originAirportLabel";
            this.originAirportLabel.Size = new System.Drawing.Size(61, 29);
            this.originAirportLabel.TabIndex = 82;
            this.originAirportLabel.Text = "AAA";
            // 
            // destinationAirportLabel
            // 
            this.destinationAirportLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.destinationAirportLabel.AutoSize = true;
            this.destinationAirportLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.destinationAirportLabel.ForeColor = System.Drawing.Color.White;
            this.destinationAirportLabel.Location = new System.Drawing.Point(368, 37);
            this.destinationAirportLabel.Name = "destinationAirportLabel";
            this.destinationAirportLabel.Size = new System.Drawing.Size(58, 29);
            this.destinationAirportLabel.TabIndex = 83;
            this.destinationAirportLabel.Text = "ZZZ";
            // 
            // dateOfFlightLabel
            // 
            this.dateOfFlightLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateOfFlightLabel.AutoSize = true;
            this.dateOfFlightLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateOfFlightLabel.ForeColor = System.Drawing.Color.White;
            this.dateOfFlightLabel.Location = new System.Drawing.Point(33, 37);
            this.dateOfFlightLabel.Name = "dateOfFlightLabel";
            this.dateOfFlightLabel.Size = new System.Drawing.Size(116, 29);
            this.dateOfFlightLabel.TabIndex = 84;
            this.dateOfFlightLabel.Text = "1/05/21";
            // 
            // numberOfPassengersLabel
            // 
            this.numberOfPassengersLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numberOfPassengersLabel.AutoSize = true;
            this.numberOfPassengersLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numberOfPassengersLabel.ForeColor = System.Drawing.Color.White;
            this.numberOfPassengersLabel.Location = new System.Drawing.Point(531, 37);
            this.numberOfPassengersLabel.Name = "numberOfPassengersLabel";
            this.numberOfPassengersLabel.Size = new System.Drawing.Size(43, 29);
            this.numberOfPassengersLabel.TabIndex = 85;
            this.numberOfPassengersLabel.Text = "26";
            // 
            // printManifestButton
            // 
            this.printManifestButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.printManifestButton.BackColor = System.Drawing.Color.Red;
            this.printManifestButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
            this.printManifestButton.FlatAppearance.BorderSize = 0;
            this.printManifestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printManifestButton.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.printManifestButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.printManifestButton.Location = new System.Drawing.Point(633, 26);
            this.printManifestButton.Name = "printManifestButton";
            this.printManifestButton.Size = new System.Drawing.Size(223, 40);
            this.printManifestButton.TabIndex = 86;
            this.printManifestButton.TabStop = false;
            this.printManifestButton.Text = "Print Manifest";
            this.printManifestButton.UseVisualStyleBackColor = false;
            this.printManifestButton.Click += new System.EventHandler(this.printManifestButton_Click);
            // 
            // flightNumberLabel
            // 
            this.flightNumberLabel.AutoSize = true;
            this.flightNumberLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.flightNumberLabel.ForeColor = System.Drawing.Color.White;
            this.flightNumberLabel.Location = new System.Drawing.Point(12, 8);
            this.flightNumberLabel.Name = "flightNumberLabel";
            this.flightNumberLabel.Size = new System.Drawing.Size(43, 29);
            this.flightNumberLabel.TabIndex = 92;
            this.flightNumberLabel.Text = "00";
            this.flightNumberLabel.UseMnemonic = false;
            // 
            // FlightManagerTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(863, 93);
            this.Controls.Add(this.flightNumberLabel);
            this.Controls.Add(this.printManifestButton);
            this.Controls.Add(this.numberOfPassengersLabel);
            this.Controls.Add(this.dateOfFlightLabel);
            this.Controls.Add(this.destinationAirportLabel);
            this.Controls.Add(this.originAirportLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FlightManagerTicketForm";
            this.Text = "FlightManagerTicketForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label originAirportLabel;
        private System.Windows.Forms.Label destinationAirportLabel;
        private System.Windows.Forms.Label dateOfFlightLabel;
        private System.Windows.Forms.Label numberOfPassengersLabel;
        public System.Windows.Forms.Button printManifestButton;
        private System.Windows.Forms.Label flightNumberLabel;
    }
}