using System;

namespace MoneyApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double totalAmount;
            double depositAmount;
            string typeOfAccount;

            BankAccount janesAccount = new BankAccount();

            depositAmount = 123.32;
            typeOfAccount = "Savings";

            BankAccount billsAccount = new BankAccount(depositAmount, typeOfAccount);

            depositAmount = 23.12;
            BankAccount tomsAccount = new BankAccount(depositAmount, typeOfAccount);
            tomsAccount.AccountType = "Checking";

            Console.WriteLine("\n\nEnter Jane's Deposit");
            depositAmount = double.Parse(Console.ReadLine());
            janesAccount.Amount = janesAccount.Amount + depositAmount;

            Console.WriteLine("Jane's account total is {0:C}", janesAccount.Amount, janesAccount.AccountType);
            Console.WriteLine("Tom's account total is {0:C}", tomsAccount.Amount);
            Console.WriteLine("Bill's account total is {0:C}", billsAccount.Amount);

            Console.ReadKey();
        }
    }
}