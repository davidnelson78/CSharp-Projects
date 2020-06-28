using System;

namespace FarmerGUIClass
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
            this.label1 = new System.Windows.Forms.Label();
            this.radFarmerNS = new System.Windows.Forms.RadioButton();
            this.radFoxNS = new System.Windows.Forms.RadioButton();
            this.radChickenNS = new System.Windows.Forms.RadioButton();
            this.radGrainNS = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radChickenSS = new System.Windows.Forms.RadioButton();
            this.radGrainSS = new System.Windows.Forms.RadioButton();
            this.radFarmerSS = new System.Windows.Forms.RadioButton();
            this.radFoxSS = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMove = new System.Windows.Forms.Button();
            this.txtBxNS = new System.Windows.Forms.TextBox();
            this.txtBxSS = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "North Shore";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // radFarmerNS
            // 
            this.radFarmerNS.AutoSize = true;
            this.radFarmerNS.Location = new System.Drawing.Point(74, 25);
            this.radFarmerNS.Name = "radFarmerNS";
            this.radFarmerNS.Size = new System.Drawing.Size(74, 21);
            this.radFarmerNS.TabIndex = 1;
            this.radFarmerNS.TabStop = true;
            this.radFarmerNS.Text = "Farmer";
            this.radFarmerNS.UseVisualStyleBackColor = true;
            this.radFarmerNS.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radFoxNS
            // 
            this.radFoxNS.AutoSize = true;
            this.radFoxNS.Location = new System.Drawing.Point(171, 25);
            this.radFoxNS.Name = "radFoxNS";
            this.radFoxNS.Size = new System.Drawing.Size(51, 21);
            this.radFoxNS.TabIndex = 2;
            this.radFoxNS.TabStop = true;
            this.radFoxNS.Text = "Fox";
            this.radFoxNS.UseVisualStyleBackColor = true;
            // 
            // radChickenNS
            // 
            this.radChickenNS.AutoSize = true;
            this.radChickenNS.Location = new System.Drawing.Point(254, 25);
            this.radChickenNS.Name = "radChickenNS";
            this.radChickenNS.Size = new System.Drawing.Size(79, 21);
            this.radChickenNS.TabIndex = 3;
            this.radChickenNS.TabStop = true;
            this.radChickenNS.Text = "Chicken";
            this.radChickenNS.UseVisualStyleBackColor = true;
            this.radChickenNS.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radGrainNS
            // 
            this.radGrainNS.AutoSize = true;
            this.radGrainNS.Location = new System.Drawing.Point(356, 25);
            this.radGrainNS.Name = "radGrainNS";
            this.radGrainNS.Size = new System.Drawing.Size(64, 21);
            this.radGrainNS.TabIndex = 4;
            this.radGrainNS.TabStop = true;
            this.radGrainNS.Text = "Grain";
            this.radGrainNS.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radChickenNS);
            this.groupBox1.Controls.Add(this.txtBxNS);
            this.groupBox1.Controls.Add(this.radGrainNS);
            this.groupBox1.Controls.Add(this.radFarmerNS);
            this.groupBox1.Controls.Add(this.radFoxNS);
            this.groupBox1.Location = new System.Drawing.Point(34, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 82);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBxSS);
            this.groupBox2.Controls.Add(this.radChickenSS);
            this.groupBox2.Controls.Add(this.radGrainSS);
            this.groupBox2.Controls.Add(this.radFarmerSS);
            this.groupBox2.Controls.Add(this.radFoxSS);
            this.groupBox2.Location = new System.Drawing.Point(34, 353);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 78);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // radChickenSS
            // 
            this.radChickenSS.AutoSize = true;
            this.radChickenSS.Enabled = false;
            this.radChickenSS.Location = new System.Drawing.Point(254, 47);
            this.radChickenSS.Name = "radChickenSS";
            this.radChickenSS.Size = new System.Drawing.Size(79, 21);
            this.radChickenSS.TabIndex = 3;
            this.radChickenSS.TabStop = true;
            this.radChickenSS.Text = "Chicken";
            this.radChickenSS.UseVisualStyleBackColor = true;
            // 
            // radGrainSS
            // 
            this.radGrainSS.AutoSize = true;
            this.radGrainSS.Enabled = false;
            this.radGrainSS.Location = new System.Drawing.Point(356, 47);
            this.radGrainSS.Name = "radGrainSS";
            this.radGrainSS.Size = new System.Drawing.Size(64, 21);
            this.radGrainSS.TabIndex = 4;
            this.radGrainSS.TabStop = true;
            this.radGrainSS.Text = "Grain";
            this.radGrainSS.UseVisualStyleBackColor = true;
            // 
            // radFarmerSS
            // 
            this.radFarmerSS.AutoSize = true;
            this.radFarmerSS.Enabled = false;
            this.radFarmerSS.Location = new System.Drawing.Point(74, 47);
            this.radFarmerSS.Name = "radFarmerSS";
            this.radFarmerSS.Size = new System.Drawing.Size(74, 21);
            this.radFarmerSS.TabIndex = 1;
            this.radFarmerSS.TabStop = true;
            this.radFarmerSS.Text = "Farmer";
            this.radFarmerSS.UseVisualStyleBackColor = true;
            // 
            // radFoxSS
            // 
            this.radFoxSS.AutoSize = true;
            this.radFoxSS.Enabled = false;
            this.radFoxSS.Location = new System.Drawing.Point(171, 47);
            this.radFoxSS.Name = "radFoxSS";
            this.radFoxSS.Size = new System.Drawing.Size(51, 21);
            this.radFoxSS.TabIndex = 2;
            this.radFoxSS.TabStop = true;
            this.radFoxSS.Text = "Fox";
            this.radFoxSS.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(247, 447);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "South Shore";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(252, 233);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(103, 60);
            this.btnMove.TabIndex = 8;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // txtBxNS
            // 
            this.txtBxNS.Enabled = false;
            this.txtBxNS.Location = new System.Drawing.Point(38, 52);
            this.txtBxNS.Name = "txtBxNS";
            this.txtBxNS.Size = new System.Drawing.Size(453, 22);
            this.txtBxNS.TabIndex = 9;
            // 
            // txtBxSS
            // 
            this.txtBxSS.Enabled = false;
            this.txtBxSS.Location = new System.Drawing.Point(38, 19);
            this.txtBxSS.Name = "txtBxSS";
            this.txtBxSS.Size = new System.Drawing.Size(453, 22);
            this.txtBxSS.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(639, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(639, 484);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Farmer Logic Game";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radFarmerNS;
        private System.Windows.Forms.RadioButton radFoxNS;
        private System.Windows.Forms.RadioButton radChickenNS;
        private System.Windows.Forms.RadioButton radGrainNS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radChickenSS;
        private System.Windows.Forms.RadioButton radGrainSS;
        private System.Windows.Forms.RadioButton radFarmerSS;
        private System.Windows.Forms.RadioButton radFoxSS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxNS;
        private System.Windows.Forms.TextBox txtBxSS;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}

