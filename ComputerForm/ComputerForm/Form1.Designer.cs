namespace ComputerForm
{
    partial class ClubForm
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
            this.txtBxResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstBxEvents = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxAct = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBxResult
            // 
            this.txtBxResult.Location = new System.Drawing.Point(63, 449);
            this.txtBxResult.Name = "txtBxResult";
            this.txtBxResult.Size = new System.Drawing.Size(573, 30);
            this.txtBxResult.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Result";
            // 
            // lstBxEvents
            // 
            this.lstBxEvents.BackColor = System.Drawing.Color.Yellow;
            this.lstBxEvents.ForeColor = System.Drawing.Color.Blue;
            this.lstBxEvents.FormattingEnabled = true;
            this.lstBxEvents.ItemHeight = 25;
            this.lstBxEvents.Items.AddRange(new object[] {
            "Amusement Park",
            "Boat Tour",
            "Dance",
            "Dinner",
            "Hike",
            "Movie",
            "Sport Event"});
            this.lstBxEvents.Location = new System.Drawing.Point(70, 181);
            this.lstBxEvents.Name = "lstBxEvents";
            this.lstBxEvents.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstBxEvents.Size = new System.Drawing.Size(214, 154);
            this.lstBxEvents.Sorted = true;
            this.lstBxEvents.TabIndex = 1;
            this.lstBxEvents.SelectedIndexChanged += new System.EventHandler(this.lstBxEvents_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selected Event(s)";
            // 
            // txtBxAct
            // 
            this.txtBxAct.Location = new System.Drawing.Point(428, 223);
            this.txtBxAct.Name = "txtBxAct";
            this.txtBxAct.Size = new System.Drawing.Size(212, 30);
            this.txtBxAct.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(463, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Add an Activity";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(450, 273);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(168, 41);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "Add Activity";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // ClubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(721, 569);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBxAct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstBxEvents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxResult);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ClubForm";
            this.Text = "Computer Club Outing Signup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstBxEvents;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxAct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNew;
    }
}

