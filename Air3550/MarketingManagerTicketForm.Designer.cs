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
    partial class MarketingManagerTicketForm
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
            this.destinationAirportLabel = new System.Windows.Forms.Label();
            this.originAirportLabel = new System.Windows.Forms.Label();
            this.assignPlaneButton = new System.Windows.Forms.Button();
            this.routeTimeLabel = new System.Windows.Forms.Label();
            this.planeAssignedComboBox = new System.Windows.Forms.ComboBox();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.cancelChangesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // destinationAirportLabel
            // 
            this.destinationAirportLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.destinationAirportLabel.AutoSize = true;
            this.destinationAirportLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.destinationAirportLabel.ForeColor = System.Drawing.Color.White;
            this.destinationAirportLabel.Location = new System.Drawing.Point(264, 40);
            this.destinationAirportLabel.Name = "destinationAirportLabel";
            this.destinationAirportLabel.Size = new System.Drawing.Size(58, 29);
            this.destinationAirportLabel.TabIndex = 88;
            this.destinationAirportLabel.Text = "ZZZ";
            // 
            // originAirportLabel
            // 
            this.originAirportLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.originAirportLabel.AutoSize = true;
            this.originAirportLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.originAirportLabel.ForeColor = System.Drawing.Color.White;
            this.originAirportLabel.Location = new System.Drawing.Point(179, 40);
            this.originAirportLabel.Name = "originAirportLabel";
            this.originAirportLabel.Size = new System.Drawing.Size(61, 29);
            this.originAirportLabel.TabIndex = 87;
            this.originAirportLabel.Text = "AAA";
            // 
            // assignPlaneButton
            // 
            this.assignPlaneButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.assignPlaneButton.BackColor = System.Drawing.Color.Red;
            this.assignPlaneButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
            this.assignPlaneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assignPlaneButton.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.assignPlaneButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.assignPlaneButton.Location = new System.Drawing.Point(734, 12);
            this.assignPlaneButton.Name = "assignPlaneButton";
            this.assignPlaneButton.Size = new System.Drawing.Size(141, 38);
            this.assignPlaneButton.TabIndex = 86;
            this.assignPlaneButton.Text = "Assign Plane";
            this.assignPlaneButton.UseVisualStyleBackColor = false;
            this.assignPlaneButton.Click += new System.EventHandler(this.assignPlaneButton_Click);
            // 
            // routeTimeLabel
            // 
            this.routeTimeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.routeTimeLabel.AutoSize = true;
            this.routeTimeLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.routeTimeLabel.ForeColor = System.Drawing.Color.White;
            this.routeTimeLabel.Location = new System.Drawing.Point(24, 40);
            this.routeTimeLabel.Name = "routeTimeLabel";
            this.routeTimeLabel.Size = new System.Drawing.Size(67, 29);
            this.routeTimeLabel.TabIndex = 83;
            this.routeTimeLabel.Text = "6:20";
            // 
            // planeAssignedComboBox
            // 
            this.planeAssignedComboBox.Enabled = false;
            this.planeAssignedComboBox.FormattingEnabled = true;
            this.planeAssignedComboBox.Location = new System.Drawing.Point(534, 43);
            this.planeAssignedComboBox.Name = "planeAssignedComboBox";
            this.planeAssignedComboBox.Size = new System.Drawing.Size(144, 23);
            this.planeAssignedComboBox.TabIndex = 89;
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveChangesButton.BackColor = System.Drawing.Color.Red;
            this.saveChangesButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
            this.saveChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveChangesButton.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveChangesButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.saveChangesButton.Location = new System.Drawing.Point(695, 68);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(88, 38);
            this.saveChangesButton.TabIndex = 90;
            this.saveChangesButton.Text = "Save";
            this.saveChangesButton.UseVisualStyleBackColor = false;
            this.saveChangesButton.Visible = false;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // cancelChangesButton
            // 
            this.cancelChangesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelChangesButton.BackColor = System.Drawing.Color.Red;
            this.cancelChangesButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
            this.cancelChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelChangesButton.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelChangesButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cancelChangesButton.Location = new System.Drawing.Point(789, 68);
            this.cancelChangesButton.Name = "cancelChangesButton";
            this.cancelChangesButton.Size = new System.Drawing.Size(88, 38);
            this.cancelChangesButton.TabIndex = 91;
            this.cancelChangesButton.Text = "Cancel";
            this.cancelChangesButton.UseVisualStyleBackColor = false;
            this.cancelChangesButton.Visible = false;
            this.cancelChangesButton.Click += new System.EventHandler(this.cancelChangesButton_Click);
            // 
            // MarketingManagerTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(900, 109);
            this.Controls.Add(this.cancelChangesButton);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.planeAssignedComboBox);
            this.Controls.Add(this.destinationAirportLabel);
            this.Controls.Add(this.originAirportLabel);
            this.Controls.Add(this.assignPlaneButton);
            this.Controls.Add(this.routeTimeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MarketingManagerTicketForm";
            this.Text = "MarketingManagerTicketForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label destinationAirportLabel;
        private System.Windows.Forms.Label originAirportLabel;
        private System.Windows.Forms.Button assignPlaneButton;
        private System.Windows.Forms.Label routeTimeLabel;
        private System.Windows.Forms.ComboBox planeAssignedComboBox;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.Button cancelChangesButton;
    }
}