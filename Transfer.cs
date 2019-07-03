using System;
namespace Entities
{
    public class Transfer :Account
    {
        public double Balance;
        public double AnnualInterest = 0.5; //fixed interest for all checking accounts

        //deposit money into new acc
        public double Deposit(double Amount)
        {
            Balance += Amount;

            Console.WriteLine("You have transferred $" + Amount + " into your Account.\nYou now have a balance of $" + Balance + ".\n");
            return Balance;
        }

        //withdraw from old acc
        public double Withdraw(double Amount)
        {
            Balance += Amount;

            Console.WriteLine("You transferred $" + Amount + " money from your Account.\nYou now have a balance of $" + Balance + ".\n");
            return Balance;
        }
        

       
        

        
    }
}
