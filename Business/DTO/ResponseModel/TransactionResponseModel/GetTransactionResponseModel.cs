﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DTO.ResponseModel.TransactionResponseModel
{
    class GetTransactionResponseModel:IResponse
    {
        public int result { get; set; }
        public string message { get; set; }

        public long paymentId { get; set; }
    }
}
