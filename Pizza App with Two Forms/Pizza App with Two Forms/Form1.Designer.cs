namespace Pizza_App_with_Two_Forms
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pctBxSlice = new System.Windows.Forms.PictureBox();
            this.pctBxSuper = new System.Windows.Forms.PictureBox();
            this.pctBxPersonal = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkLstBxToppings = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstBxCrust = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstBxSize = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lstBxBeverage = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnOrder = new System.Windows.Forms.Button();
            this.txtBxCost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.resetOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBxSlice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBxSuper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBxPersonal)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(510, 344);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Aquamarine;
            this.tabPage1.Controls.Add(this.pctBxSlice);
            this.tabPage1.Controls.Add(this.pctBxSuper);
            this.tabPage1.Controls.Add(this.pctBxPersonal);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.chkLstBxToppings);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.lstBxCrust);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lstBxSize);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(502, 318);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pizza";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // pctBxSlice
            // 
            this.pctBxSlice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctBxSlice.BackgroundImage")));
            this.pctBxSlice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctBxSlice.Location = new System.Drawing.Point(274, 203);
            this.pctBxSlice.Name = "pctBxSlice";
            this.pctBxSlice.Size = new System.Drawing.Size(152, 88);
            this.pctBxSlice.TabIndex = 9;
            this.pctBxSlice.TabStop = false;
            this.pctBxSlice.Visible = false;
            // 
            // pctBxSuper
            // 
            this.pctBxSuper.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctBxSuper.BackgroundImage")));
            this.pctBxSuper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctBxSuper.Location = new System.Drawing.Point(274, 203);
            this.pctBxSuper.Name = "pctBxSuper";
            this.pctBxSuper.Size = new System.Drawing.Size(152, 88);
            this.pctBxSuper.TabIndex = 8;
            this.pctBxSuper.TabStop = false;
            this.pctBxSuper.Visible = false;
            // 
            // pctBxPersonal
            // 
            this.pctBxPersonal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctBxPersonal.BackgroundImage")));
            this.pctBxPersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctBxPersonal.Location = new System.Drawing.Point(274, 203);
            this.pctBxPersonal.Name = "pctBxPersonal";
            this.pctBxPersonal.Size = new System.Drawing.Size(152, 88);
            this.pctBxPersonal.TabIndex = 7;
            this.pctBxPersonal.TabStop = false;
            this.pctBxPersonal.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Toppings - $1.50 Each";
            // 
            // chkLstBxToppings
            // 
            this.chkLstBxToppings.CheckOnClick = true;
            this.chkLstBxToppings.FormattingEnabled = true;
            this.chkLstBxToppings.Items.AddRange(new object[] {
            "Pepperoni",
            "Mushrooms",
            "Green Peppers",
            "Olives",
            "Sausage",
            "Chicken",
            "Bacon",
            "Ham",
            "Pineapple"});
            this.chkLstBxToppings.Location = new System.Drawing.Point(43, 203);
            this.chkLstBxToppings.Name = "chkLstBxToppings";
            this.chkLstBxToppings.Size = new System.Drawing.Size(184, 88);
            this.chkLstBxToppings.TabIndex = 5;
            this.toolTip1.SetToolTip(this.chkLstBxToppings, "Select all your topping items\r\n\r\n");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Type of Crust";
            // 
            // lstBxCrust
            // 
            this.lstBxCrust.FormattingEnabled = true;
            this.lstBxCrust.ItemHeight = 20;
            this.lstBxCrust.Items.AddRange(new object[] {
            "Thin and Crispy",
            "Whole Wheat",
            "Thick",
            "Deep Dish"});
            this.lstBxCrust.Location = new System.Drawing.Point(262, 92);
            this.lstBxCrust.Name = "lstBxCrust";
            this.lstBxCrust.Size = new System.Drawing.Size(183, 24);
            this.lstBxCrust.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pizza Size";
            // 
            // lstBxSize
            // 
            this.lstBxSize.FormattingEnabled = true;
            this.lstBxSize.ItemHeight = 20;
            this.lstBxSize.Items.AddRange(new object[] {
            "Personal (6\'\') - $6.75",
            "Medium (12\'\') - $12.95",
            "Large (14\'\') - $18.99",
            "Super (18\'\') - $22.77"});
            this.lstBxSize.Location = new System.Drawing.Point(43, 92);
            this.lstBxSize.Name = "lstBxSize";
            this.lstBxSize.Size = new System.Drawing.Size(184, 24);
            this.lstBxSize.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pizza Selections";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Aquamarine;
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.lstBxBeverage);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(502, 315);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Beverage";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(245, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 144);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(62, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Select Beverage";
            // 
            // lstBxBeverage
            // 
            this.lstBxBeverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBxBeverage.FormattingEnabled = true;
            this.lstBxBeverage.ItemHeight = 20;
            this.lstBxBeverage.Items.AddRange(new object[] {
            "Coffee - $1.50",
            "Tea - $1.50",
            "Lemonade - $2.00",
            "Soda - $2.00",
            "Milk - $1.75",
            "Juice - $1.75"});
            this.lstBxBeverage.Location = new System.Drawing.Point(50, 135);
            this.lstBxBeverage.Name = "lstBxBeverage";
            this.lstBxBeverage.Size = new System.Drawing.Size(166, 144);
            this.lstBxBeverage.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(182, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Beverages";
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.LightSalmon;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(54, 392);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(120, 51);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Text = "Place Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // txtBxCost
            // 
            this.txtBxCost.Enabled = false;
            this.txtBxCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxCost.Location = new System.Drawing.Point(328, 404);
            this.txtBxCost.Name = "txtBxCost";
            this.txtBxCost.Size = new System.Drawing.Size(120, 26);
            this.txtBxCost.TabIndex = 2;
            this.txtBxCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(226, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Total Cost:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetOrderToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(507, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // resetOrderToolStripMenuItem
            // 
            this.resetOrderToolStripMenuItem.Name = "resetOrderToolStripMenuItem";
            this.resetOrderToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.resetOrderToolStripMenuItem.Text = "&Reset ";
            this.resetOrderToolStripMenuItem.Click += new System.EventHandler(this.resetOrderToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(507, 455);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBxCost);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza Order Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBxSlice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBxSuper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBxPersonal)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstBxSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox chkLstBxToppings;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstBxCrust;
        private System.Windows.Forms.PictureBox pctBxSuper;
        private System.Windows.Forms.PictureBox pctBxPersonal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pctBxSlice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstBxBeverage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.TextBox txtBxCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem resetOrderToolStripMenuItem;
    }
}

