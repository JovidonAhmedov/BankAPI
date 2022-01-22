using Data.Models;
using Data.Repository;
namespace Business.Services
{
    public class TransactionService
    {
        private ITransactionRepository repository;
        public TransactionService(ITransactionRepository repository)
        {
            this.repository = repository;
        }
    }
}
