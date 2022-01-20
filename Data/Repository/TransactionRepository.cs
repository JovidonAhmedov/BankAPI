﻿using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repository
{
    public class TransactionRepository : IRepository<Transaction>
    {
        private readonly BankDbContext db;
        public TransactionRepository(BankDbContext db)
        {
            this.db = db;
        }

        public Transaction create(Transaction item)
        {
            db.Transactions.Add(item);
            db.SaveChanges();
            return item;
        }


        public Transaction get(long id)
        {
            return db.Transactions.FirstOrDefault(s=>s.transactionId==id);
        }

    }
}