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

        public Response GetAccount(GetAccountRequestModel request)
        {
            Account account=null;
            Response response;            
            
            // validation
            if (request.msisdn!=null&& request.msisdn!=0)
            {
                account=repository.GetByMsisdn(request.msisdn);
            }
            else if(request.accountCode != null&& request.accountCode!=0)
            {
                account=repository.GetByAccountCode(request.accountCode);
            }

            // if account with msisdn or accountCode exist in database
            if (account != null)
            {
                response = AccountMapper.GetSuccessReponseModel(account);
            }
            else if(account is null)
            {
               response = AccountMapper.GetNotFoundReponseModel(account);
            }
            else
            {
               response = AccountMapper.GetErrorReponseModel(account);
            }
                
            return response;
        }

        public Response CreateAccount(CreateAccountRequestModel request)
        {
            Account account =null;
            Response response=null;
            
            try
            {               
                if (request.msisdn == 0)
                {
                    response = AccountMapper.CreateZeroMsisdnResponse(request.msisdn);
                    return response;
                }

                var result = repository.GetByMsisdn(request.msisdn);

                if(result!=null)
                {
                    response = AccountMapper.CreateDublicationResponse(request.msisdn);
                    return response;
                }    
                account = repository.Create(AccountMapper.CreateReponseModelToAccount(request));
            }
            catch(Exception e)
            {   
                response = AccountMapper.CreateDbExceptionResponse(e.Message);
                return response;
            }

            response = AccountMapper.CreateSuccessReponseModel(account);
            
            return response;
        }
    }
}
