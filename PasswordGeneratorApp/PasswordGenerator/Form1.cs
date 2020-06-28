using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SavePassword savePassword = new SavePassword();

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int txtValue = 16;
            try
            {
                txtValue = (!string.IsNullOrEmpty(txtNumber.Text)) ? int.Parse(txtNumber.Text) : 16;

                if (txtValue > 255)
                {
                    MessageBox.Show("Max 255 character!", "ERROR");
                }
                else
                {
                    string generatedPassword = PasswordClass.Generate(txtValue);
                    lstGenerated.Items.Add(generatedPassword);
                    lstGenerated.SetSelected(lstGenerated.Items.IndexOf(generatedPassword), true);
                    lblOutput.ForeColor = Color.Red;
                    lblOutput.Text = "Password generated.\nClick a password to copy it to your clipboard";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtNumber.Text = "";
            }
        }

        private void chkLower_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLower.Checked)
            {
                PasswordClass.useLower = true;
            }
            else
            {
                PasswordClass.useLower = false;
            }
        }

        private void chkUpper_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUpper.Checked)
            {
                PasswordClass.useUpper = true;
            }
            else
            {
                PasswordClass.useUpper = false;
            }
        }

        private void chkNumeric_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNumeric.Checked)
            {
                PasswordClass.useNumeric = true;
            }
            else
            {
                PasswordClass.useNumeric = false;
            }
        }

        private void chkSpecial_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSpecial.Checked)
            {
                PasswordClass.useSpecial = true;
            }
            else
            {
                PasswordClass.useSpecial = false;
            }
        }

        private void lstGenerated_Click(object sender, EventArgs e)
        {
            if (lstGenerated.SelectedItems.OfType<string>().ToArray().Length > 0)
            {
                Clipboard.SetText(string.Join(Environment.NewLine, lstGenerated.SelectedItems.OfType<string>().ToArray()));
                lblOutput.ForeColor = Color.Green;
                lblOutput.Text = "Password copied to clipboard";
            }
            else
            {
                lblOutput.ForeColor = Color.Red;
                lblOutput.Text = "You've clicked an empty line!\nPlease generate or select a password";
            }
        }

        private void lstGenerated_DoubleClick(object sender, EventArgs e)
        {
            string generatedPassword = string.Join(Environment.NewLine, lstGenerated.SelectedItems.OfType<string>().ToArray());
            savePassword.txtPassword.Text = generatedPassword;
            savePassword.ShowDialog();
        }

        private void lnkLblCustom_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            savePassword.ShowDialog();
        }

        private void lnkLblShowPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PasswordList pl = new PasswordList();
            pl.ShowDialog();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                PasswordList pList = new PasswordList();
                pList.ShowDialog();
            }
            else if (e.Control && e.KeyCode == Keys.C)
            {
                if (lstGenerated.SelectedItems.OfType<string>().ToArray().Length > 0)
                {
                    Clipboard.SetText(string.Join(Environment.NewLine, lstGenerated.SelectedItems.OfType<string>().ToArray()));
                    lblOutput.ForeColor = Color.Green;
                    lblOutput.Text = "Password copied to clipboard";
                }
                else
                {
                    lblOutput.ForeColor = Color.Red;
                    lblOutput.Text = "You've clicked an empty line!\nPlease generate or select a password";
                }
            }
            else if (e.Control && e.KeyCode == Keys.P)
            {
                string generatedPassword = string.Join(Environment.NewLine, lstGenerated.SelectedItems.OfType<string>().ToArray());
                if (generatedPassword != string.Empty)
                {
                    savePassword.txtPassword.Text = generatedPassword;
                    savePassword.ShowDialog();
                }
                else
                {
                    savePassword.ShowDialog();
                }
            }
            else if (e.Control && e.KeyCode == Keys.G)
            {
                btnGenerate.PerformClick();
                lstGenerated.Focus();
                lstGenerated.Select();
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (lstGenerated.SelectedIndex > 0)
                {
                    lstGenerated.SelectedIndex--;
                }
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (lstGenerated.SelectedIndex < (lstGenerated.Items.Count - 1))
                {
                    lstGenerated.SelectedIndex++;
                }
                e.Handled = true;
            }
            else if (e.Alt && e.KeyCode == Keys.L)
            {
                e.SuppressKeyPress = true;
                if (!chkLower.Checked)
                {
                    chkLower.Checked = true;
                }
                else
                {
                    chkLower.Checked = false;
                }
            }
            else if (e.Alt && e.KeyCode == Keys.U)
            {
                e.SuppressKeyPress = true;
                if (!chkUpper.Checked)
                {
                    chkUpper.Checked = true;
                }
                else
                {
                    chkUpper.Checked = false;
                }
            }
            else if (e.Alt && e.KeyCode == Keys.N)
            {
                e.SuppressKeyPress = true;
                if (!chkNumeric.Checked)
                {
                    chkNumeric.Checked = true;
                }
                else
                {
                    chkNumeric.Checked = false;
                }
            }
            else if (e.Alt && e.KeyCode == Keys.S)
            {
                e.SuppressKeyPress = true;
                if (!chkSpecial.Checked)
                {
                    chkSpecial.Checked = true;
                }
                else
                {
                    chkSpecial.Checked = false;
                }
            }
            else if (e.Alt)
            {
                e.SuppressKeyPress = true;
            }
            else if (e.Control && e.KeyCode == Keys.E)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}