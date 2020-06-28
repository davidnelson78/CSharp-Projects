using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DatabaseGuiApp
{
    public partial class Form1 : Form
    {
        private ContactS aContact = new ContactS();
        private int numberOfContacts;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            {
                string error = "";
                int index = 0;

                numberOfContacts = aContact.ReadContacts(ref error);

                if (error != "")
                {
                    lblMessage.Text = error;
                    index = numberOfContacts;
                }

                while (index < numberOfContacts)
                {
                    cmbBxLastName.Items.Add(aContact.GetLastName(index));
                    index++;
                }
            }
        }

        public void CmbBxLastName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int theIndex = 0;
            string theFirstName;
            string theLastName;

            theIndex = cmbBxLastName.SelectedIndex;
            theFirstName = aContact.GetFirstName(theIndex);
            theLastName = aContact.GetLastName(theIndex);

            txtBxName.Text = theFirstName + " " + theLastName;

            txtBxAddress.Text = aContact.GetAddress(theIndex);
            txtBxCity.Text = aContact.GetCity(theIndex);
            txtBxState.Text = aContact.GetState(theIndex);
            txtBxZip.Text = aContact.GetZip(theIndex);
            txtBxPhone.Text = aContact.GetPhone(theIndex);
            txtBxEmail.Text = aContact.GetEMail(theIndex);
            Visibility(true);
        }

        public void Visibility(bool newState)
        {
            txtBxName.Visible = newState;
            txtBxAddress.Visible = newState;
            txtBxCity.Visible = newState;
            txtBxState.Visible = newState;
            txtBxZip.Visible = newState;
            txtBxPhone.Visible = newState;
            txtBxEmail.Visible = newState;

            lblFullName.Visible = newState;
            lblAddress.Visible = newState;
            lblCity.Visible = newState;
            lblState.Visible = newState;
            lblZip.Visible = newState;
            lblPhone.Visible = newState;
            lblEmail.Visible = newState;

            if (newState)
                pctrBxPhone.Visible = false;
            else
                pctrBxPhone.Visible = true;
        }

        private void PctrBxPhone_Click(object sender, EventArgs e)
        {
        }

        private void ResetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visibility(false);
            cmbBxLastName.Text = "";
        }

        private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string information;

            information = "Name:\t\tRobert Menzl\nCourse:\t\tITDEV - 115 - 002\nInstructor:\t\tMr. Menzl\nAssignment:\t#9 - Database Assignment\nDate:\t\t" + System.DateTime.Today.ToShortDateString();
            MessageBox.Show(information, "Database Assignment", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}