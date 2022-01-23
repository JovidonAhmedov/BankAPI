using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repository
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly BankDbContext db;
        public TransactionRepository(BankDbContext db)
        {
            this.db = db;
        }

        public Transaction create(Transaction item)
        {
            try
            {
                db.Transactions.Add(item);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return item;

        }


        public Transaction getById(long id)
        {
            try
            {
                var transaction= db.Transactions.FirstOrDefault(s => s.transactionId == id);
                return transaction;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

    }
}
