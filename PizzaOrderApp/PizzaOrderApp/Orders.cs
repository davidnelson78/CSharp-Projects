namespace PizzaOrderApp
{
    internal class Orders
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
                return PizzaSize;
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