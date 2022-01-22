using Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repository
{
    public interface ITransactionRepository
    {
        Transaction getById(long id);
        Transaction create(Transaction item);
    }
}
