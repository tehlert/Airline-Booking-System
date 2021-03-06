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
    //This is all autogenerated by winforms visual editor
    partial class AccountantForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountantForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.accountantExitButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.endLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.generateReportButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.accountantReportFlowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.companyNumberIncomeLabel = new System.Windows.Forms.Label();
            this.companyIncomeLabel = new System.Windows.Forms.Label();
            this.flightCountNumberLabel = new System.Windows.Forms.Label();
            this.flightCountLabel = new System.Windows.Forms.Label();
            this.accountantLogOutButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.topPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
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
            this.accountantExitButton.TabIndex = 5;
            this.accountantExitButton.Text = "Exit";
            this.accountantExitButton.UseVisualStyleBackColor = true;
            this.accountantExitButton.Click += new System.EventHandler(this.accountantExitButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.accountantLogOutButton);
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
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Air3550.Properties.Resources.Loginicon;
            this.pictureBox1.Location = new System.Drawing.Point(6, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
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
            this.label2.TabIndex = 14;
            this.label2.Text = "Accountant";
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
            this.topPanel.Controls.Add(this.endLabel);
            this.topPanel.Controls.Add(this.startLabel);
            this.topPanel.Controls.Add(this.startDateTimePicker);
            this.topPanel.Controls.Add(this.endingDateTimePicker);
            this.topPanel.Controls.Add(this.generateReportButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(260, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(956, 141);
            this.topPanel.TabIndex = 1;
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.endLabel.ForeColor = System.Drawing.Color.White;
            this.endLabel.Location = new System.Drawing.Point(506, 73);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(130, 29);
            this.endLabel.TabIndex = 85;
            this.endLabel.Text = "End Date:";
            this.endLabel.UseMnemonic = false;
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startLabel.ForeColor = System.Drawing.Color.White;
            this.startLabel.Location = new System.Drawing.Point(269, 73);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(144, 29);
            this.startLabel.TabIndex = 84;
            this.startLabel.Text = "Start Date:";
            this.startLabel.UseMnemonic = false;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startDateTimePicker.Location = new System.Drawing.Point(269, 105);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(219, 23);
            this.startDateTimePicker.TabIndex = 69;
            // 
            // endingDateTimePicker
            // 
            this.endingDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.endingDateTimePicker.Location = new System.Drawing.Point(506, 105);
            this.endingDateTimePicker.Name = "endingDateTimePicker";
            this.endingDateTimePicker.Size = new System.Drawing.Size(219, 23);
            this.endingDateTimePicker.TabIndex = 68;
            // 
            // generateReportButton
            // 
            this.generateReportButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.generateReportButton.BackColor = System.Drawing.Color.Red;
            this.generateReportButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
            this.generateReportButton.FlatAppearance.BorderSize = 0;
            this.generateReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateReportButton.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.generateReportButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.generateReportButton.Location = new System.Drawing.Point(320, 30);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(316, 40);
            this.generateReportButton.TabIndex = 13;
            this.generateReportButton.TabStop = false;
            this.generateReportButton.Text = "Generate Report";
            this.generateReportButton.UseVisualStyleBackColor = false;
            this.generateReportButton.Click += new System.EventHandler(this.generateReportButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.mainPanel.Controls.Add(this.accountantReportFlowLayoutPanel1);
            this.mainPanel.Controls.Add(this.companyNumberIncomeLabel);
            this.mainPanel.Controls.Add(this.companyIncomeLabel);
            this.mainPanel.Controls.Add(this.flightCountNumberLabel);
            this.mainPanel.Controls.Add(this.flightCountLabel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(260, 141);
            this.mainPanel.MinimumSize = new System.Drawing.Size(956, 571);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(956, 571);
            this.mainPanel.TabIndex = 15;
            // 
            // accountantReportFlowLayoutPanel1
            // 
            this.accountantReportFlowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.accountantReportFlowLayoutPanel1.AutoScroll = true;
            this.accountantReportFlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.accountantReportFlowLayoutPanel1.Location = new System.Drawing.Point(12, 19);
            this.accountantReportFlowLayoutPanel1.Name = "accountantReportFlowLayoutPanel1";
            this.accountantReportFlowLayoutPanel1.Size = new System.Drawing.Size(624, 527);
            this.accountantReportFlowLayoutPanel1.TabIndex = 84;
            this.accountantReportFlowLayoutPanel1.WrapContents = false;
            // 
            // companyNumberIncomeLabel
            // 
            this.companyNumberIncomeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.companyNumberIncomeLabel.AutoSize = true;
            this.companyNumberIncomeLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.companyNumberIncomeLabel.ForeColor = System.Drawing.Color.White;
            this.companyNumberIncomeLabel.Location = new System.Drawing.Point(642, 163);
            this.companyNumberIncomeLabel.Name = "companyNumberIncomeLabel";
            this.companyNumberIncomeLabel.Size = new System.Drawing.Size(43, 29);
            this.companyNumberIncomeLabel.TabIndex = 81;
            this.companyNumberIncomeLabel.Text = "00";
            // 
            // companyIncomeLabel
            // 
            this.companyIncomeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.companyIncomeLabel.AutoSize = true;
            this.companyIncomeLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.companyIncomeLabel.ForeColor = System.Drawing.Color.White;
            this.companyIncomeLabel.Location = new System.Drawing.Point(642, 119);
            this.companyIncomeLabel.Name = "companyIncomeLabel";
            this.companyIncomeLabel.Size = new System.Drawing.Size(233, 29);
            this.companyIncomeLabel.TabIndex = 80;
            this.companyIncomeLabel.Text = "Company Income:";
            // 
            // flightCountNumberLabel
            // 
            this.flightCountNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flightCountNumberLabel.AutoSize = true;
            this.flightCountNumberLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.flightCountNumberLabel.ForeColor = System.Drawing.Color.White;
            this.flightCountNumberLabel.Location = new System.Drawing.Point(816, 32);
            this.flightCountNumberLabel.Name = "flightCountNumberLabel";
            this.flightCountNumberLabel.Size = new System.Drawing.Size(43, 29);
            this.flightCountNumberLabel.TabIndex = 77;
            this.flightCountNumberLabel.Text = "00";
            this.flightCountNumberLabel.Click += new System.EventHandler(this.fightCountNumberLabel_Click);
            // 
            // flightCountLabel
            // 
            this.flightCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flightCountLabel.AutoSize = true;
            this.flightCountLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.flightCountLabel.ForeColor = System.Drawing.Color.White;
            this.flightCountLabel.Location = new System.Drawing.Point(642, 32);
            this.flightCountLabel.Name = "flightCountLabel";
            this.flightCountLabel.Size = new System.Drawing.Size(168, 29);
            this.flightCountLabel.TabIndex = 76;
            this.flightCountLabel.Text = "Flight Count:";
            // 
            // accountantLogOutButton
            // 
            this.accountantLogOutButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.accountantLogOutButton.BackColor = System.Drawing.Color.Red;
            this.accountantLogOutButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
            this.accountantLogOutButton.FlatAppearance.BorderSize = 0;
            this.accountantLogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountantLogOutButton.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.accountantLogOutButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.accountantLogOutButton.Location = new System.Drawing.Point(12, 12);
            this.accountantLogOutButton.Name = "accountantLogOutButton";
            this.accountantLogOutButton.Size = new System.Drawing.Size(105, 40);
            this.accountantLogOutButton.TabIndex = 93;
            this.accountantLogOutButton.TabStop = false;
            this.accountantLogOutButton.Text = "Logout";
            this.accountantLogOutButton.UseVisualStyleBackColor = false;
            this.accountantLogOutButton.Click += new System.EventHandler(this.accountantLogOutButton_Click);
            // 
            // AccountantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1216, 712);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1232, 751);
            this.Name = "AccountantForm";
            this.Text = "AccountantForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button accountantExitButton;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel mainPanel;
        public System.Windows.Forms.Button generateReportButton;
        private System.Windows.Forms.Label fightCountNumberLabel;
        private System.Windows.Forms.Label flightCountLabel;
        private System.Windows.Forms.Label companyNumberIncomeLabel;
        private System.Windows.Forms.Label companyIncomeLabel;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.DateTimePicker endingDateTimePicker;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.FlowLayoutPanel accountantReportFlowLayoutPanel1;
        private System.Windows.Forms.Label flightCountNumberLabel;
        public System.Windows.Forms.Button accountantLogOutButton;
    }
}