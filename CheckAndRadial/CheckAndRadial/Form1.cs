using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckAndRadial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            decimal cost = 0;
            if (checkBox1.Checked)
            {
                cost += 50;
            }
            if (checkBox2.Checked)
            {
                cost += 25;
            }
            if (checkBox3.Checked)
            {
                cost += 100;
            }

            if (radioButton1.Checked)
            {
                cost += 25;
            }
            textBoxResult.Text = cost.ToString("C");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
    }
}