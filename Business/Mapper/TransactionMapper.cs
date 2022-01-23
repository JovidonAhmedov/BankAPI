using Business.DTO.RequestModel.TransactionRequestModel;
using Business.DTO.ResponseModel;
using Business.DTO.ResponseModel.TransactionResponseModel;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Mapper
{
    public static class TransactionMapper
    {
        internal static Transaction CreateReponseModelToTransaction(CreateTransactionRequestModel request)
        {
            Transaction transaction = new Transaction
            {
                TransactionId = request.transactionId,
                AccountCode = request.accountCode,
                Sum = request.sum,
                Merchant = request.merchant

            };

            return transaction;
        }

        internal static Response CreateDbExceptionResponse(string message)
        {
            var response = new ErrorResponseModel()
            {
                Result = 0,
                Message = message
            };
            return response;
        }

        internal static Response CreateDublicationResponse(long transactionId)
        {
            var response = new ErrorResponseModel()
            {
                Result = 2,
                Message = "Dublicate transaction"
            };
            return response;
        }

        internal static Response GetErrorReponseModel(Transaction transaction)
        {
            var response = new ErrorResponseModel()
            {
                Result = 0,
                Message = "Error"
            };

            return response;
        }

        internal static Response GetNotFoundReponseModel(Transaction transaction)
        {
            var response = new ErrorResponseModel()
            {
                Result = 3,
                Message = "Transaction not found."
            };

            return response;
        }

        internal static Response CreateSuccessReponseModel(Transaction transaction)
        {
            var response = new CreateTransactionResponseModel
            {
                paymentId = transaction.PaymentId,
                Result = 1,
                Message = "ok"
            };

            return response;
        }

        internal static Response CreateNotExistMerchantResponse(long merchant)
        {
            var response = new ErrorResponseModel()
            {
                Result = 4,
                Message = "Merchant not found."
            };

            return response;
        }

        internal static GetTransactionResponseModel GetSuccessReponseModel(Transaction transaction)
        {
            var transactionDto = new GetTransactionResponseModel()
            {
                paymentId=transaction.PaymentId,
                Result = 1,
                Message = "ok"
            };

            return transactionDto;
        }
    }
}
