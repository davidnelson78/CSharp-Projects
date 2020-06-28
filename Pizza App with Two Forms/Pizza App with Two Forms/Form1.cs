using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_App_with_Two_Forms
{
    public partial class Form1 : Form
    {
        private int theIndex = 0;
        private string theSize;
        private double dailyCost = 0;

        private Orders[] dailyOrders = new Orders[100];

        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            double cost = 0;
            string size = "";
            string beverage = "";
            int index;

            pctBxPersonal.Visible = false;
            pctBxSlice.Visible = false;
            pctBxSuper.Visible = false;

            size = lstBxSize.Text;

            if (size != "")
            {
                if (size.StartsWith("P"))
                {
                    pctBxPersonal.Visible = true;
                    pctBxSlice.Visible = false;
                    pctBxSuper.Visible = false;
                    theSize = "Personal";
                }
                else if (size.StartsWith("S"))
                {
                    pctBxPersonal.Visible = false;
                    pctBxSlice.Visible = false;
                    pctBxSuper.Visible = true;
                    theSize = "Super";
                }
                else
                {
                    pctBxPersonal.Visible = false;
                    pctBxSlice.Visible = true;
                    pctBxSuper.Visible = false;
                    if (size.StartsWith("M"))
                        theSize = "Medium";
                    else
                        theSize = "Large";
                }

                index = size.IndexOf("$");
                size = size.Remove(0, index + 1);
                cost = double.Parse(size);

                foreach (string i in chkLstBxToppings.CheckedItems)
                    cost += 1.50;

                beverage = lstBxBeverage.Text;
                if (beverage != "")
                {
                    index = beverage.IndexOf("$");
                    beverage = beverage.Remove(index - 3, 8);

                    switch (beverage)
                    {
                        case "Tea":
                        case "Coffee":
                            cost += 1.50;
                            break;

                        case "Soda":
                        case "Lemonade":
                            cost += 2.00;
                            break;

                        case "Milk":
                        case "Juice":
                            cost += 1.75;
                            break;

                        default:
                            break;
                    }
                }

                dailyCost += cost;
                dailyOrders[theIndex] = new Orders(theSize, beverage);
                theIndex++;

                txtBxCost.Text = string.Format("{0:C}", cost).ToString();
            }
            else
                MessageBox.Show("Please enter the size of the pizza");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (theIndex > 0)
            {
                this.Visible = false;
                Form2 form2 = new Form2(dailyOrders, theIndex, dailyCost);
                form2.ShowDialog();
            }
        }

        private void resetOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (int index in chkLstBxToppings.CheckedIndices)
                chkLstBxToppings.SetItemChecked(index, false);

            chkLstBxToppings.Update();

            chkLstBxToppings.ClearSelected();
            lstBxBeverage.ClearSelected();
            txtBxCost.Text = "";
            lstBxSize.ClearSelected();
            lstBxCrust.ClearSelected();

            pctBxPersonal.Visible = false;
            pctBxSlice.Visible = false;
            pctBxSuper.Visible = false;

            tabControl1.SelectTab(0);
        }
    }
}