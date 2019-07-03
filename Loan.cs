using System;
namespace Entities
{
    public class Loan : Account
    {
       // double Balance;
        static double AnnualInterest = 2; //fixed interest for all checking accounts

        //handling withdraw as loan repayment
        public double PayLoan(double Amount) //amount aka LoanAmt
        {
            Random rnd = new Random();
            int loanYears = rnd.Next(1,10);
            double i = AnnualInterest/12/100;
            double n = loanYears * 12;
            double d = Math.Pow((1 + i),n)/(i*(Math.Pow((1 + i),n))) ;//discountfactor

            Console.WriteLine("All customer loans are put on monthly plan.\n");
            Console.Write("You have 1 year to repay your loan.\nCONFIRM:Are you sure you would like to make a payment? (1)Yes (2)No \n");

            if (Console.ReadLine() == "1")
            {

                Balance = Amount / d;
                Console.WriteLine("You have just paid a payment of $" + Balance);
                Console.WriteLine("Your next payment is $ " + Balance);
                Console.WriteLine("Thank you for your payment.\n");
            }
            else if(Console.ReadLine() == "2")
            {
                Console.WriteLine("WARNING: Please remember that you have 1 year to pay off your loan.\n");
                
            }
            else
            {
                Console.WriteLine("WARNING:Please select an option \n");
            }


            return Balance;
        }

       

    }

}
