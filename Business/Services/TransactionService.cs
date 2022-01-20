using Data.Models;
using Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Services
{
    public class TransactionService
    {
        private IRepository<Transaction> repository;
        public TransactionService(IRepository<Transaction> repository)
        {
            this.repository = repository;
        }
    }
}
