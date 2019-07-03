using System;
namespace Entities
{
    public class Account
    {
        public int Id { get; set; }
        public int accountNumber { get; set; }
        public string accountType { get; set; }
        public double Balance { get; set; }


        public virtual double Deposit(double Amount)
        {                              
            Balance += Amount;
            return Balance;
        }

        public virtual double Withdraw(double Amount)
        {

            Balance -= Amount;
            return Balance;
        }

    }
}
