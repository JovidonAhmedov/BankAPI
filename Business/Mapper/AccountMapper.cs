using Business.DTO.RequestModel.AccountRequestModel;
using Business.DTO.ResponseModel.AccountResponseModel;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Mapper
{
    public  static class AccountMapper
    {
        public static GetAccountResponseModel AccountGetSuccessReponseModel(Account account)
        {
            GetAccountResponseModel accountDto = new GetAccountResponseModel
            {
                accountCode = account.accountCode,
                balance = account.balance,
                name = account.name,
                surname = account.surname,
                identification = account.identification,
                result = 1,
                message = "ok"
            };
            return accountDto;
        }

        public static GetAccountResponseModel AccountGetErrorReponseModel(Account account)
        {
            GetAccountResponseModel accountDto = new GetAccountResponseModel
            {
                //accountCode = account.accountCode,
                //balance = account.balance,
                //name = account.name,
                //surname = account.surname,
                //identification = account.identification,
                result = 0,
                message = "error"
            };
            return accountDto;
        }

        public static GetAccountResponseModel AccountGetNotFoundReponseModel(Account account)
        {
            GetAccountResponseModel accountDto = new GetAccountResponseModel
            {
                //accountCode = account.accountCode,
                //balance = account.balance,
                //name = account.name,
                //surname = account.surname,
                //identification = account.identification,
                result = 0,
                message = "NotFound"
            };
            return accountDto;
        }
    }
}
