
using Business.DTO.RequestModel.AccountRequestModel;
using Business.DTO.ResponseModel.AccountResponseModel;
using Data.Models;
using Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Services
{
    public class AccountService
    {
        private IRepository<Account> repository;
        public AccountService(IRepository<Account> repository)
        {
            this.repository = repository;
        }

        public GetAccountResponseModel getAccount(GetAccountRequestModel request)
        {
            return null;
        }
    }
}
