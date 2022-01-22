using Business.DTO.RequestModel.AccountRequestModel;
using Business.DTO.ResponseModel.AccountResponseModel;
using Business.Mapper;
using Data.Models;
using Data.Repository;

namespace Business.Services
{
    public class AccountService
    {
        private IAccountRepository repository;
        public AccountService(IAccountRepository repository)
        {
            this.repository = repository;
        }

        public GetAccountResponseModel getAccount(GetAccountRequestModel request)
        {
            Account account=null;
            GetAccountResponseModel accountDto;
          
            if (request.msisdn!=null)
            {
                account=repository.getBymsisdn(request.msisdn);
            }
            else if(request.accountCode != null)
            {
                account=repository.getByaccountCode(request.accountCode);
            }

            if (account != null)
            {
                accountDto = AccountMapper.AccountGetSuccessReponseModel(account);
            }
            else if(account is null)
            {
                accountDto = AccountMapper.AccountGetNotFoundReponseModel(account);
            }
            else
            {
                accountDto = AccountMapper.AccountGetErrorReponseModel(account);
            }
                
            return accountDto;
        }

        public CreateAccountResponseModel createAccount(CreateAccountRequestModel request)
        {
            CreateAccountResponseModel response=null;
            Account account = new Account
            {
                msisdn = request.msisdn,
                //accountCode=
                name = request.name,
                surname=request.surname,
            };

            var acc=repository.create(account);
            if(acc!=null)
            {
                response = new CreateAccountResponseModel
                {
                    accountCode=acc.accountCode,
                    result=1,
                    message="ok"
                };
            }
            else
            {
                response = new CreateAccountResponseModel
                {
                    result = 0,
                    message = "Error"
                };
            } 
            return response;
        }
    }
}
