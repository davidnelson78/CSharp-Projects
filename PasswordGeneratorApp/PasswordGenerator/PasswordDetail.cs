using System;
using System.Drawing;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class PasswordDetail : Form
    {
        public PasswordDetail()
        {
            InitializeComponent();
        }

        private Provider p = new Provider("psCnf.ok");
        public static int rowID;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int update = p.UpdateData(rowID, txtTitle.Text, txtPassword.Text, txtCustomPassword.Text);

            if (update > 0)
            {
                lblUpdate.ForeColor = Color.Green;
                lblUpdate.Text = "Password Update :)";
                this.Hide();
            }
            else
            {
                lblUpdate.ForeColor = Color.Red;
                lblUpdate.Text = "Error! Password is Not Update :(";
            }
        }

        private void txtTitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCustomPassword.Focus();
            }
        }

        private void txtCustomPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnUpdate.PerformClick();
            }
        }

        private void PasswordDetail_Load(object sender, EventArgs e)
        {
            txtTitle.SelectionStart = txtTitle.Text.Length;
            txtTitle.DeselectAll();

            txtPassword.SelectionStart = txtPassword.Text.Length;
            txtPassword.DeselectAll();

            txtCustomPassword.SelectionStart = txtCustomPassword.Text.Length;
            txtCustomPassword.DeselectAll();
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            txtPassword.SelectAll();
        }
    }
}