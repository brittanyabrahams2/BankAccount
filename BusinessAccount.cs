using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{

    public class BusinessAccount : Account 
    {
        static double OverDraftInterest = 2.5;

        public override double Deposit(double Amount)
        {
            Balance += Amount;

            Console.WriteLine("You have deposited $" + Amount + " into your Business Account.\nYou now have a balance of $" + Balance + ".\n");
            return Balance;
        }

        public override double Withdraw(double Amount)
        {

            Balance -= Amount;

            //handles overdraft
            if (Balance < 0)
            {
                Console.WriteLine("WARNING:Overdraft!\n");

                //overdraft fee interest (one time fee)
                Balance = (-1 * Balance * OverDraftInterest / 100) + 0 - Balance;
                Console.WriteLine("You have just withdrawn $" + Amount + " out of your Business account.\nYou owe $" +
                    Balance + (" (value after added on interest)\n"));
               
            }
            else
            {
                //remember (Total = Total - Amount)
                Console.WriteLine("You have just withdrawn $" + Amount + " out of your Business account. Your have a balance of $" + Balance);
            }
            return Balance;
        }

       

    }
}
