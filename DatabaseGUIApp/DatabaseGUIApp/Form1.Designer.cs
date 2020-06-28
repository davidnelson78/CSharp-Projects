namespace DatabaseGuiApp
{
    partial class Form1
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmbBxLastName = new System.Windows.Forms.ComboBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtBxAddress = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtBxCity = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.txtBxState = new System.Windows.Forms.TextBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.txtBxZip = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtBxPhone = new System.Windows.Forms.TextBox();
            this.pctrBxPhone = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtBxEmail = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBxPhone)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(189, 54);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(215, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Address Book";
            // 
            // cmbBxLastName
            // 
            this.cmbBxLastName.FormattingEnabled = true;
            this.cmbBxLastName.Location = new System.Drawing.Point(28, 217);
            this.cmbBxLastName.Name = "cmbBxLastName";
            this.cmbBxLastName.Size = new System.Drawing.Size(158, 33);
            this.cmbBxLastName.TabIndex = 1;
            this.cmbBxLastName.SelectedIndexChanged += new System.EventHandler(this.CmbBxLastName_SelectedIndexChanged);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(57, 186);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(106, 25);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(244, 101);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(70, 25);
            this.lblFullName.TabIndex = 3;
            this.lblFullName.Text = "Name:";
            this.lblFullName.Visible = false;
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(305, 101);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(202, 30);
            this.txtBxName.TabIndex = 4;
            this.txtBxName.Visible = false;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(223, 142);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(96, 25);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Address: ";
            this.lblAddress.Visible = false;
            // 
            // txtBxAddress
            // 
            this.txtBxAddress.Location = new System.Drawing.Point(305, 142);
            this.txtBxAddress.Name = "txtBxAddress";
            this.txtBxAddress.Size = new System.Drawing.Size(202, 30);
            this.txtBxAddress.TabIndex = 6;
            this.txtBxAddress.Visible = false;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(260, 180);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(52, 25);
            this.lblCity.TabIndex = 7;
            this.lblCity.Text = "City:";
            this.lblCity.Visible = false;
            // 
            // txtBxCity
            // 
            this.txtBxCity.Location = new System.Drawing.Point(305, 180);
            this.txtBxCity.Name = "txtBxCity";
            this.txtBxCity.Size = new System.Drawing.Size(202, 30);
            this.txtBxCity.TabIndex = 8;
            this.txtBxCity.Visible = false;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(247, 220);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(64, 25);
            this.lblState.TabIndex = 9;
            this.lblState.Text = "State:";
            this.lblState.Visible = false;
            // 
            // txtBxState
            // 
            this.txtBxState.Location = new System.Drawing.Point(305, 220);
            this.txtBxState.Name = "txtBxState";
            this.txtBxState.Size = new System.Drawing.Size(202, 30);
            this.txtBxState.TabIndex = 10;
            this.txtBxState.Visible = false;
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(222, 266);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(98, 25);
            this.lblZip.TabIndex = 11;
            this.lblZip.Text = "Zip Code:";
            this.lblZip.Visible = false;
            // 
            // txtBxZip
            // 
            this.txtBxZip.Location = new System.Drawing.Point(305, 265);
            this.txtBxZip.Name = "txtBxZip";
            this.txtBxZip.Size = new System.Drawing.Size(202, 30);
            this.txtBxZip.TabIndex = 12;
            this.txtBxZip.Visible = false;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(180, 308);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(149, 25);
            this.lblPhone.TabIndex = 13;
            this.lblPhone.Text = "Phone Number:";
            this.lblPhone.Visible = false;
            // 
            // txtBxPhone
            // 
            this.txtBxPhone.Location = new System.Drawing.Point(305, 307);
            this.txtBxPhone.Name = "txtBxPhone";
            this.txtBxPhone.Size = new System.Drawing.Size(202, 30);
            this.txtBxPhone.TabIndex = 14;
            this.txtBxPhone.Visible = false;
            // 
            // pctrBxPhone
            // 
            this.pctrBxPhone.Location = new System.Drawing.Point(227, 101);
            this.pctrBxPhone.Name = "pctrBxPhone";
            this.pctrBxPhone.Size = new System.Drawing.Size(304, 290);
            this.pctrBxPhone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctrBxPhone.TabIndex = 15;
            this.pctrBxPhone.TabStop = false;
            this.pctrBxPhone.Click += new System.EventHandler(this.PctrBxPhone_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(633, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.ResetToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.InfoToolStripMenuItem_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(242, 346);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(74, 25);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "E-Mail:";
            this.lblEmail.Visible = false;
            // 
            // txtBxEmail
            // 
            this.txtBxEmail.Location = new System.Drawing.Point(306, 345);
            this.txtBxEmail.Name = "txtBxEmail";
            this.txtBxEmail.Size = new System.Drawing.Size(201, 30);
            this.txtBxEmail.TabIndex = 18;
            this.txtBxEmail.Visible = false;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(12, 412);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 18);
            this.lblMessage.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(633, 447);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtBxEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.pctrBxPhone);
            this.Controls.Add(this.txtBxPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtBxZip);
            this.Controls.Add(this.lblZip);
            this.Controls.Add(this.txtBxState);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.txtBxCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtBxAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtBxName);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.cmbBxLastName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Address Book";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctrBxPhone)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbBxLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtBxAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtBxCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtBxState;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.TextBox txtBxZip;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtBxPhone;
        private System.Windows.Forms.PictureBox pctrBxPhone;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtBxEmail;
        private System.Windows.Forms.Label lblMessage;
    }
}

