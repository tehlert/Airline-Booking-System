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
    //this is autogen code form winforms
    partial class FlightManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightManagerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.accountantExitButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.endLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.browseFlightsButton = new System.Windows.Forms.Button();
            this.flightManagerFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.flightManagerLogOutButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(6)))), ((int)(((byte)(18)))));
            this.panel1.Controls.Add(this.accountantExitButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 712);
            this.panel1.TabIndex = 0;
            // 
            // accountantExitButton
            // 
            this.accountantExitButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.accountantExitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
            this.accountantExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountantExitButton.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.accountantExitButton.ForeColor = System.Drawing.Color.White;
            this.accountantExitButton.Location = new System.Drawing.Point(0, 141);
            this.accountantExitButton.Name = "accountantExitButton";
            this.accountantExitButton.Size = new System.Drawing.Size(260, 148);
            this.accountantExitButton.TabIndex = 6;
            this.accountantExitButton.Text = "Exit";
            this.accountantExitButton.UseVisualStyleBackColor = true;
            this.accountantExitButton.Click += new System.EventHandler(this.accountantExitButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flightManagerLogOutButton);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 141);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Air3550.Properties.Resources.airplane;
            this.pictureBox2.Location = new System.Drawing.Point(167, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(87, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Air3550.Properties.Resources.Loginicon;
            this.pictureBox1.Location = new System.Drawing.Point(6, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(50, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 28);
            this.label2.TabIndex = 17;
            this.label2.Text = "Flight Manager";
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
            this.topPanel.Controls.Add(this.button1);
            this.topPanel.Controls.Add(this.endLabel);
            this.topPanel.Controls.Add(this.startLabel);
            this.topPanel.Controls.Add(this.startDateTimePicker);
            this.topPanel.Controls.Add(this.endingDateTimePicker);
            this.topPanel.Controls.Add(this.browseFlightsButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(260, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(956, 141);
            this.topPanel.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(849, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 36);
            this.button1.TabIndex = 90;
            this.button1.TabStop = false;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // endLabel
            // 
            this.endLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.endLabel.AutoSize = true;
            this.endLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.endLabel.ForeColor = System.Drawing.Color.White;
            this.endLabel.Location = new System.Drawing.Point(497, 78);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(130, 29);
            this.endLabel.TabIndex = 89;
            this.endLabel.Text = "End Date:";
            this.endLabel.UseMnemonic = false;
            // 
            // startLabel
            // 
            this.startLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startLabel.AutoSize = true;
            this.startLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startLabel.ForeColor = System.Drawing.Color.White;
            this.startLabel.Location = new System.Drawing.Point(241, 78);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(144, 29);
            this.startLabel.TabIndex = 88;
            this.startLabel.Text = "Start Date:";
            this.startLabel.UseMnemonic = false;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startDateTimePicker.Location = new System.Drawing.Point(241, 110);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(219, 23);
            this.startDateTimePicker.TabIndex = 87;
            // 
            // endingDateTimePicker
            // 
            this.endingDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.endingDateTimePicker.Location = new System.Drawing.Point(497, 110);
            this.endingDateTimePicker.Name = "endingDateTimePicker";
            this.endingDateTimePicker.Size = new System.Drawing.Size(219, 23);
            this.endingDateTimePicker.TabIndex = 86;
            // 
            // browseFlightsButton
            // 
            this.browseFlightsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.browseFlightsButton.BackColor = System.Drawing.Color.Red;
            this.browseFlightsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
            this.browseFlightsButton.FlatAppearance.BorderSize = 0;
            this.browseFlightsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseFlightsButton.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.browseFlightsButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.browseFlightsButton.Location = new System.Drawing.Point(320, 26);
            this.browseFlightsButton.Name = "browseFlightsButton";
            this.browseFlightsButton.Size = new System.Drawing.Size(316, 40);
            this.browseFlightsButton.TabIndex = 14;
            this.browseFlightsButton.TabStop = false;
            this.browseFlightsButton.Text = "Browse Flights";
            this.browseFlightsButton.UseVisualStyleBackColor = false;
            this.browseFlightsButton.Click += new System.EventHandler(this.browseFlightsButton_Click);
            // 
            // flightManagerFlowLayoutPanel
            // 
            this.flightManagerFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flightManagerFlowLayoutPanel.AutoScroll = true;
            this.flightManagerFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flightManagerFlowLayoutPanel.Location = new System.Drawing.Point(266, 188);
            this.flightManagerFlowLayoutPanel.Name = "flightManagerFlowLayoutPanel";
            this.flightManagerFlowLayoutPanel.Size = new System.Drawing.Size(938, 512);
            this.flightManagerFlowLayoutPanel.TabIndex = 2;
            this.flightManagerFlowLayoutPanel.WrapContents = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(266, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 29);
            this.label1.TabIndex = 90;
            this.label1.Text = "Date of Flight";
            this.label1.UseMnemonic = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(458, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 29);
            this.label3.TabIndex = 91;
            this.label3.Text = "Origin";
            this.label3.UseMnemonic = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(560, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 29);
            this.label4.TabIndex = 92;
            this.label4.Text = "Destination";
            this.label4.UseMnemonic = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(743, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 29);
            this.label5.TabIndex = 93;
            this.label5.Text = "Seats Sold";
            this.label5.UseMnemonic = false;
            // 
            // flightManagerLogOutButton
            // 
            this.flightManagerLogOutButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flightManagerLogOutButton.BackColor = System.Drawing.Color.Red;
            this.flightManagerLogOutButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
            this.flightManagerLogOutButton.FlatAppearance.BorderSize = 0;
            this.flightManagerLogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flightManagerLogOutButton.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.flightManagerLogOutButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.flightManagerLogOutButton.Location = new System.Drawing.Point(12, 12);
            this.flightManagerLogOutButton.Name = "flightManagerLogOutButton";
            this.flightManagerLogOutButton.Size = new System.Drawing.Size(105, 40);
            this.flightManagerLogOutButton.TabIndex = 93;
            this.flightManagerLogOutButton.TabStop = false;
            this.flightManagerLogOutButton.Text = "Logout";
            this.flightManagerLogOutButton.UseVisualStyleBackColor = false;
            this.flightManagerLogOutButton.Click += new System.EventHandler(this.flightManagerLogOutButton_Click);
            // 
            // FlightManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1216, 712);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flightManagerFlowLayoutPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1232, 751);
            this.Name = "FlightManagerForm";
            this.Text = "FlightManagerForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button accountantExitButton;
        public System.Windows.Forms.Button browseFlightsButton;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DateTimePicker endingDateTimePicker;
        private System.Windows.Forms.FlowLayoutPanel flightManagerFlowLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button flightManagerLogOutButton;
    }
}