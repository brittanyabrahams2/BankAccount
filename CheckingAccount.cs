using System;


namespace Entities
{
    public class CheckingAccount :  Account
    {


        static double AnnualInterest = 0.5; //fixed interest for all checking accounts


        public override double Deposit(double Amount)
        {

            Balance += Amount;

            Console.WriteLine("You have successfully deposited $ " + Amount + " into your Checking Account.\n");
            return Balance;
        }

        public override double Withdraw(double Amount)
        {

            Balance -= Amount;

            //Cannot have overdraft
            //once the total satisfys this condition we can no longer withdraw
            if (Balance <= 0)
            {
                Console.WriteLine("WARNING: Balance below 0. NO FURTHER ACTIONS CAN BE DONE!\n");
            }
            else
            {
                //treat remaining as normal withdraw
                Console.WriteLine("You have just withdrawn $" + Amount );
            }
            return Balance;
        }


       
    }


}


