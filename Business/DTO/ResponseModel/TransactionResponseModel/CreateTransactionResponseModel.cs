using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DTO.ResponseModel.TransactionResponseModel
{
    public class CreateTransactionResponseModel : Response
    {
        public override int Result { get; set; }
        public override string Message { get; set; }
        public long paymentId { get; set; }
    }
}
