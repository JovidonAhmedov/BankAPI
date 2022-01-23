using Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repository
{
    public interface IAccountRepository
    {
        Account GetByAccountCode(long? id);
        Account GetByMsisdn(long? id);
        Account Create(Account item);
    }
}
