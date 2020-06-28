using System;
using System.Drawing;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class SavePassword : Form
    {
        private Provider p = new Provider("psCnf.ok");

        public SavePassword()
        {
            InitializeComponent();
        }

        private void btnSavePassword_Click(object sender, EventArgs e)
        {
            bool tableExists = p.CheckTable("passwords");
            if (!tableExists)
            {
                int cr = p.CreateTable("passwords");
            }

            bool isEmpty = txtTitle.Text == string.Empty && txtPassword.Text == string.Empty;

            string customPass = txtCustom.Text;

            int ins = 0;

            if (!isEmpty)
            {
                ins = p.InsertData(txtTitle.Text, txtPassword.Text, customPass);

                if (ins > 0)
                {
                    lblStatus.ForeColor = Color.Green;
                    lblStatus.Text = "Your password was saved";
                }
                else
                {
                    lblStatus.ForeColor = Color.Red;
                    lblStatus.Text = "Sorry, your password was not saved";
                }
            }
            else
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "A title and access code is required";
            }
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.SelectAll();
            txtPassword.Focus();
        }

        private void SavePassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            PasswordList pList = new PasswordList();

            lblStatus.Text = string.Empty;
            txtTitle.Text = string.Empty;
            txtCustom.Text = string.Empty;
            pList.dgvPasswordList.DataSource = p.GetDataTable();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
        }
    }
}