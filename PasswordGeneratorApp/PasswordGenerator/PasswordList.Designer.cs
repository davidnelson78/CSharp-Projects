namespace PasswordGenerator
{
    partial class PasswordList
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
            this.dgvPasswordList = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpPasswordList = new System.Windows.Forms.GroupBox();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.txtSearchKeyword = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cntRightMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasswordList)).BeginInit();
            this.grpPasswordList.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPasswordList
            // 
            this.dgvPasswordList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPasswordList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPasswordList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.title,
            this.password,
            this.customPassword});
            this.dgvPasswordList.Location = new System.Drawing.Point(24, 23);
            this.dgvPasswordList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPasswordList.Name = "dgvPasswordList";
            this.dgvPasswordList.ReadOnly = true;
            this.dgvPasswordList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPasswordList.Size = new System.Drawing.Size(540, 358);
            this.dgvPasswordList.TabIndex = 0;
            this.dgvPasswordList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPasswordList_CellDoubleClick);
            this.dgvPasswordList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvPasswordList_MouseDown);
            // 
            // id
            // 
            this.id.DataPropertyName = "ID";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // title
            // 
            this.title.DataPropertyName = "title";
            this.title.HeaderText = "Title";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // password
            // 
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "Password";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.Visible = false;
            // 
            // customPassword
            // 
            this.customPassword.DataPropertyName = "customPassword";
            this.customPassword.HeaderText = "CustomPassword";
            this.customPassword.Name = "customPassword";
            this.customPassword.ReadOnly = true;
            this.customPassword.Visible = false;
            // 
            // grpPasswordList
            // 
            this.grpPasswordList.AutoSize = true;
            this.grpPasswordList.Controls.Add(this.dgvPasswordList);
            this.grpPasswordList.Location = new System.Drawing.Point(17, 97);
            this.grpPasswordList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPasswordList.Name = "grpPasswordList";
            this.grpPasswordList.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPasswordList.Size = new System.Drawing.Size(584, 410);
            this.grpPasswordList.TabIndex = 1;
            this.grpPasswordList.TabStop = false;
            this.grpPasswordList.Text = "Password List";
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.txtSearchKeyword);
            this.grpSearch.Controls.Add(this.lblTitle);
            this.grpSearch.Location = new System.Drawing.Point(17, 16);
            this.grpSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpSearch.Size = new System.Drawing.Size(584, 74);
            this.grpSearch.TabIndex = 2;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search Title";
            // 
            // txtSearchKeyword
            // 
            this.txtSearchKeyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearchKeyword.Location = new System.Drawing.Point(68, 30);
            this.txtSearchKeyword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearchKeyword.Name = "txtSearchKeyword";
            this.txtSearchKeyword.Size = new System.Drawing.Size(495, 24);
            this.txtSearchKeyword.TabIndex = 1;
            this.txtSearchKeyword.TextChanged += new System.EventHandler(this.txtSearchKeyword_TextChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.Location = new System.Drawing.Point(8, 33);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(45, 18);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title:";
            // 
            // cntRightMenu
            // 
            this.cntRightMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cntRightMenu.Name = "cntRightMenu";
            this.cntRightMenu.Size = new System.Drawing.Size(61, 4);
            this.cntRightMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cntRightMenu_ItemClicked);
            // 
            // PasswordList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 521);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.grpPasswordList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "PasswordList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Saved Passwords";
            this.Load += new System.EventHandler(this.PasswordList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasswordList)).EndInit();
            this.grpPasswordList.ResumeLayout(false);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpPasswordList;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.TextBox txtSearchKeyword;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn customPassword;
        private System.Windows.Forms.ContextMenuStrip cntRightMenu;
        public System.Windows.Forms.DataGridView dgvPasswordList;
    }
}