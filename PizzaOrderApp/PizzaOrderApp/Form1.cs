using System;
using System.Windows.Forms;

namespace PizzaOrderApp
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            double cost = 0;
            string size = "";
            string beverage = "";
            int index;

            pctBxPersonal.Visible = false;
            pctBxPizza.Visible = false;
            pctBxSuper.Visible = false;

            size = lstBxSize.Text;

            if (size != "")
            {
                if (size.StartsWith("P"))
                {
                    pctBxPizza.Visible = false;
                    pctBxPersonal.Visible = true;
                    pctBxSuper.Visible = false;
                }
                else if (size.StartsWith("S"))
                {
                    pctBxPizza.Visible = false;
                    pctBxPersonal.Visible = false;
                    pctBxSuper.Visible = true;
                }
                else
                {
                    pctBxPizza.Visible = true;
                    pctBxPersonal.Visible = false;
                    pctBxSuper.Visible = false;
                }

                index = size.IndexOf("$");
                size = size.Remove(0, index + 1);
                cost = double.Parse(size);

                foreach (string i in ckBxToppings.CheckedItems)
                    cost += 1.50;

                beverage = lstBxBeverages.Text;
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

                txtCost.Text = string.Format("{0:C}", cost).ToString();
            }
            else
                MessageBox.Show("Please Enter the Size of Your Pizza");
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (int index in ckBxToppings.CheckedIndices)
            {
                ckBxToppings.SetItemChecked(index, false);
            }
            ckBxToppings.Update();

            ckBxToppings.ClearSelected();
            lstBxBeverages.ClearSelected();
            txtCost.Text = "";
            lstBxSize.ClearSelected();
            lstBxCrust.ClearSelected();

            pctBxPersonal.Visible = false;
            pctBxPizza.Visible = false;
            pctBxSuper.Visible = false;
        }

        private void selectColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = tbBeverages.BackColor;
            if (colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                tbBeverages.BackColor = colorDialog1.Color;
                tabPizza.BackColor = colorDialog1.Color;
                this.BackColor = colorDialog1.Color;
            }
        }

        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("*********************************************************************************\n\nPlease select the size, the type of crust and the ingredients for your \nperfect pizza.   And don't forget your drink!!\n\n*********************************************************************************");
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name:\t\tRobert Menzl\nCourse:\t\tITDEV - 115 - 500\nInstructor:\t\tMr. Menzl\nAssignment:\tPizza App\nDate:\t\t" + System.DateTime.Today.ToShortDateString());
        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("***************\n\nVersion 1.0\n\n***************");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}