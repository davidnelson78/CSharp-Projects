namespace PasswordGenerator
{
    partial class SavePassword
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
            this.grpPassword = new System.Windows.Forms.GroupBox();
            this.txtCustom = new System.Windows.Forms.TextBox();
            this.lblCustom = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSavePassword = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPassword
            // 
            this.grpPassword.AutoSize = true;
            this.grpPassword.Controls.Add(this.txtCustom);
            this.grpPassword.Controls.Add(this.lblCustom);
            this.grpPassword.Controls.Add(this.lblStatus);
            this.grpPassword.Controls.Add(this.txtPassword);
            this.grpPassword.Controls.Add(this.btnSavePassword);
            this.grpPassword.Controls.Add(this.txtTitle);
            this.grpPassword.Controls.Add(this.lblPassword);
            this.grpPassword.Controls.Add(this.lblTitle);
            this.grpPassword.Location = new System.Drawing.Point(17, 16);
            this.grpPassword.Margin = new System.Windows.Forms.Padding(4);
            this.grpPassword.Name = "grpPassword";
            this.grpPassword.Padding = new System.Windows.Forms.Padding(4);
            this.grpPassword.Size = new System.Drawing.Size(397, 421);
            this.grpPassword.TabIndex = 0;
            this.grpPassword.TabStop = false;
            this.grpPassword.Text = "Custom Password";
            // 
            // txtCustom
            // 
            this.txtCustom.Location = new System.Drawing.Point(28, 284);
            this.txtCustom.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustom.Name = "txtCustom";
            this.txtCustom.Size = new System.Drawing.Size(341, 22);
            this.txtCustom.TabIndex = 6;
            // 
            // lblCustom
            // 
            this.lblCustom.AutoSize = true;
            this.lblCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustom.Location = new System.Drawing.Point(24, 244);
            this.lblCustom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustom.Name = "lblCustom";
            this.lblCustom.Size = new System.Drawing.Size(134, 24);
            this.lblCustom.TabIndex = 5;
            this.lblCustom.Text = "Access Code";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStatus.Location = new System.Drawing.Point(24, 374);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 24);
            this.lblStatus.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.Location = new System.Drawing.Point(28, 159);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPassword.Size = new System.Drawing.Size(341, 66);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            // 
            // btnSavePassword
            // 
            this.btnSavePassword.Location = new System.Drawing.Point(92, 328);
            this.btnSavePassword.Margin = new System.Windows.Forms.Padding(4);
            this.btnSavePassword.Name = "btnSavePassword";
            this.btnSavePassword.Size = new System.Drawing.Size(197, 28);
            this.btnSavePassword.TabIndex = 1;
            this.btnSavePassword.Text = "Save custom password";
            this.btnSavePassword.UseVisualStyleBackColor = true;
            this.btnSavePassword.Click += new System.EventHandler(this.btnSavePassword_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(28, 76);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(341, 22);
            this.txtTitle.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.Location = new System.Drawing.Point(24, 121);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(100, 24);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.Location = new System.Drawing.Point(24, 33);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(146, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Password Title";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // SavePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 458);
            this.Controls.Add(this.grpPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "SavePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Custom Password";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SavePassword_FormClosing);
            this.grpPassword.ResumeLayout(false);
            this.grpPassword.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPassword;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSavePassword;
        public System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtCustom;
        private System.Windows.Forms.Label lblCustom;
    }
}