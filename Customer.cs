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
        public string UserID { get; set; }
        private string passcode { get; set; }

        public Customer()
        { 

        }

        public Customer(int id, string fname, string lname, string Username, string password)
        {
            this.Id = id;
            this.Firstname = fname;
            this.Lastname = lname;
            this.UserID = Username;
            this.passcode = password;
            
        }

        //create temp var that will be set equal to account.id and then set that value to the custoemr to check for each id
    }
}
