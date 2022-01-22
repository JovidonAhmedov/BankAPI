using Business.DTO.RequestModel.AccountRequestModel;
using Business.DTO.ResponseModel;
using Business.DTO.ResponseModel.AccountResponseModel;
using Business.Mapper;
using Data.Models;
using Data.Repository;
using System;

namespace Business.Services
{
    public class AccountService:IAccountService
    {
        private IAccountRepository repository;
        public AccountService(IAccountRepository repository)
        {
            this.repository = repository;
        }

        public Response getAccount(GetAccountRequestModel request)
        {
            Account account=null;
            Response response;            
            
            if (request.msisdn!=null&& request.msisdn!=0)
            {
                account=repository.getBymsisdn(request.msisdn);
            }
            else if(request.accountCode != null&& request.accountCode!=0)
            {
                account=repository.getByaccountCode(request.accountCode);
            }
            

            if (account != null)
            {
                response = AccountMapper.AccountGetSuccessReponseModel(account);
            }
            else if(account is null)
            {
               response = AccountMapper.AccountGetNotFoundReponseModel(account);
            }
            else
            {
               response = AccountMapper.AccountGetErrorReponseModel(account);
            }
                
            return response;
        }

        public Response createAccount(CreateAccountRequestModel request)
        {
            Account account =null;
            Response response=null;
            
            try
            {
                if (request.msisdn<0)
                {
                    response = AccountMapper.CreateIncorrectValueMsisdnResponse(request.msisdn);
                    return response;
                }
                if (request.msisdn == 0)
                {
                    response = AccountMapper.CreateZeroMsisdnResponse(request.msisdn);
                    return response;
                }

                var result = repository.getBymsisdn(request.msisdn);

                if(result!=null)
                {
                    response = AccountMapper.CreateDublicationResponse(request.msisdn);
                    return response;
                }    
                account = repository.create(AccountMapper.CreateReponseModelToAccount(request));
            }
            catch(Exception e)
            {
                response = AccountMapper.CreateDbExceptionResponse(e.Message);
                return response;
            }

            response = AccountMapper.AccountCreateSuccessReponseModel(account);
            
            return response;
        }
    }
}
