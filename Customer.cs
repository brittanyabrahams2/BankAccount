using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        
        public Customer()
        { 

        }

        public Customer(int id, string fname, string lname)
        {
            this.Id = id;
            this.Firstname = fname;
            this.Lastname = lname;
            
        }
    }
}
