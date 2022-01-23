using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data
{
    public static class SampleData
    {
        public static void Initialize(BankDbContext context)
        {
            if (!context.Accounts.Any())
            {
                context.Accounts.AddRange(
                    new Models.Account
                    {
                        Balance = 0,
                        Name = "Ali",
                        Surname = "Aliev",
                        Msisdn = 1,
                        Identification = false
                    },
                    new Models.Account
                    {
                        Balance = 0,
                        Name = "Vali",
                        Surname = "Valiev",
                        Msisdn = 2,
                        Identification = false
                    });
                    
            }

            if (!context.Merchants.Any())
            {
                context.Merchants.AddRange(
                    new Models.Merchant
                    {    
                        Name = "Merchant1"         
                    },
                    new Models.Merchant
                    {
                        Name = "Merchant2"
                    },
                    new Models.Merchant
                    {
                        Name = "Merchant3"
                    });
   
            }

            if (!context.Transactions.Any())
            {
                context.Transactions.AddRange(
                    new Models.Transaction
                    {
                         TransactionId=1,
                         Merchant=2,
                         Sum=200,
                         AccountCode=2
                    },
                    new Models.Transaction
                    {
                        TransactionId = 2,
                        Merchant = 3,
                        Sum = 300,
                        AccountCode = 2
                    },
                    new Models.Transaction
                    {
                        TransactionId = 3,
                        Merchant = 3,
                        Sum = 300,
                        AccountCode = 1
                    }
                    );
            }

            context.SaveChanges();
        }
    }
}
