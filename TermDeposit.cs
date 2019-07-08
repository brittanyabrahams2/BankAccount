using System;
namespace Entities
{
    public class TermDeposit :  Account
    {
        
        public double AnnualInterest = 0.20;
        public double InterestRate = 2.5;

        //how much you are depositing
        public override double Deposit(double Amount)
        {
            Balance += Amount;
            Console.WriteLine("You are making a term deposit of $" + Balance + ".\n");
            return Balance;

        }

        //must meet time restrictino in order to withdraw
        public override double Withdraw(double Amount)
        {
            Random rnd = new Random();
            int years = rnd.Next(5); 
            int months = 12 * years;

            Console.WriteLine("You are attempting to withdraw $" + Amount + " from your Term Deposit.\n");

            //immature
            if (years < 1)
            {
                Console.WriteLine("WARNING:Account has not matured. Cannot withdraw money!\n");
            }
            //mature
            else
            {
                Balance = InterestRate * months * Amount;
                Console.WriteLine("You have successfully accumulated $" + Balance + ".\n");

                
                var TermBal = Console.ReadLine();
                int result = Int32.Parse(TermBal);

                Balance -= result;
                Console.WriteLine("You have successfully withdrawn $" + Balance + " from your Term Deposit.");

            }
            return Balance;

        }

       

    }

}



