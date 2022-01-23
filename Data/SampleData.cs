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
                        balance = 0,
                        name = "Ali",
                        surname = "Aliev",
                        msisdn = 1,
                        identification = false
                    },
                    new Models.Account
                    {
                        balance = 0,
                        name = "Vali",
                        surname = "Valiev",
                        msisdn = 2,
                        identification = false
                    });
                    
            }

            if (!context.Merchants.Any())
            {
                context.Merchants.AddRange(
                    new Models.Merchant
                    {    
                        name = "Merchant1"         
                    },
                    new Models.Merchant
                    {
                        name = "Merchant2"
                    },
                    new Models.Merchant
                    {
                        name = "Merchant3"
                    });
   
            }

            if (!context.Transactions.Any())
            {
                context.Transactions.AddRange(
                    new Models.Transaction
                    {
                         transactionId=1,
                         merchant=2,
                         sum=200,
                         accountCode=2
                    },
                    new Models.Transaction
                    {
                        transactionId = 2,
                        merchant = 3,
                        sum = 300,
                        accountCode = 2
                    },
                    new Models.Transaction
                    {
                        transactionId = 3,
                        merchant = 3,
                        sum = 300,
                        accountCode = 1
                    }
                    );
            }

            context.SaveChanges();
        }
    }
}
