using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repository
{
    public class MerchantRepository: IMerchantRepository
    {
        private readonly BankDbContext db;
        public MerchantRepository(BankDbContext db)
        {
            this.db = db;
        }
        public Merchant GetById(long id) 
        {
            try
            {
                var merchant = db.Merchants.FirstOrDefault(m => m.id == id);
                return merchant;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        
    }

}
