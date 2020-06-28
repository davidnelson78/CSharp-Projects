namespace GUISayingsForm
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
            this.txtBxSaying = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnStoreSaying = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.ForeColor = System.Drawing.Color.Yellow;
            this.lblTitle.Location = new System.Drawing.Point(164, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(169, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Enter Favorite Sayings";
            // 
            // txtBxSaying
            // 
            this.txtBxSaying.Location = new System.Drawing.Point(127, 68);
            this.txtBxSaying.Multiline = true;
            this.txtBxSaying.Name = "txtBxSaying";
            this.txtBxSaying.Size = new System.Drawing.Size(261, 91);
            this.txtBxSaying.TabIndex = 1;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Enabled = false;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Yellow;
            this.lblMessage.Location = new System.Drawing.Point(12, 258);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 20);
            this.lblMessage.TabIndex = 2;
            // 
            // btnStoreSaying
            // 
            this.btnStoreSaying.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnStoreSaying.Location = new System.Drawing.Point(217, 176);
            this.btnStoreSaying.Name = "btnStoreSaying";
            this.btnStoreSaying.Size = new System.Drawing.Size(75, 51);
            this.btnStoreSaying.TabIndex = 3;
            this.btnStoreSaying.Text = "Store Saying";
            this.btnStoreSaying.UseVisualStyleBackColor = false;
            this.btnStoreSaying.Click += new System.EventHandler(this.btnStoreSaying_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(491, 400);
            this.Controls.Add(this.btnStoreSaying);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtBxSaying);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Favorite Sayings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtBxSaying;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnStoreSaying;
    }
}

