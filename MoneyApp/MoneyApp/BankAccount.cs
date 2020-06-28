namespace MoneyApp
{
    internal class BankAccount
    {
        private double amount;
        private string accountType;

        public double Amount
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
            }
        }

        public string AccountType
        {
            get
            {
                return accountType;
            }
            set
            {
                accountType = value;
            }
        }

        public BankAccount()
        {
            amount = 0;
            accountType = "Christmas Club";
        }

        public BankAccount(double dollars)
        {
            amount = dollars;
        }

        public BankAccount(double dollars, string accntTyp)
        {
            amount = dollars;
            accountType = accntTyp;
        }
    }
}