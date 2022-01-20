using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repository
{
    public class AccountRepository : IRepository<Account>
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
        public Account get(long id)
        {
            var account = db.Accounts.FirstOrDefault(a => a.accountCode == id);
            return account;
        }

    }
}
