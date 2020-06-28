namespace PasswordGenerator
{
    partial class PasswordDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordDetail));
            this.grpPasswordDetail = new System.Windows.Forms.GroupBox();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtCustomPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblCustomPassword = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpPasswordDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPasswordDetail
            // 
            this.grpPasswordDetail.AutoSize = true;
            this.grpPasswordDetail.Controls.Add(this.lblUpdate);
            this.grpPasswordDetail.Controls.Add(this.btnUpdate);
            this.grpPasswordDetail.Controls.Add(this.txtCustomPassword);
            this.grpPasswordDetail.Controls.Add(this.txtPassword);
            this.grpPasswordDetail.Controls.Add(this.txtTitle);
            this.grpPasswordDetail.Controls.Add(this.lblCustomPassword);
            this.grpPasswordDetail.Controls.Add(this.lblPassword);
            this.grpPasswordDetail.Controls.Add(this.lblTitle);
            this.grpPasswordDetail.Location = new System.Drawing.Point(17, 16);
            this.grpPasswordDetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPasswordDetail.Name = "grpPasswordDetail";
            this.grpPasswordDetail.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPasswordDetail.Size = new System.Drawing.Size(564, 351);
            this.grpPasswordDetail.TabIndex = 0;
            this.grpPasswordDetail.TabStop = false;
            this.grpPasswordDetail.Text = "Password Detail";
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdate.Location = new System.Drawing.Point(23, 295);
            this.lblUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(0, 20);
            this.lblUpdate.TabIndex = 7;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(385, 284);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(152, 42);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update Password";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtCustomPassword
            // 
            this.txtCustomPassword.Location = new System.Drawing.Point(27, 235);
            this.txtCustomPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCustomPassword.Name = "txtCustomPassword";
            this.txtCustomPassword.Size = new System.Drawing.Size(509, 22);
            this.txtCustomPassword.TabIndex = 5;
            this.txtCustomPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustomPassword_KeyDown);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(27, 118);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPassword.Size = new System.Drawing.Size(509, 64);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPassword_MouseClick);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(27, 43);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(509, 22);
            this.txtTitle.TabIndex = 3;
            this.txtTitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTitle_KeyDown);
            // 
            // lblCustomPassword
            // 
            this.lblCustomPassword.AutoSize = true;
            this.lblCustomPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomPassword.Location = new System.Drawing.Point(227, 211);
            this.lblCustomPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomPassword.Name = "lblCustomPassword";
            this.lblCustomPassword.Size = new System.Drawing.Size(120, 20);
            this.lblCustomPassword.TabIndex = 2;
            this.lblCustomPassword.Text = "Access Code";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(235, 95);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(91, 20);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(213, 19);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(134, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Password Title";
            // 
            // PasswordDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 386);
            this.Controls.Add(this.grpPasswordDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "PasswordDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Password Detail";
            this.Load += new System.EventHandler(this.PasswordDetail_Load);
            this.grpPasswordDetail.ResumeLayout(false);
            this.grpPasswordDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPasswordDetail;
        private System.Windows.Forms.Label lblCustomPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblUpdate;
        public System.Windows.Forms.TextBox txtCustomPassword;
        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.TextBox txtTitle;
    }
}