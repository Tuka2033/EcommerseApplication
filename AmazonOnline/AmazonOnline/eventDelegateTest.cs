using Banking;
using GovertmentDelegate;
using BankRule;
using System;
namespace AmazonOnline
{
    class eventDelegateTest
    {
        static void Main(string[] args)
        {
            Account account = new Account(10000);
            account.overBalance += new AccountHandler(Goverment.PayIncomeTax);

            account.underBalance += new AccountHandler(HDFC.BlockAccount);

            Console.WriteLine("Enter Withdraw Ammout:");
            float amount = float.Parse(Console.ReadLine());
            account.Withdraw(amount);
            Console.WriteLine("Enter Deposit Ammout:");
            float amt = float.Parse(Console.ReadLine());
            account.Deposit(amt);
        }
    }
}
