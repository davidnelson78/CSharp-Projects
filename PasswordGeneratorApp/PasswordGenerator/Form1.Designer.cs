namespace PasswordGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstGenerated = new System.Windows.Forms.ListBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.chkLower = new System.Windows.Forms.CheckBox();
            this.chkUpper = new System.Windows.Forms.CheckBox();
            this.chkNumeric = new System.Windows.Forms.CheckBox();
            this.chkSpecial = new System.Windows.Forms.CheckBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblCharacter = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.grpCharacter = new System.Windows.Forms.GroupBox();
            this.lblMaxLength = new System.Windows.Forms.Label();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.lnkLblCustom = new System.Windows.Forms.LinkLabel();
            this.lnkLblShowPassword = new System.Windows.Forms.LinkLabel();
            this.grpOptions.SuspendLayout();
            this.grpCharacter.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstGenerated
            // 
            this.lstGenerated.FormattingEnabled = true;
            this.lstGenerated.ItemHeight = 16;
            this.lstGenerated.Location = new System.Drawing.Point(20, 23);
            this.lstGenerated.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstGenerated.Name = "lstGenerated";
            this.lstGenerated.Size = new System.Drawing.Size(688, 100);
            this.lstGenerated.TabIndex = 0;
            this.lstGenerated.Click += new System.EventHandler(this.lstGenerated_Click);
            this.lstGenerated.DoubleClick += new System.EventHandler(this.lstGenerated_DoubleClick);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(20, 138);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(199, 28);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate Password";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // chkLower
            // 
            this.chkLower.AutoSize = true;
            this.chkLower.Location = new System.Drawing.Point(21, 34);
            this.chkLower.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkLower.Name = "chkLower";
            this.chkLower.Size = new System.Drawing.Size(170, 21);
            this.chkLower.TabIndex = 2;
            this.chkLower.Text = "Use Lower Characters";
            this.chkLower.UseVisualStyleBackColor = true;
            this.chkLower.CheckedChanged += new System.EventHandler(this.chkLower_CheckedChanged);
            // 
            // chkUpper
            // 
            this.chkUpper.AutoSize = true;
            this.chkUpper.Location = new System.Drawing.Point(227, 34);
            this.chkUpper.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkUpper.Name = "chkUpper";
            this.chkUpper.Size = new System.Drawing.Size(171, 21);
            this.chkUpper.TabIndex = 3;
            this.chkUpper.Text = "Use Upper Characters";
            this.chkUpper.UseVisualStyleBackColor = true;
            this.chkUpper.CheckedChanged += new System.EventHandler(this.chkUpper_CheckedChanged);
            // 
            // chkNumeric
            // 
            this.chkNumeric.AutoSize = true;
            this.chkNumeric.Location = new System.Drawing.Point(21, 76);
            this.chkNumeric.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkNumeric.Name = "chkNumeric";
            this.chkNumeric.Size = new System.Drawing.Size(184, 21);
            this.chkNumeric.TabIndex = 4;
            this.chkNumeric.Text = "Use Numeric Characters";
            this.chkNumeric.UseVisualStyleBackColor = true;
            this.chkNumeric.CheckedChanged += new System.EventHandler(this.chkNumeric_CheckedChanged);
            // 
            // chkSpecial
            // 
            this.chkSpecial.AutoSize = true;
            this.chkSpecial.Location = new System.Drawing.Point(227, 76);
            this.chkSpecial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkSpecial.Name = "chkSpecial";
            this.chkSpecial.Size = new System.Drawing.Size(178, 21);
            this.chkSpecial.TabIndex = 5;
            this.chkSpecial.Text = "Use Special Characters";
            this.chkSpecial.UseVisualStyleBackColor = true;
            this.chkSpecial.CheckedChanged += new System.EventHandler(this.chkSpecial_CheckedChanged);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(23, 80);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(245, 22);
            this.txtNumber.TabIndex = 6;
            // 
            // lblCharacter
            // 
            this.lblCharacter.AutoSize = true;
            this.lblCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCharacter.Location = new System.Drawing.Point(19, 26);
            this.lblCharacter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCharacter.Name = "lblCharacter";
            this.lblCharacter.Size = new System.Drawing.Size(78, 18);
            this.lblCharacter.TabIndex = 7;
            this.lblCharacter.Text = "Default: 16";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOutput.ForeColor = System.Drawing.Color.Red;
            this.lblOutput.Location = new System.Drawing.Point(281, 142);
            this.lblOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(260, 20);
            this.lblOutput.TabIndex = 8;
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.chkNumeric);
            this.grpOptions.Controls.Add(this.chkLower);
            this.grpOptions.Controls.Add(this.chkUpper);
            this.grpOptions.Controls.Add(this.chkSpecial);
            this.grpOptions.Location = new System.Drawing.Point(16, 15);
            this.grpOptions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpOptions.Size = new System.Drawing.Size(433, 121);
            this.grpOptions.TabIndex = 9;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Options";
            // 
            // grpCharacter
            // 
            this.grpCharacter.Controls.Add(this.lblMaxLength);
            this.grpCharacter.Controls.Add(this.txtNumber);
            this.grpCharacter.Controls.Add(this.lblCharacter);
            this.grpCharacter.Location = new System.Drawing.Point(457, 15);
            this.grpCharacter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpCharacter.Name = "grpCharacter";
            this.grpCharacter.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpCharacter.Size = new System.Drawing.Size(292, 123);
            this.grpCharacter.TabIndex = 10;
            this.grpCharacter.TabStop = false;
            this.grpCharacter.Text = "Password Length";
            // 
            // lblMaxLength
            // 
            this.lblMaxLength.AutoSize = true;
            this.lblMaxLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMaxLength.Location = new System.Drawing.Point(20, 53);
            this.lblMaxLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaxLength.Name = "lblMaxLength";
            this.lblMaxLength.Size = new System.Drawing.Size(68, 18);
            this.lblMaxLength.TabIndex = 8;
            this.lblMaxLength.Text = "Max: 255";
            // 
            // grpOutput
            // 
            this.grpOutput.AutoSize = true;
            this.grpOutput.Controls.Add(this.lstGenerated);
            this.grpOutput.Controls.Add(this.btnGenerate);
            this.grpOutput.Controls.Add(this.lblOutput);
            this.grpOutput.Location = new System.Drawing.Point(17, 156);
            this.grpOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpOutput.Size = new System.Drawing.Size(733, 190);
            this.grpOutput.TabIndex = 11;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "Output";
            // 
            // lnkLblCustom
            // 
            this.lnkLblCustom.AutoSize = true;
            this.lnkLblCustom.Location = new System.Drawing.Point(599, 362);
            this.lnkLblCustom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkLblCustom.Name = "lnkLblCustom";
            this.lnkLblCustom.Size = new System.Drawing.Size(149, 17);
            this.lnkLblCustom.TabIndex = 9;
            this.lnkLblCustom.TabStop = true;
            this.lnkLblCustom.Text = "Add Custom Password";
            this.lnkLblCustom.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblCustom_LinkClicked);
            // 
            // lnkLblShowPassword
            // 
            this.lnkLblShowPassword.AutoSize = true;
            this.lnkLblShowPassword.Location = new System.Drawing.Point(13, 362);
            this.lnkLblShowPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkLblShowPassword.Name = "lnkLblShowPassword";
            this.lnkLblShowPassword.Size = new System.Drawing.Size(133, 17);
            this.lnkLblShowPassword.TabIndex = 12;
            this.lnkLblShowPassword.TabStop = true;
            this.lnkLblShowPassword.Text = "Show Password List";
            this.lnkLblShowPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblShowPassword_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 393);
            this.Controls.Add(this.lnkLblShowPassword);
            this.Controls.Add(this.lnkLblCustom);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grpCharacter);
            this.Controls.Add(this.grpOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.grpCharacter.ResumeLayout(false);
            this.grpCharacter.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstGenerated;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.CheckBox chkLower;
        private System.Windows.Forms.CheckBox chkUpper;
        private System.Windows.Forms.CheckBox chkNumeric;
        private System.Windows.Forms.CheckBox chkSpecial;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblCharacter;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.GroupBox grpCharacter;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.Label lblMaxLength;
        private System.Windows.Forms.LinkLabel lnkLblCustom;
        private System.Windows.Forms.LinkLabel lnkLblShowPassword;
    }
}

