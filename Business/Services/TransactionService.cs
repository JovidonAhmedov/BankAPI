using Business.DTO.RequestModel.TransactionRequestModel;
using Business.DTO.ResponseModel;
using Business.Mapper;
using Data.Models;
using Data.Repository;
using System;

namespace Business.Services
{
    public class TransactionService:ITransactionService
    {
        private ITransactionRepository _transactionRepository;
        private IAccountRepository _acountRepository;
        private IMerchantRepository _merchantRepository;
        public TransactionService(ITransactionRepository transactionRepository, IAccountRepository acountRepository, IMerchantRepository merchantRepository)
        {
            _transactionRepository = transactionRepository;
            _acountRepository = acountRepository;
            _merchantRepository = merchantRepository;
        }

        public Response GetTransaction(GetTransactionRequestModel request)
        {
            Transaction transaction = null;
            Response response;

            transaction = _transactionRepository.GetById(request.transactionId);

            
            if (transaction != null)
            {
                response = TransactionMapper.GetSuccessReponseModel(transaction);
            }
            else if (transaction is null)
            {
                response = TransactionMapper.GetNotFoundReponseModel(transaction);
            }
            else
            {
                response = TransactionMapper.GetErrorReponseModel(transaction);
            }

            return response;
        }
        public Response CreateTransaction(CreateTransactionRequestModel request)
        {
            Response response=null;
            Transaction transaction=null;
            try {

                if (request.merchant != 0)
                {
                    var merchant = _merchantRepository.GetById(request.merchant);
                    if(merchant is null)
                    {
                        response = TransactionMapper.CreateNotExistMerchantResponse(request.merchant);
                        return response;
                    }
                }

                if (request.accountCode != 0)
                {
                    var account = _acountRepository.GetByAccountCode(request.accountCode);
                    if (account is null)
                    {
                        response = AccountMapper.CreateNotExistResponse(request.accountCode);
                        return response;
                    }

                    var result = _transactionRepository.GetById(request.transactionId);

                    if (result != null)
                    {
                        response = TransactionMapper.CreateDublicationResponse(request.transactionId);
                        return response;
                    }
                    transaction = _transactionRepository.Create(TransactionMapper.CreateReponseModelToTransaction(request));

                }
            }
            catch(Exception e)
            {
                response = TransactionMapper.CreateDbExceptionResponse(e.Message);
                return response;
            }

            response = TransactionMapper.CreateSuccessReponseModel(transaction);

            return response;
        }
    }
}
