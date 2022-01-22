using Business.DTO.RequestModel.TransactionRequestModel;
using Business.DTO.ResponseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Services
{
    public interface ITransactionService
    {
        Response GetTransaction(GetTransactionRequestModel request);
        Response CreateTransaction(CreateTransactionRequestModel request);
    }
}
