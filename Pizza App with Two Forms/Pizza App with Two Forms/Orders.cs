using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_App_with_Two_Forms
{
    public class Orders
    {
        private string pizzaSize;
        private string beverage;

        public Orders(string size, string drink)
        {
            pizzaSize = size;
            beverage = drink;
        }

        public Orders()
        {
        }

        public string PizzaSize
        {
            get
            {
                return pizzaSize;
            }
        }

        public string Beverage
        {
            get
            {
                return beverage;
            }
        }
    }
}