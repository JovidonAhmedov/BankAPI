using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DTO.RequestModel.TransactionRequestModel
{
    public class CreateTransactionRequestModel
    { 
        public long accountCode { get; set; }
        public long merchant { get; set; }
        public decimal sum { get; set; }
        public long transactionId { get; set; }
    }
}
