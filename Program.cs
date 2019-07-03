using System;
using Entities;
using BusinessLayer;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd
{
    class Program
    {

        static List<Customer> customerList = new List<Customer>();
        static List<Account> accountList = new List<Account>();
        static List<double> transactionList = new List<double>();
        double AnnualInterest; //fixed interest for all checking accounts
        static void Main(string[] args)
        {

            string end;

            do
            {

                Console.WriteLine("Welcome to BCMA Banking App!\n-----------------------" +
                     "---------------------------------------------------------\nBCMA allows you to manage your bank account easily and efficiently straight" +
                     " from your console.\n ");

                Console.WriteLine("What would you like to do?\n (1)Register\n (2)Open Account\n (3)Close Account\n" +
                    " (4)Deposit\n (5)Withdraw\n (6)Transfer\n (7) Display list of accounts\n (8)Display list of transactions\n " +
                    "(9)Pay loan installment\n");
                //multiple choice kind of thing
                var action = Console.ReadLine();
                if (action == "1") //register
                {

                    Console.WriteLine("You have selected the register option\nPlease fill in your information below.");

                    Console.WriteLine("First name: ");
                    var fname = Console.ReadLine();

                    Console.WriteLine("Last name: ");
                    var lname = Console.ReadLine();
                    var name = fname + " " + lname;

                    Console.WriteLine("Welcome " + name + "!\nThank you for registering your account with BCMA bank.\n-------------Return to menu" +
                        "------------");
                    int Id = 100;
                    Customer customer = new Customer()
                    {
                        Firstname = fname,
                        Lastname = lname,
                        Id = Id
                    };
                    Random random = new Random();
                    Account account = new Account()
                    {
                        Id = Id++,
                        accountNumber = random.Next(0, 10000)
                       

                    };
                   

                    customerList.Add(customer);
                    accountList.Add(account);
                    Id++;

                }
                else if (action == "2") //open
                {
                    //TODO: if i am opening an account how to print to console
                    Console.WriteLine("What type of account would you like to open?\n (1)Checking account\n" +
                        " (2)Business account\n (3)Term Deposit\n (4)Loan\n ");

                    var account = Console.ReadLine();
                    switch (account)
                    {
                        case "1":
                            Console.WriteLine("Please type in your Customer Id");
                            Random random = new Random();
                            CheckingAccount ca = new CheckingAccount()
                            {
                                Id = Int32.Parse(Console.ReadLine()),
                                accountNumber = random.Next(0, 10000),
                                accountType = "Checking",
                                Balance = random.Next(0, 10000),

                            };
                            Console.Write("Your checking account has just been opened\n Id:" + ca.Id + "\nAccount Number: " +
                                ca.accountNumber + " \nAccount Type: " + ca.accountType + "\nStart Balance:  $" + ca.Balance);
                            double AnnualInterest = 0.5; //fixed interest for all checking accounts
                            Console.WriteLine("\nAnnual Percent Yield(APY): " + AnnualInterest + "%");
                            accountList.Add(ca);
                            Console.WriteLine(" \n------------- Return to menu------------");
                            break;

                        case "2":
                            Console.WriteLine("Please type in your Customer Id");
                            Random random1 = new Random();
                            BusinessAccount ba = new BusinessAccount()
                            {
                                Id = Int32.Parse(Console.ReadLine()),
                                accountNumber = random1.Next(0, 10000),
                                accountType = "Business",
                                Balance = random1.Next(0, 10000),
                            };
                            Console.Write("Your business account has just been opened\nId:" + ba.Id + "\nAccount Number: " + ba.accountNumber
                                + "\nAccount Type: " + ba.accountType + "\nStart Balance: $" + ba.Balance);
                            double AnnualInterest2 = 0.6; 
                            Console.WriteLine("\nAnnual Percent Yield(APY): " + AnnualInterest2 + "%");
                            accountList.Add(ba);
                            Console.WriteLine(" \n------------- Return to menu------------");
                            break;
                        case "3"://term dep
                            Console.WriteLine("Please type in your Customer Id");
                            Random random2 = new Random();
                            TermDeposit td = new TermDeposit()
                            {
                                Id = Int32.Parse(Console.ReadLine()),
                                accountNumber = random2.Next(0, 10000),
                                accountType = "Term Deposit",
                                Balance = random2.Next(0, 10000),
                            };
                            Console.Write("Your term deposit account has just been opened\n Id: " +td.Id + "\nAccount Number: " +
                                td.accountNumber + " \nAccount Type: " + td.accountType + "\nStart Balance: $" );
                            double AnnualInterest3 = 0.6;
                            Console.WriteLine("\nAnnual Percent Yield(APY): " + AnnualInterest3 + "%");
                            accountList.Add(td);
                            Console.WriteLine(" \n------------- Return to menu------------");
                            break;
                        case "4"://loan
                            Console.WriteLine("Please type in your Customer Id");
                            Random random4 = new Random();
                            Loan l = new Loan()
                            {
                                Id = Int32.Parse(Console.ReadLine()),
                                accountNumber = random4.Next(0, 10000),
                                accountType = "Loan",
                            };
                            Console.Write("Your loan has just been opened\n Id:" + l.Id + "\nAccount Number: " +
                                l.accountNumber + " \nAccount Type: " + l.accountType + "\nStart Balance: $" + l.Balance);
                            accountList.Add(l);
                            Console.WriteLine(" \n------------- Return to menu------------");
                            break;
                        default:
                            Console.WriteLine("WARNING: No further action can be performed.\n Press q to " +
                                "return back to the main menu...");
                            break;

                    }
                }
                else if (action == "3") //close
                                        //updates list With new values
                {
                    Console.WriteLine("Which account would you like to close?\n (1)Checking account\n " +
                        "(2)Business account\n");

                    var account = Console.ReadLine();
                    switch (account)
                    {
                        case "1": //checking account
                                  //essentailly need to delete from the list and update

                            Console.WriteLine("What is your ID number?");
                            var number = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Searching for Customer ID:\n " + number);
                            CheckingAccount ca = new CheckingAccount()
                            {
                                Id = number,
                                accountNumber = 0,          //0 means closed
                                accountType = "Checking"
                            };
                            Console.Write("Your checking account has been closed:\n Id:" + ca.Id + "\nAccount Number: "
                                + ca.accountNumber + "\nAccount Type: " + ca.accountType);
                            Console.WriteLine(" \n------------- Return to menu------------");
                            break;

                        case "2"://business account
                            Console.WriteLine("What is your ID number?");
                            var number1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Searching for Customer ID: " + number1);
                            BusinessAccount ba = new BusinessAccount()
                            {
                                Id = number1,
                                accountNumber = 0,          //0 means closed
                                accountType = "Business"
                            };

                            Console.Write("Your business account has been closed:\n Id:" + ba.Id + "\nAccount Number: "
                                + ba.accountNumber + "\nAccount Type: " + ba.accountType);
                            Console.WriteLine(" \n------------- Return to menu------------");
                            break;

                        default:
                            Console.WriteLine("WARNING: No further action can be performed.\n Press q to " +
                                "return back to the main menu...");
                            break;
                    }
                }
                else if (action == "4") //deposit
                {
                    Console.WriteLine("Which account would you like to deposit money into?\n (1)Checking account\n (2)Business account\n (3) Term Despoit\n ");
                    var account = Console.ReadLine();
                    switch (account)
                    {
                        case "1":
                            CheckingAccount ca = new CheckingAccount();
                            Console.WriteLine("Please enter your Customer ID:\n");
                            ca.Id = Int32.Parse(Console.ReadLine());
                            Random random = new Random();
                            ca.accountNumber = random.Next(0, 10000);
                            Console.WriteLine("Your account number: " + ca.accountNumber);
                            ca.accountType = "Checking";
                            Console.WriteLine("How much would you like to deposit?");
                            ca.Balance = ca.Deposit(Convert.ToDouble(Console.ReadLine()));
                            transactionList.Add(ca.Balance);
                            Console.WriteLine(" \n------------- Return to menu------------");
                            break;
                        case "2":
                            BusinessAccount ba = new BusinessAccount();
                            Console.WriteLine("Please enter your Customer ID:\n");
                            ba.Id = Int32.Parse(Console.ReadLine());
                            Random random1 = new Random();
                            ba.accountNumber = random1.Next(0, 10000);
                            Console.WriteLine("Your account number: " + ba.accountNumber);
                            ba.accountType = "Checking";
                            Console.WriteLine("How much would you like to deposit?");
                            ba.Balance = ba.Deposit(Convert.ToDouble(Console.ReadLine()));
                            transactionList.Add(ba.Balance);
                            Console.WriteLine(" \n------------- Return to menu------------");
                            break;

                        case "3":
                            TermDeposit td = new TermDeposit();
                            Console.WriteLine("Please enter your Customer ID:\n");
                            td.Id = Int32.Parse(Console.ReadLine());
                            Random random2 = new Random();
                            td.accountNumber = random2.Next(0, 10000);
                            Console.WriteLine("Your account number: " + td.accountNumber);
                            td.accountType = "Checking";
                            Console.WriteLine("How much would you like to deposit?");
                            td.Balance = td.Deposit(Convert.ToDouble(Console.ReadLine()));
                            transactionList.Add(td.Balance);
                            Console.WriteLine(" \n------------- Return to menu------------");
                            break;
                        default:
                            Console.WriteLine("WARNING: No further action can be performed.\n Press q to " +
                                "return back to the main menu...");
    
                            break;
                    }
                }
                else if (action == "5") //withdraw
                {
                    Console.WriteLine("Which account would you like to withdraw money from? (1)Checking account\n " +
                        "(2)Business account\n (3) Term Deposit\n ");
                    var account = Console.ReadLine();
                    switch (account)
                    {
                        case "1"://checking

                            CheckingAccount ca = new CheckingAccount();
                            Console.WriteLine("Please enter your Customer ID:\n");
                            ca.Id = Int32.Parse(Console.ReadLine());
                            Random random = new Random();
                            ca.accountNumber = random.Next(0, 10000);
                            Console.WriteLine("Your account number: " + ca.accountNumber);
                            ca.accountType = "Checking";
                            Console.WriteLine("How much would you like to withdraw?");
                            ca.Balance = ca.Withdraw(Convert.ToDouble(Console.ReadLine()));
                            Console.WriteLine(ca.Balance);
                            transactionList.Add(ca.Balance);
                            Console.WriteLine(" \n------------- Return to menu------------");
                            break;

                        case "2": //business
                            BusinessAccount ba = new BusinessAccount();

                            Console.WriteLine("Please enter your Customer ID:\n");
                            ba.Id = Int32.Parse(Console.ReadLine());

                            Random random1 = new Random();
                            ba.accountNumber = random1.Next(0, 10000);

                            Console.WriteLine("Your account number: " + ba.accountNumber);
                            ba.accountType = "Business";

                            Console.WriteLine("How much would you like to withdraw?");
                            ba.Balance = ba.Withdraw(Convert.ToDouble(Console.ReadLine()));

                            Console.WriteLine(ba.Balance);
                            transactionList.Add(ba.Balance);
                            Console.WriteLine(" \n------------- Return to menu------------");
                            break;
                        case "3": //term deposit
                            TermDeposit td = new TermDeposit();
                            Console.WriteLine("Please enter your Customer ID:\n");
                            td.Id = Int32.Parse(Console.ReadLine());
                            Random random2 = new Random();
                            td.accountNumber = random2.Next(0, 10000);
                            Console.WriteLine("Your account number: " + td.accountNumber);
                            td.accountType = "Term Deposit";
                            Console.WriteLine("How much would you like to withdraw?");
                            td.Balance = td.Withdraw(Convert.ToDouble(Console.ReadLine()));
                            Console.WriteLine(td.Balance);
                            transactionList.Add(td.Balance);
                            Console.WriteLine(" \n------------- Return to menu------------");
                            break;
                        default:
                            Console.WriteLine("WARNING: No further action can be performed.\n Press q to " +
                                "return back to the main menu...");
                            break;
                    }


                }

                else if (action == "6") //transfer
                {
                    Console.WriteLine("Which account would you like to transfer money from? " +
                        "(1)Checking account\n (2)Business account\n ");

                    var account = Console.ReadLine();
                    switch (account)
                    {

                        case "1":
                            Console.WriteLine("You are now transferring money to your Business account\n");
                            Console.WriteLine("How much would you like to transfer?");
                            var transfer = Console.ReadLine();

                            Console.WriteLine("How much would you like to transfer?");
                            CheckingAccount ca = new CheckingAccount();
                            Transfer t = new Transfer();
                            double amount = ca.Withdraw(Int32.Parse(transfer));
                            transactionList.Add(amount);
                            Console.WriteLine("transfer to business complete");
                            Console.WriteLine(" \n------------- Return to menu------------");
                            break;

                        case "2":
                            Console.WriteLine("You are now transferring money to your Business account\n");
                            Console.WriteLine("How much would you like to transfer?");
                            var transfer1 = Console.ReadLine();

                            Console.WriteLine("How much would you like to transfer?");
                            BusinessAccount ba = new BusinessAccount();
                            Transfer t1 = new Transfer();
                            double amount1 = ba.Withdraw(Int32.Parse(transfer1));
                            transactionList.Add(amount1);
                            Console.WriteLine("transfer to business complete");
                            Console.WriteLine(" \n------------- Return to menu------------");
                            break;

                        default:
                            Console.WriteLine("WARNING: No further action can be performed.\n Press q to return to menu...");
                            break;
                    }


                }
                else if (action == "7") //display accounts
                {

                    foreach (Account item in accountList)
                    {
                        Console.WriteLine($"Id: {item.Id} - Account Number: {item.accountNumber} - Account type: {item.accountType}");
                    }

                }
                else if (action == "8")//display transactions
                {
                    foreach (double item in transactionList)
                    {
                        Console.WriteLine($"Transaction history: " + item);
                    }
                }
                else if (action == "9") //pay loan
                {
                    Console.WriteLine("From which account would you like to pay your loan? (1)Checking (2) Business");
                    var pay = Console.ReadLine();
                    if (pay == "1") //checking
                    {
                        Console.WriteLine("What is your Customer Id?");
                        var id = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Customer Id:" + id);

                        CheckingAccount ca = new CheckingAccount();

                        Loan loan = new Loan();
                        Console.WriteLine("How much money would you like to pay? ");
                        loan.PayLoan(Convert.ToDouble(Console.ReadLine()));

                        double deduction = ca.Withdraw(loan.PayLoan(Convert.ToDouble(Console.ReadLine())));
                        transactionList.Add(deduction);
                        Console.WriteLine(" \n------------- Return to menu------------");
                    }
                    else if (pay == "2") //business
                    {
                        Console.WriteLine("What is your Customer Id?");
                        var id = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Customer Id:" + id);

                        BusinessAccount ba = new BusinessAccount();

                        Loan loan = new Loan();
                        Console.WriteLine("How much money would you like to pay? ");
                        loan.PayLoan(Convert.ToDouble(Console.ReadLine()));

                        double deduction = ba.Withdraw(loan.PayLoan(Convert.ToDouble(Console.ReadLine())));
                        transactionList.Add(deduction);
                        Console.WriteLine(" \n------------- Return to menu------------");
                    }

                }
                else
                {
                    Console.WriteLine("WARNING: No further action can be performed.\n Return to menu q...");

                }

                end = Console.ReadLine();

            } while (end == "q");


          
            

        } 

    }
}

