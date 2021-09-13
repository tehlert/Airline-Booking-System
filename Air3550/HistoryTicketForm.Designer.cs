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
    partial class HistoryTicketForm
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
            this.departAirportLabel = new System.Windows.Forms.Label();
            this.arrivalAirportLabel = new System.Windows.Forms.Label();
            this.departLabel = new System.Windows.Forms.Label();
            this.arrivalLabel = new System.Windows.Forms.Label();
            this.takenLabel = new System.Windows.Forms.Label();
            this.takenYesNoLabel = new System.Windows.Forms.Label();
            this.departDateTimeLabel = new System.Windows.Forms.Label();
            this.cancelFlightButton = new System.Windows.Forms.Button();
            this.printPassButton = new System.Windows.Forms.Button();
            this.roundTripDepartingTimeLabel = new System.Windows.Forms.Label();
            this.roundTripOriginLabel = new System.Windows.Forms.Label();
            this.roundTripDestinationLabel = new System.Windows.Forms.Label();
            this.roundTripArrivalTimeLabel = new System.Windows.Forms.Label();
            this.returnTripDateLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.paymentMethodLabel = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.paymentTypeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.canceledYesNoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // departAirportLabel
            // 
            this.departAirportLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.departAirportLabel.AutoSize = true;
            this.departAirportLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.departAirportLabel.ForeColor = System.Drawing.Color.White;
            this.departAirportLabel.Location = new System.Drawing.Point(3, 87);
            this.departAirportLabel.Name = "departAirportLabel";
            this.departAirportLabel.Size = new System.Drawing.Size(61, 29);
            this.departAirportLabel.TabIndex = 82;
            this.departAirportLabel.Text = "AAA";
            // 
            // arrivalAirportLabel
            // 
            this.arrivalAirportLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.arrivalAirportLabel.AutoSize = true;
            this.arrivalAirportLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.arrivalAirportLabel.ForeColor = System.Drawing.Color.White;
            this.arrivalAirportLabel.Location = new System.Drawing.Point(88, 87);
            this.arrivalAirportLabel.Name = "arrivalAirportLabel";
            this.arrivalAirportLabel.Size = new System.Drawing.Size(58, 29);
            this.arrivalAirportLabel.TabIndex = 83;
            this.arrivalAirportLabel.Text = "ZZZ";
            // 
            // departLabel
            // 
            this.departLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.departLabel.AutoSize = true;
            this.departLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.departLabel.ForeColor = System.Drawing.Color.White;
            this.departLabel.Location = new System.Drawing.Point(3, 119);
            this.departLabel.Name = "departLabel";
            this.departLabel.Size = new System.Drawing.Size(67, 29);
            this.departLabel.TabIndex = 84;
            this.departLabel.Text = "6:47";
            // 
            // arrivalLabel
            // 
            this.arrivalLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.arrivalLabel.AutoSize = true;
            this.arrivalLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.arrivalLabel.ForeColor = System.Drawing.Color.White;
            this.arrivalLabel.Location = new System.Drawing.Point(79, 120);
            this.arrivalLabel.Name = "arrivalLabel";
            this.arrivalLabel.Size = new System.Drawing.Size(67, 29);
            this.arrivalLabel.TabIndex = 85;
            this.arrivalLabel.Text = "8:57";
            // 
            // takenLabel
            // 
            this.takenLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.takenLabel.AutoSize = true;
            this.takenLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.takenLabel.ForeColor = System.Drawing.Color.White;
            this.takenLabel.Location = new System.Drawing.Point(187, 242);
            this.takenLabel.Name = "takenLabel";
            this.takenLabel.Size = new System.Drawing.Size(102, 29);
            this.takenLabel.TabIndex = 87;
            this.takenLabel.Text = "Taken -";
            this.takenLabel.Visible = false;
            // 
            // takenYesNoLabel
            // 
            this.takenYesNoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.takenYesNoLabel.AutoSize = true;
            this.takenYesNoLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.takenYesNoLabel.ForeColor = System.Drawing.Color.White;
            this.takenYesNoLabel.Location = new System.Drawing.Point(295, 242);
            this.takenYesNoLabel.Name = "takenYesNoLabel";
            this.takenYesNoLabel.Size = new System.Drawing.Size(47, 29);
            this.takenYesNoLabel.TabIndex = 90;
            this.takenYesNoLabel.Text = "No";
            this.takenYesNoLabel.Visible = false;
            // 
            // departDateTimeLabel
            // 
            this.departDateTimeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.departDateTimeLabel.AutoSize = true;
            this.departDateTimeLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.departDateTimeLabel.ForeColor = System.Drawing.Color.White;
            this.departDateTimeLabel.Location = new System.Drawing.Point(9, 58);
            this.departDateTimeLabel.Name = "departDateTimeLabel";
            this.departDateTimeLabel.Size = new System.Drawing.Size(131, 29);
            this.departDateTimeLabel.TabIndex = 91;
            this.departDateTimeLabel.Text = "1/5/2022";
            // 
            // cancelFlightButton
            // 
            this.cancelFlightButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelFlightButton.BackColor = System.Drawing.Color.Red;
            this.cancelFlightButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
            this.cancelFlightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelFlightButton.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelFlightButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cancelFlightButton.Location = new System.Drawing.Point(254, 12);
            this.cancelFlightButton.Name = "cancelFlightButton";
            this.cancelFlightButton.Size = new System.Drawing.Size(114, 32);
            this.cancelFlightButton.TabIndex = 93;
            this.cancelFlightButton.Text = "Cancel";
            this.cancelFlightButton.UseVisualStyleBackColor = false;
            this.cancelFlightButton.Click += new System.EventHandler(this.cancelFlightButton_Click);
            // 
            // printPassButton
            // 
            this.printPassButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.printPassButton.BackColor = System.Drawing.Color.Red;
            this.printPassButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
            this.printPassButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printPassButton.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.printPassButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.printPassButton.Location = new System.Drawing.Point(2, 12);
            this.printPassButton.Name = "printPassButton";
            this.printPassButton.Size = new System.Drawing.Size(201, 32);
            this.printPassButton.TabIndex = 94;
            this.printPassButton.Text = "Print Boarding Pass";
            this.printPassButton.UseVisualStyleBackColor = false;
            this.printPassButton.Click += new System.EventHandler(this.printPassButton_Click);
            // 
            // roundTripDepartingTimeLabel
            // 
            this.roundTripDepartingTimeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundTripDepartingTimeLabel.AutoSize = true;
            this.roundTripDepartingTimeLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roundTripDepartingTimeLabel.ForeColor = System.Drawing.Color.White;
            this.roundTripDepartingTimeLabel.Location = new System.Drawing.Point(3, 235);
            this.roundTripDepartingTimeLabel.Name = "roundTripDepartingTimeLabel";
            this.roundTripDepartingTimeLabel.Size = new System.Drawing.Size(67, 29);
            this.roundTripDepartingTimeLabel.TabIndex = 95;
            this.roundTripDepartingTimeLabel.Text = "6:47";
            this.roundTripDepartingTimeLabel.Visible = false;
            // 
            // roundTripOriginLabel
            // 
            this.roundTripOriginLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundTripOriginLabel.AutoSize = true;
            this.roundTripOriginLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roundTripOriginLabel.ForeColor = System.Drawing.Color.White;
            this.roundTripOriginLabel.Location = new System.Drawing.Point(3, 206);
            this.roundTripOriginLabel.Name = "roundTripOriginLabel";
            this.roundTripOriginLabel.Size = new System.Drawing.Size(61, 29);
            this.roundTripOriginLabel.TabIndex = 96;
            this.roundTripOriginLabel.Text = "AAA";
            this.roundTripOriginLabel.Visible = false;
            // 
            // roundTripDestinationLabel
            // 
            this.roundTripDestinationLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundTripDestinationLabel.AutoSize = true;
            this.roundTripDestinationLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roundTripDestinationLabel.ForeColor = System.Drawing.Color.White;
            this.roundTripDestinationLabel.Location = new System.Drawing.Point(79, 206);
            this.roundTripDestinationLabel.Name = "roundTripDestinationLabel";
            this.roundTripDestinationLabel.Size = new System.Drawing.Size(61, 29);
            this.roundTripDestinationLabel.TabIndex = 97;
            this.roundTripDestinationLabel.Text = "AAA";
            this.roundTripDestinationLabel.Visible = false;
            // 
            // roundTripArrivalTimeLabel
            // 
            this.roundTripArrivalTimeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundTripArrivalTimeLabel.AutoSize = true;
            this.roundTripArrivalTimeLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roundTripArrivalTimeLabel.ForeColor = System.Drawing.Color.White;
            this.roundTripArrivalTimeLabel.Location = new System.Drawing.Point(79, 235);
            this.roundTripArrivalTimeLabel.Name = "roundTripArrivalTimeLabel";
            this.roundTripArrivalTimeLabel.Size = new System.Drawing.Size(67, 29);
            this.roundTripArrivalTimeLabel.TabIndex = 98;
            this.roundTripArrivalTimeLabel.Text = "8:57";
            this.roundTripArrivalTimeLabel.Visible = false;
            // 
            // returnTripDateLabel
            // 
            this.returnTripDateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.returnTripDateLabel.AutoSize = true;
            this.returnTripDateLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.returnTripDateLabel.ForeColor = System.Drawing.Color.White;
            this.returnTripDateLabel.Location = new System.Drawing.Point(3, 167);
            this.returnTripDateLabel.Name = "returnTripDateLabel";
            this.returnTripDateLabel.Size = new System.Drawing.Size(101, 29);
            this.returnTripDateLabel.TabIndex = 99;
            this.returnTripDateLabel.Text = "1/5/99";
            this.returnTripDateLabel.Visible = false;
            // 
            // costLabel
            // 
            this.costLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.costLabel.ForeColor = System.Drawing.Color.White;
            this.costLabel.Location = new System.Drawing.Point(187, 58);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(75, 29);
            this.costLabel.TabIndex = 100;
            this.costLabel.Text = "Cost:";
            // 
            // paymentMethodLabel
            // 
            this.paymentMethodLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.paymentMethodLabel.AutoSize = true;
            this.paymentMethodLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.paymentMethodLabel.ForeColor = System.Drawing.Color.White;
            this.paymentMethodLabel.Location = new System.Drawing.Point(187, 131);
            this.paymentMethodLabel.Name = "paymentMethodLabel";
            this.paymentMethodLabel.Size = new System.Drawing.Size(128, 29);
            this.paymentMethodLabel.TabIndex = 102;
            this.paymentMethodLabel.Text = "Payment:";
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalCostLabel.ForeColor = System.Drawing.Color.White;
            this.totalCostLabel.Location = new System.Drawing.Point(213, 102);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(96, 29);
            this.totalCostLabel.TabIndex = 103;
            this.totalCostLabel.Text = "192.25";
            // 
            // paymentTypeLabel
            // 
            this.paymentTypeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.paymentTypeLabel.AutoSize = true;
            this.paymentTypeLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.paymentTypeLabel.ForeColor = System.Drawing.Color.White;
            this.paymentTypeLabel.Location = new System.Drawing.Point(213, 167);
            this.paymentTypeLabel.Name = "paymentTypeLabel";
            this.paymentTypeLabel.Size = new System.Drawing.Size(61, 29);
            this.paymentTypeLabel.TabIndex = 104;
            this.paymentTypeLabel.Text = "AAA";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(187, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 29);
            this.label1.TabIndex = 105;
            this.label1.Text = "Canceled -";
            // 
            // canceledYesNoLabel
            // 
            this.canceledYesNoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.canceledYesNoLabel.AutoSize = true;
            this.canceledYesNoLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.canceledYesNoLabel.ForeColor = System.Drawing.Color.White;
            this.canceledYesNoLabel.Location = new System.Drawing.Point(322, 206);
            this.canceledYesNoLabel.Name = "canceledYesNoLabel";
            this.canceledYesNoLabel.Size = new System.Drawing.Size(55, 29);
            this.canceledYesNoLabel.TabIndex = 106;
            this.canceledYesNoLabel.Text = "Yes";
            // 
            // HistoryTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(380, 280);
            this.Controls.Add(this.canceledYesNoLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paymentTypeLabel);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.paymentMethodLabel);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.returnTripDateLabel);
            this.Controls.Add(this.roundTripArrivalTimeLabel);
            this.Controls.Add(this.roundTripDestinationLabel);
            this.Controls.Add(this.roundTripOriginLabel);
            this.Controls.Add(this.roundTripDepartingTimeLabel);
            this.Controls.Add(this.printPassButton);
            this.Controls.Add(this.cancelFlightButton);
            this.Controls.Add(this.departDateTimeLabel);
            this.Controls.Add(this.takenYesNoLabel);
            this.Controls.Add(this.takenLabel);
            this.Controls.Add(this.arrivalLabel);
            this.Controls.Add(this.departLabel);
            this.Controls.Add(this.arrivalAirportLabel);
            this.Controls.Add(this.departAirportLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HistoryTicketForm";
            this.Text = "HistoryTicketForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label departAirportLabel;
        private System.Windows.Forms.Label arrivalAirportLabel;
        private System.Windows.Forms.Label departLabel;
        private System.Windows.Forms.Label arrivalLabel;
        private System.Windows.Forms.Label takenLabel;
        private System.Windows.Forms.Label takenYesNoLabel;
        private System.Windows.Forms.Label departDateTimeLabel;
        private System.Windows.Forms.Button cancelFlightButton;
        private System.Windows.Forms.Button printPassButton;
        private System.Windows.Forms.Label roundTripDepartingTimeLabel;
        private System.Windows.Forms.Label roundTripOriginLabel;
        private System.Windows.Forms.Label roundTripDestinationLabel;
        private System.Windows.Forms.Label roundTripArrivalTimeLabel;
        private System.Windows.Forms.Label returnTripDateLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label paymentMethodLabel;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label paymentTypeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label canceledYesNoLabel;
    }
}