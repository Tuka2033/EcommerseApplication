
using System.Diagnostics.Tracing;

namespace Banking
{
  public delegate void AccountHandler();  //define delegate
    public class Account
    {
         public event AccountHandler overBalance;//event
         public  event AccountHandler underBalance;//event


         public float Balance { get; set; }

        public Account(float amount) {
            this.Balance = amount;
        }
        public void monitor()
        {
            if (this.Balance < 5000)
            {
                underBalance();
            }
            else if(this.Balance>50000)
            {
                overBalance();
            }
        }
        public void Withdraw(float amount) {
            this.Balance = this.Balance - amount;
            monitor();
        }
        public void Deposit(float amount)
        {
            this.Balance = this.Balance + amount;
             monitor();
        }
        public override string ToString()
        {
            return this.Balance.ToString();
        }
    }
}
