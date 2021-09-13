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
    partial class MarketingManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarketingManagerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.accountantExitButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.destinationComboBox = new System.Windows.Forms.ComboBox();
            this.originComboBox = new System.Windows.Forms.ComboBox();
            this.clearPanelButton = new System.Windows.Forms.Button();
            this.endMarketingLabel = new System.Windows.Forms.Label();
            this.startMarketingLabel = new System.Windows.Forms.Label();
            this.browseFlightsMarketingButton = new System.Windows.Forms.Button();
            this.marketingFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.marketingManagerLogOutButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
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
            this.accountantExitButton.TabIndex = 7;
            this.accountantExitButton.Text = "Exit";
            this.accountantExitButton.UseVisualStyleBackColor = true;
            this.accountantExitButton.Click += new System.EventHandler(this.accountantExitButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.marketingManagerLogOutButton);
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
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Air3550.Properties.Resources.Loginicon;
            this.pictureBox1.Location = new System.Drawing.Point(6, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
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
            this.label2.TabIndex = 20;
            this.label2.Text = "Marketing Manager";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
            this.panel3.Controls.Add(this.destinationComboBox);
            this.panel3.Controls.Add(this.originComboBox);
            this.panel3.Controls.Add(this.clearPanelButton);
            this.panel3.Controls.Add(this.endMarketingLabel);
            this.panel3.Controls.Add(this.startMarketingLabel);
            this.panel3.Controls.Add(this.browseFlightsMarketingButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(260, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(956, 141);
            this.panel3.TabIndex = 1;
            // 
            // destinationComboBox
            // 
            this.destinationComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.destinationComboBox.FormattingEnabled = true;
            this.destinationComboBox.Location = new System.Drawing.Point(546, 99);
            this.destinationComboBox.Name = "destinationComboBox";
            this.destinationComboBox.Size = new System.Drawing.Size(139, 23);
            this.destinationComboBox.TabIndex = 97;
            // 
            // originComboBox
            // 
            this.originComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.originComboBox.FormattingEnabled = true;
            this.originComboBox.Location = new System.Drawing.Point(260, 99);
            this.originComboBox.Name = "originComboBox";
            this.originComboBox.Size = new System.Drawing.Size(139, 23);
            this.originComboBox.TabIndex = 96;
            // 
            // clearPanelButton
            // 
            this.clearPanelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearPanelButton.BackColor = System.Drawing.Color.Red;
            this.clearPanelButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
            this.clearPanelButton.FlatAppearance.BorderSize = 0;
            this.clearPanelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearPanelButton.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearPanelButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.clearPanelButton.Location = new System.Drawing.Point(799, 93);
            this.clearPanelButton.Name = "clearPanelButton";
            this.clearPanelButton.Size = new System.Drawing.Size(95, 36);
            this.clearPanelButton.TabIndex = 95;
            this.clearPanelButton.TabStop = false;
            this.clearPanelButton.Text = "Clear";
            this.clearPanelButton.UseVisualStyleBackColor = false;
            this.clearPanelButton.Click += new System.EventHandler(this.clearPanelButton_Click);
            // 
            // endMarketingLabel
            // 
            this.endMarketingLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.endMarketingLabel.AutoSize = true;
            this.endMarketingLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.endMarketingLabel.ForeColor = System.Drawing.Color.White;
            this.endMarketingLabel.Location = new System.Drawing.Point(537, 69);
            this.endMarketingLabel.Name = "endMarketingLabel";
            this.endMarketingLabel.Size = new System.Drawing.Size(159, 29);
            this.endMarketingLabel.TabIndex = 94;
            this.endMarketingLabel.Text = "Destination:";
            this.endMarketingLabel.UseMnemonic = false;
            // 
            // startMarketingLabel
            // 
            this.startMarketingLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startMarketingLabel.AutoSize = true;
            this.startMarketingLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startMarketingLabel.ForeColor = System.Drawing.Color.White;
            this.startMarketingLabel.Location = new System.Drawing.Point(260, 69);
            this.startMarketingLabel.Name = "startMarketingLabel";
            this.startMarketingLabel.Size = new System.Drawing.Size(94, 29);
            this.startMarketingLabel.TabIndex = 93;
            this.startMarketingLabel.Text = "Origin:";
            this.startMarketingLabel.UseMnemonic = false;
            // 
            // browseFlightsMarketingButton
            // 
            this.browseFlightsMarketingButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.browseFlightsMarketingButton.BackColor = System.Drawing.Color.Red;
            this.browseFlightsMarketingButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
            this.browseFlightsMarketingButton.FlatAppearance.BorderSize = 0;
            this.browseFlightsMarketingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseFlightsMarketingButton.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.browseFlightsMarketingButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.browseFlightsMarketingButton.Location = new System.Drawing.Point(320, 17);
            this.browseFlightsMarketingButton.Name = "browseFlightsMarketingButton";
            this.browseFlightsMarketingButton.Size = new System.Drawing.Size(316, 40);
            this.browseFlightsMarketingButton.TabIndex = 90;
            this.browseFlightsMarketingButton.TabStop = false;
            this.browseFlightsMarketingButton.Text = "Browse Routes";
            this.browseFlightsMarketingButton.UseVisualStyleBackColor = false;
            this.browseFlightsMarketingButton.Click += new System.EventHandler(this.browseFlightsMarketingButton_Click);
            // 
            // marketingFlowLayoutPanel
            // 
            this.marketingFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.marketingFlowLayoutPanel.AutoScroll = true;
            this.marketingFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.marketingFlowLayoutPanel.Location = new System.Drawing.Point(266, 189);
            this.marketingFlowLayoutPanel.Name = "marketingFlowLayoutPanel";
            this.marketingFlowLayoutPanel.Size = new System.Drawing.Size(938, 511);
            this.marketingFlowLayoutPanel.TabIndex = 2;
            this.marketingFlowLayoutPanel.WrapContents = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(501, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 23);
            this.label4.TabIndex = 96;
            this.label4.Text = "Dest.";
            this.label4.UseMnemonic = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(413, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 23);
            this.label3.TabIndex = 95;
            this.label3.Text = "Origin";
            this.label3.UseMnemonic = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(282, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 94;
            this.label1.Text = "Route Time";
            this.label1.UseMnemonic = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(797, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 23);
            this.label7.TabIndex = 99;
            this.label7.Text = "Airplane";
            this.label7.UseMnemonic = false;
            // 
            // marketingManagerLogOutButton
            // 
            this.marketingManagerLogOutButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.marketingManagerLogOutButton.BackColor = System.Drawing.Color.Red;
            this.marketingManagerLogOutButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
            this.marketingManagerLogOutButton.FlatAppearance.BorderSize = 0;
            this.marketingManagerLogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.marketingManagerLogOutButton.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.marketingManagerLogOutButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.marketingManagerLogOutButton.Location = new System.Drawing.Point(12, 17);
            this.marketingManagerLogOutButton.Name = "marketingManagerLogOutButton";
            this.marketingManagerLogOutButton.Size = new System.Drawing.Size(105, 40);
            this.marketingManagerLogOutButton.TabIndex = 93;
            this.marketingManagerLogOutButton.TabStop = false;
            this.marketingManagerLogOutButton.Text = "Logout";
            this.marketingManagerLogOutButton.UseVisualStyleBackColor = false;
            this.marketingManagerLogOutButton.Click += new System.EventHandler(this.marketingManagerLogOutButton_Click);
            // 
            // MarketingManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1216, 712);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.marketingFlowLayoutPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1232, 751);
            this.Name = "MarketingManagerForm";
            this.Text = "MarketingManagerForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button accountantExitButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label endMarketingLabel;
        private System.Windows.Forms.Label startMarketingLabel;
        public System.Windows.Forms.Button browseFlightsMarketingButton;
        private System.Windows.Forms.FlowLayoutPanel marketingFlowLayoutPanel;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button clearPanelButton;
        private System.Windows.Forms.ComboBox destinationComboBox;
        private System.Windows.Forms.ComboBox originComboBox;
        public System.Windows.Forms.Button marketingManagerLogOutButton;
    }
}