namespace PizzaOrderApp
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPizza = new System.Windows.Forms.TabPage();
            this.pctBxPizza = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ckBxToppings = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstBxCrust = new System.Windows.Forms.ListBox();
            this.lstBxSize = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBeverages = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lstBxBeverages = new System.Windows.Forms.ListBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.placeOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.selectColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pctBxPersonal = new System.Windows.Forms.PictureBox();
            this.pctBxSuper = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPizza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBxPizza)).BeginInit();
            this.tbBeverages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBxPersonal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBxSuper)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPizza);
            this.tabControl1.Controls.Add(this.tbBeverages);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(589, 324);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPizza
            // 
            this.tabPizza.BackColor = System.Drawing.Color.SandyBrown;
            this.tabPizza.Controls.Add(this.pctBxSuper);
            this.tabPizza.Controls.Add(this.pctBxPersonal);
            this.tabPizza.Controls.Add(this.pctBxPizza);
            this.tabPizza.Controls.Add(this.label4);
            this.tabPizza.Controls.Add(this.ckBxToppings);
            this.tabPizza.Controls.Add(this.label3);
            this.tabPizza.Controls.Add(this.label2);
            this.tabPizza.Controls.Add(this.lstBxCrust);
            this.tabPizza.Controls.Add(this.lstBxSize);
            this.tabPizza.Controls.Add(this.label1);
            this.tabPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPizza.Location = new System.Drawing.Point(4, 22);
            this.tabPizza.Name = "tabPizza";
            this.tabPizza.Padding = new System.Windows.Forms.Padding(3);
            this.tabPizza.Size = new System.Drawing.Size(581, 298);
            this.tabPizza.TabIndex = 0;
            this.tabPizza.Text = "Pizza";
            // 
            // pctBxPizza
            // 
            this.pctBxPizza.BackColor = System.Drawing.Color.Transparent;
            this.pctBxPizza.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctBxPizza.BackgroundImage")));
            this.pctBxPizza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctBxPizza.Location = new System.Drawing.Point(351, 183);
            this.pctBxPizza.Name = "pctBxPizza";
            this.pctBxPizza.Size = new System.Drawing.Size(155, 109);
            this.pctBxPizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctBxPizza.TabIndex = 7;
            this.pctBxPizza.TabStop = false;
            this.pctBxPizza.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Toppings - $1.50 Each";
            // 
            // ckBxToppings
            // 
            this.ckBxToppings.CheckOnClick = true;
            this.ckBxToppings.FormattingEnabled = true;
            this.ckBxToppings.Items.AddRange(new object[] {
            "Pepperoni",
            "Mushrooms",
            "Green Peppers",
            "Olives",
            "Sausage",
            "Onions",
            "Chicken",
            "Bacon",
            "Ham",
            "Pineapple"});
            this.ckBxToppings.Location = new System.Drawing.Point(74, 185);
            this.ckBxToppings.Name = "ckBxToppings";
            this.ckBxToppings.Size = new System.Drawing.Size(189, 109);
            this.ckBxToppings.TabIndex = 5;
            this.toolTip1.SetToolTip(this.ckBxToppings, "double click on item to select it\r\n");
            this.ckBxToppings.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Type of Crust";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Size";
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
            this.lstBxCrust.Location = new System.Drawing.Point(351, 106);
            this.lstBxCrust.Name = "lstBxCrust";
            this.lstBxCrust.Size = new System.Drawing.Size(155, 24);
            this.lstBxCrust.TabIndex = 2;
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
            this.lstBxSize.Location = new System.Drawing.Point(74, 106);
            this.lstBxSize.Name = "lstBxSize";
            this.lstBxSize.Size = new System.Drawing.Size(189, 24);
            this.lstBxSize.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pizza Selections";
            // 
            // tbBeverages
            // 
            this.tbBeverages.BackColor = System.Drawing.Color.SandyBrown;
            this.tbBeverages.Controls.Add(this.pictureBox2);
            this.tbBeverages.Controls.Add(this.label7);
            this.tbBeverages.Controls.Add(this.label6);
            this.tbBeverages.Controls.Add(this.lstBxBeverages);
            this.tbBeverages.Location = new System.Drawing.Point(4, 22);
            this.tbBeverages.Name = "tbBeverages";
            this.tbBeverages.Padding = new System.Windows.Forms.Padding(3);
            this.tbBeverages.Size = new System.Drawing.Size(581, 298);
            this.tbBeverages.TabIndex = 1;
            this.tbBeverages.Text = "Beverages";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(279, 120);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(245, 139);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(221, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 29);
            this.label7.TabIndex = 2;
            this.label7.Text = "Beverages";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(93, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Select Beverage";
            // 
            // lstBxBeverages
            // 
            this.lstBxBeverages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBxBeverages.FormattingEnabled = true;
            this.lstBxBeverages.ItemHeight = 20;
            this.lstBxBeverages.Items.AddRange(new object[] {
            "Coffee - $1.50",
            "Tea - $1.50",
            "Lemonade - $2.00",
            "Soda - $2.00",
            "Milk - $1.75",
            "Juice - $1.75"});
            this.lstBxBeverages.Location = new System.Drawing.Point(74, 120);
            this.lstBxBeverages.Name = "lstBxBeverages";
            this.lstBxBeverages.Size = new System.Drawing.Size(160, 144);
            this.lstBxBeverages.TabIndex = 0;
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Aqua;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(78, 383);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(131, 55);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Text = "Place Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(279, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total Cost:";
            // 
            // txtCost
            // 
            this.txtCost.Enabled = false;
            this.txtCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(381, 395);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(129, 26);
            this.txtCost.TabIndex = 3;
            this.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(583, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(583, 24);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.toolStripSeparator2,
            this.placeOrderToolStripMenuItem,
            this.toolStripSeparator1,
            this.selectColorToolStripMenuItem,
            this.toolStripSeparator5,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(173, 6);
            // 
            // placeOrderToolStripMenuItem
            // 
            this.placeOrderToolStripMenuItem.Name = "placeOrderToolStripMenuItem";
            this.placeOrderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.placeOrderToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.placeOrderToolStripMenuItem.Text = "Place Order";
            this.placeOrderToolStripMenuItem.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(173, 6);
            // 
            // selectColorToolStripMenuItem
            // 
            this.selectColorToolStripMenuItem.Name = "selectColorToolStripMenuItem";
            this.selectColorToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.selectColorToolStripMenuItem.Text = "Select Color";
            this.selectColorToolStripMenuItem.Click += new System.EventHandler(this.selectColorToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(173, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionsToolStripMenuItem,
            this.toolStripSeparator4,
            this.infoToolStripMenuItem,
            this.toolStripSeparator3,
            this.versionToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.instructionsToolStripMenuItem.Text = "Instructions";
            this.instructionsToolStripMenuItem.Click += new System.EventHandler(this.instructionsToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(170, 6);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(170, 6);
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.versionToolStripMenuItem.Text = "Version";
            this.versionToolStripMenuItem.Click += new System.EventHandler(this.versionToolStripMenuItem_Click);
            // 
            // pctBxPersonal
            // 
            this.pctBxPersonal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctBxPersonal.BackgroundImage")));
            this.pctBxPersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctBxPersonal.Location = new System.Drawing.Point(351, 182);
            this.pctBxPersonal.Name = "pctBxPersonal";
            this.pctBxPersonal.Size = new System.Drawing.Size(155, 110);
            this.pctBxPersonal.TabIndex = 8;
            this.pctBxPersonal.TabStop = false;
            this.pctBxPersonal.Visible = false;
            // 
            // pctBxSuper
            // 
            this.pctBxSuper.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctBxSuper.BackgroundImage")));
            this.pctBxSuper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctBxSuper.Location = new System.Drawing.Point(351, 183);
            this.pctBxSuper.Name = "pctBxSuper";
            this.pctBxSuper.Size = new System.Drawing.Size(155, 108);
            this.pctBxSuper.TabIndex = 9;
            this.pctBxSuper.TabStop = false;
            this.pctBxSuper.Visible = false;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(583, 465);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tony\'s Pizza";
            this.tabControl1.ResumeLayout(false);
            this.tabPizza.ResumeLayout(false);
            this.tabPizza.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBxPizza)).EndInit();
            this.tbBeverages.ResumeLayout(false);
            this.tbBeverages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBxPersonal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBxSuper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPizza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstBxCrust;
        private System.Windows.Forms.ListBox lstBxSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tbBeverages;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox ckBxToppings;
        private System.Windows.Forms.PictureBox pctBxPizza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstBxBeverages;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem placeOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem selectColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pctBxPersonal;
        private System.Windows.Forms.PictureBox pctBxSuper;
    }
}

