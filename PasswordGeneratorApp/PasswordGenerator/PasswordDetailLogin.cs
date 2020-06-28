using System;
using System.Drawing;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class PasswordDetailLogin : Form
    {
        public PasswordDetailLogin()
        {
            InitializeComponent();
        }

        private Provider p = new Provider("psCnf.ok");

        private void btnShow_Click(object sender, EventArgs e)
        {
            PasswordDetail pDetail = new PasswordDetail();

            int rowID = PasswordList.rowID;

            string rowTitle = PasswordList.rowTitle;
            string rowPassword = PasswordList.rowPassword;
            string rowCustomPassword = txtPasswordProtected.Text;

            bool isValid = p.CustomIsValid(rowID, rowCustomPassword);

            if (isValid)
            {
                PasswordDetail.rowID = rowID;
                pDetail.txtTitle.Text = rowTitle;
                pDetail.txtPassword.Text = rowPassword;
                pDetail.txtCustomPassword.Text = rowCustomPassword;
                pDetail.ShowDialog();
                Close();
            }
            else
            {
                lblPasswordTrue.ForeColor = Color.Red;
                lblPasswordTrue.Text = "Wrong Password!";
            }
        }

        private void PasswordDetailLogin_Load(object sender, EventArgs e)
        {
            string rowTitle = PasswordList.rowTitle;

            lblPassword.ForeColor = Color.Red;
            lblPassword.Text = rowTitle + " is password protected!";
        }

        private void txtPasswordProtected_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnShow.PerformClick();
            }
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {
        }
    }
}