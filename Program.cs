using BusinessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the ECommerce App.");

            

            Console.WriteLine("Fetch list of Customers...");
            var customers = customerBL.GetAll();
            foreach(var item in customers)
            {
                Console.WriteLine($"Id: {item.Id} - Firstname: {item.Firstname} - Lastname: {item.Lastname}");
            }

            Customer aCustomer = new Customer()
            {
                Id = 102,
                Firstname = "Mary",
                Lastname = "Jane"
            };

            aCustomer.Email = "abc@xyx.com";

            //Customer cust1 = new Customer(103, "John", "Smith");

            Console.WriteLine("Press <ENTER> to continue...");
            Console.ReadLine();


        }
    }
}
