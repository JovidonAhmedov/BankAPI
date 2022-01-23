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
        public Account Create(Account item)
        {
            try
            {
                db.Accounts.Add(item);
                db.SaveChanges();
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            return item;
        }

        // get Account by accountCode
        public Account GetByAccountCode(long? id)
        {
            try
            {
                var account = db.Accounts.FirstOrDefault(a => a.AccountCode == id);
                return account;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
     
        }

        // get Account by accountCode
        public Account GetByMsisdn(long? id)
        {
            try
            {
                var account = db.Accounts.FirstOrDefault(a => a.Msisdn == id);
                return account;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}
