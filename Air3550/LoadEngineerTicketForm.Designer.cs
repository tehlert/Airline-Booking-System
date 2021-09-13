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
    //this is autogen code from winforms
    partial class LoadEngineerTicketForm
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
            this.originEngineerComboBox = new System.Windows.Forms.ComboBox();
            this.destinationEngineerComboBox = new System.Windows.Forms.ComboBox();
            this.editFlightButton = new System.Windows.Forms.Button();
            this.deleteFlightButton = new System.Windows.Forms.Button();
            this.saveChangesEngineerButton = new System.Windows.Forms.Button();
            this.discardChangesEngineerButton = new System.Windows.Forms.Button();
            this.flightTimeEngineerTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.originLabel = new System.Windows.Forms.Label();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // originEngineerComboBox
            // 
            this.originEngineerComboBox.Enabled = false;
            this.originEngineerComboBox.FormattingEnabled = true;
            this.originEngineerComboBox.Location = new System.Drawing.Point(248, 15);
            this.originEngineerComboBox.Name = "originEngineerComboBox";
            this.originEngineerComboBox.Size = new System.Drawing.Size(131, 23);
            this.originEngineerComboBox.TabIndex = 0;
            // 
            // destinationEngineerComboBox
            // 
            this.destinationEngineerComboBox.Enabled = false;
            this.destinationEngineerComboBox.FormattingEnabled = true;
            this.destinationEngineerComboBox.Location = new System.Drawing.Point(541, 15);
            this.destinationEngineerComboBox.Name = "destinationEngineerComboBox";
            this.destinationEngineerComboBox.Size = new System.Drawing.Size(131, 23);
            this.destinationEngineerComboBox.TabIndex = 1;
            // 
            // editFlightButton
            // 
            this.editFlightButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editFlightButton.BackColor = System.Drawing.Color.Red;
            this.editFlightButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
            this.editFlightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editFlightButton.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editFlightButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.editFlightButton.Location = new System.Drawing.Point(708, 12);
            this.editFlightButton.Name = "editFlightButton";
            this.editFlightButton.Size = new System.Drawing.Size(141, 38);
            this.editFlightButton.TabIndex = 87;
            this.editFlightButton.Text = "Edit Route";
            this.editFlightButton.UseVisualStyleBackColor = false;
            this.editFlightButton.Click += new System.EventHandler(this.editFlightButton_Click);
            // 
            // deleteFlightButton
            // 
            this.deleteFlightButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteFlightButton.BackColor = System.Drawing.Color.Red;
            this.deleteFlightButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
            this.deleteFlightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteFlightButton.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteFlightButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.deleteFlightButton.Location = new System.Drawing.Point(561, 86);
            this.deleteFlightButton.Name = "deleteFlightButton";
            this.deleteFlightButton.Size = new System.Drawing.Size(141, 38);
            this.deleteFlightButton.TabIndex = 88;
            this.deleteFlightButton.Text = "Delete Route";
            this.deleteFlightButton.UseVisualStyleBackColor = false;
            this.deleteFlightButton.Visible = false;
            this.deleteFlightButton.Click += new System.EventHandler(this.deleteFlightButton_Click);
            // 
            // saveChangesEngineerButton
            // 
            this.saveChangesEngineerButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveChangesEngineerButton.BackColor = System.Drawing.Color.Red;
            this.saveChangesEngineerButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
            this.saveChangesEngineerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveChangesEngineerButton.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveChangesEngineerButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.saveChangesEngineerButton.Location = new System.Drawing.Point(240, 86);
            this.saveChangesEngineerButton.Name = "saveChangesEngineerButton";
            this.saveChangesEngineerButton.Size = new System.Drawing.Size(141, 38);
            this.saveChangesEngineerButton.TabIndex = 89;
            this.saveChangesEngineerButton.Text = "Save Route";
            this.saveChangesEngineerButton.UseVisualStyleBackColor = false;
            this.saveChangesEngineerButton.Visible = false;
            this.saveChangesEngineerButton.Click += new System.EventHandler(this.saveChangesEngineerButton_Click);
            // 
            // discardChangesEngineerButton
            // 
            this.discardChangesEngineerButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.discardChangesEngineerButton.BackColor = System.Drawing.Color.Red;
            this.discardChangesEngineerButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
            this.discardChangesEngineerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.discardChangesEngineerButton.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.discardChangesEngineerButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.discardChangesEngineerButton.Location = new System.Drawing.Point(387, 86);
            this.discardChangesEngineerButton.Name = "discardChangesEngineerButton";
            this.discardChangesEngineerButton.Size = new System.Drawing.Size(168, 38);
            this.discardChangesEngineerButton.TabIndex = 90;
            this.discardChangesEngineerButton.Text = "Clear Changes";
            this.discardChangesEngineerButton.UseVisualStyleBackColor = false;
            this.discardChangesEngineerButton.Visible = false;
            this.discardChangesEngineerButton.Click += new System.EventHandler(this.discardChangesEngineerButton_Click);
            // 
            // flightTimeEngineerTextBox
            // 
            this.flightTimeEngineerTextBox.Enabled = false;
            this.flightTimeEngineerTextBox.Location = new System.Drawing.Point(637, 54);
            this.flightTimeEngineerTextBox.Name = "flightTimeEngineerTextBox";
            this.flightTimeEngineerTextBox.Size = new System.Drawing.Size(48, 23);
            this.flightTimeEngineerTextBox.TabIndex = 91;
            this.flightTimeEngineerTextBox.Text = "6:09";
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelButton.BackColor = System.Drawing.Color.Red;
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cancelButton.Location = new System.Drawing.Point(708, 86);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(141, 38);
            this.cancelButton.TabIndex = 92;
            this.cancelButton.Text = "Close";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // originLabel
            // 
            this.originLabel.AutoSize = true;
            this.originLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.originLabel.ForeColor = System.Drawing.Color.White;
            this.originLabel.Location = new System.Drawing.Point(157, 12);
            this.originLabel.Name = "originLabel";
            this.originLabel.Size = new System.Drawing.Size(94, 29);
            this.originLabel.TabIndex = 93;
            this.originLabel.Text = "Origin:";
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.destinationLabel.ForeColor = System.Drawing.Color.White;
            this.destinationLabel.Location = new System.Drawing.Point(385, 12);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(159, 29);
            this.destinationLabel.TabIndex = 94;
            this.destinationLabel.Text = "Destination:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(559, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 29);
            this.label1.TabIndex = 96;
            this.label1.Text = "Time:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Air3550.Properties.Resources.airplane;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 98;
            this.pictureBox1.TabStop = false;
            // 
            // LoadEngineerTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(861, 136);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.destinationLabel);
            this.Controls.Add(this.originLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.flightTimeEngineerTextBox);
            this.Controls.Add(this.discardChangesEngineerButton);
            this.Controls.Add(this.saveChangesEngineerButton);
            this.Controls.Add(this.deleteFlightButton);
            this.Controls.Add(this.editFlightButton);
            this.Controls.Add(this.destinationEngineerComboBox);
            this.Controls.Add(this.originEngineerComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadEngineerTicketForm";
            this.Text = "LoadEngineerTicketForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox originEngineerComboBox;
        private System.Windows.Forms.ComboBox destinationEngineerComboBox;
        private System.Windows.Forms.Label departureTimeLabel;
        private System.Windows.Forms.Button editFlightButton;
        private System.Windows.Forms.Button deleteFlightButton;
        private System.Windows.Forms.Button saveChangesEngineerButton;
        private System.Windows.Forms.Button discardChangesButton;
        private System.Windows.Forms.Button discardChangesEngineerButton;
        private System.Windows.Forms.TextBox flightTimeEngineerTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label originLabel;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}