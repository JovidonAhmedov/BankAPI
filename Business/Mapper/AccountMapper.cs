using Business.DTO.RequestModel.AccountRequestModel;
using Business.DTO.RequestModel.TransactionRequestModel;
using Business.DTO.ResponseModel;
using Business.DTO.ResponseModel.AccountResponseModel;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Mapper
{
    public  static class AccountMapper
    {
        internal static GetAccountResponseModel GetSuccessReponseModel(Account account)
        {
            var accountDto = new GetAccountResponseModel()
            {
                msisdn=account.Msisdn,
                accountCode = account.AccountCode,
                balance = account.Balance,
                name = account.Name,
                surname = account.Surname,
                identification = account.Identification,
                Result = 1,
                Message = "ok"
            };
            return accountDto;
        }

        internal static Response GetIncorrectValueMsisdnAccountCodeResponse()
        {
            var accountDto = new GetErrorResponseModel()
            {
                Result = 0,
                Message = "Incorrect Value Msisdn or AccountCode."
            };
            return accountDto;
        }

        internal static Response CreateNotExistResponse(long accountCode)
        {
            var response = new GetErrorResponseModel()
            {
                Result = 0,
                Message = $"Account with AccountCode={accountCode} does not exist."
            };


            return response;
        }

        internal static GetErrorResponseModel GetErrorReponseModel(Account account)
        {
            var response = new GetErrorResponseModel()
            {
                Result = 0,
                Message = "error"
            };
            return response;
        }

        internal static GetErrorResponseModel GetNotFoundReponseModel(Account account)
        {
            var response = new GetErrorResponseModel()
            {
                Result = 0,
                Message = "NotFound"
            };
            return response;
        }

        internal static CreateErrorResponseModel CreateDublicationResponse(long msisdn)
        {
            var response = new CreateErrorResponseModel()
            {
                Result = 4,
                Message = $"Account with {msisdn} already exists"
            };

            return response;
        }

        internal static CreateErrorResponseModel CreateIncorrectValueMsisdnResponse(long msisdn)
        {
            var response = new CreateErrorResponseModel()
            {
                Result = 0,
                Message = $"Incorrect value of msisdn"
            };

            return response;
        }

        internal static CreateErrorResponseModel CreateZeroMsisdnResponse(long msisdn)
        {
            var response = new CreateErrorResponseModel()
            {
                Result = 0,
                Message = $"Msisdn does not exist"
            };

            return response;
        }

        internal static CreateErrorResponseModel CreateDbExceptionResponse(string message)
        {
            var response=new CreateErrorResponseModel()
            {
                Result = 0,
                Message = message
            };
            return response;
        }

        internal static CreateAccountResponseModel CreateSuccessReponseModel(Account account)
        {
            var response = new CreateAccountResponseModel
            {
                accountCode = account.AccountCode,
                
                Result = 1,
                Message = "ok"
            };
            return response;
        }

        internal static CreateAccountResponseModel CreateErrorReponseModel(Account account)
        {
            CreateAccountResponseModel accountDto = new CreateAccountResponseModel
            {
                Result = 0,
                Message = "error"
            };
            return accountDto;
        }

        internal static Account CreateReponseModelToAccount(CreateAccountRequestModel request)
        {
            Account account = new Account
            {
                Msisdn = request.msisdn,
                Name = request.name,
                Surname = request.surname,
            };
            return account;
        }
    }
}
