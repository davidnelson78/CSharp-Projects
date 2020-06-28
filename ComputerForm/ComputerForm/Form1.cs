using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerForm
{
    public partial class ClubForm : Form
    {
        public ClubForm()
        {
            InitializeComponent();
        }

        private void lstBxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            string result = " ";

            foreach (string activity in lstBxEvents.SelectedItems)
                result = result + activity + "     ";

            txtBxResult.Text = result;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            lstBxEvents.Items.Add(txtBxAct.Text);
            txtBxAct.Clear();
        }
    }
}