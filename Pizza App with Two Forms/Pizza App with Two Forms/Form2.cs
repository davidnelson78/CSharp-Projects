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
    public partial class Form2 : Form
    {
        private Orders[] regOrders;
        private int count;
        private double cost;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Orders[] theOrders, int anIndex, double dailyCost)
        {
            InitializeComponent();
            regOrders = theOrders;
            count = anIndex;
            cost = dailyCost;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int index = 0;

            if (count > 0)
            {
                do
                {
                    lstBxSize.Items.Add(regOrders[index].PizzaSize);
                    lstBxBeverages.Items.Add(regOrders[index].Beverage);
                    index++;
                }
                while (index < count);
            }

            txtBxSales.Text = string.Format("{0:C}", cost).ToString();
        }
    }
}