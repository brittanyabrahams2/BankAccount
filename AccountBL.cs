using System;
using System.Collections.Generic;
using BankDAL.Properties;
using DAL;
using Entities;


namespace BusinessLayer
{
    public class AccountBL
    {
        public void Create(Account newAccount)
        {
            // Call the DAL to create a new record.
            AccountDAL accountDAL = new AccountDAL();
            accountDAL.Create(newAccount);
        }

        public List<Account> GetAll()
        {
            AccountDAL dal = new AccountDAL();
            var account = dal.GetAll();

            return account;
        }

    }
}
