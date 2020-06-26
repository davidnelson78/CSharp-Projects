using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            string inValue;
            double purchaseAmount;
            double percent;
            double ans;

            while (double.TryParse(txtPurchases.Text, out purchaseAmount) == false)
            {
                MessageBox.Show("Value entered must be numeric");
                txtPurchases.Text = "0.0";
                txtPurchases.Focus();
            }

            inValue = lblTaxPercent.Text;
            inValue = inValue.Remove(inValue.Length - 1, 10);
            percent = double.Parse(inValue) / 100;

            ans = (purchaseAmount * percent) + purchaseAmount;
            txtTotalDue.Text = string.Format("{0:C}", ans);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}