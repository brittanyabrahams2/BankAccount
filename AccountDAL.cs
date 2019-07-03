using System;
using System.Collections.Generic;
using Entities;

namespace BankDAL.Properties
{
    public class AccountDAL
    {
        List<Account> accountList = new List<Account>();

        public void Create(Account newAccount)
        {
            // Connect to the DB and create a new record.
        }

      

      
        public List<Account> GetAll()
        {
            AccountDAL accountDAL = new AccountDAL();
            

            
            return accountList;

        }

    }
}