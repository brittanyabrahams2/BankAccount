using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomerDAL
    {
        public void Create(Customer newCustomer)
        {
            // Connect to the DB and create a new record.
        }

        public Customer Get(int id)
        {
            
                // Connect to DB, search for record with matching id.
                Customer cust = new Customer()
                {
                    Id = id,
                    Firstname = "Fred",
                    Lastname = "Smith"
                };



                return cust;
            
            
        }

        public List<Customer> GetAll()
        {
            // Connect to the DB and fetch all Customer records.
            List<Customer> customerList = new List<Customer>()
            {
                
            };

            return customerList;

          } 
    }
}
