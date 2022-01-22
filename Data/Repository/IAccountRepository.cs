using Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repository
{
    public interface IAccountRepository
    {
        Account getByaccountCode(long? id);
        Account getBymsisdn(long? id);
        Account create(Account item);
    }
}
