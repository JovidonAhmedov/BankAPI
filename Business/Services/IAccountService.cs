using Business.DTO.RequestModel.AccountRequestModel;
using Business.DTO.ResponseModel;
using Business.DTO.ResponseModel.AccountResponseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Services
{
    public interface IAccountService
    {
        Response getAccount(GetAccountRequestModel request);
        Response createAccount(CreateAccountRequestModel request);
    }
}
