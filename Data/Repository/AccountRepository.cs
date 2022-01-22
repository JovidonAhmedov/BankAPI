using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BankDbContext db;
        public AccountRepository(BankDbContext db)
        {
            this.db = db;
        }

        // add account
        public Account create(Account item)
        {
            db.Accounts.Add(item);
            db.SaveChanges();
            return item;
        }

        // get Account by accountCode
        public Account getByaccountCode(long? id)
        {
            try
            {
                var account = db.Accounts.FirstOrDefault(a => a.accountCode == id);
                return account;
            }
            catch
            {
                return null;
            }
        }

        // get Account by accountCode
        public Account getBymsisdn(long? id)
        {
            try
            {
                var account = db.Accounts.FirstOrDefault(a => a.msisdn == id);
                return account;
            }
            catch
            {
                return null;
            }
        }

    }
}
