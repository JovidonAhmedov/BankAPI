using Business.DTO.RequestModel.AccountRequestModel;
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
        internal static GetAccountResponseModel AccountGetSuccessReponseModel(Account account)
        {
            var accountDto = new GetAccountResponseModel()
            {
                accountCode = account.accountCode,
                balance = account.balance,
                name = account.name,
                surname = account.surname,
                identification = account.identification,
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

        internal static GetErrorResponseModel AccountGetErrorReponseModel(Account account)
        {
            var accountDto = new GetErrorResponseModel()
            {
                Result = 0,
                Message = "error"
            };
            return accountDto;
        }

        internal static GetErrorResponseModel AccountGetNotFoundReponseModel(Account account)
        {
            var accountDto = new GetErrorResponseModel()
            {
                Result = 0,
                Message = "NotFound"
            };
            return accountDto;
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

        internal static CreateAccountResponseModel AccountCreateSuccessReponseModel(Account account)
        {
            CreateAccountResponseModel accountDto = new CreateAccountResponseModel
            {
                accountCode = account.accountCode,
                
                Result = 1,
                Message = "ok"
            };
            return accountDto;
        }

        internal static CreateAccountResponseModel AccountCreateErrorReponseModel(Account account)
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
                msisdn = request.msisdn,
                name = request.name,
                surname = request.surname,
            };
            return account;
        }
    }
}
