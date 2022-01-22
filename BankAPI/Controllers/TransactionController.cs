using Data.Models;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BankAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        ITransactionRepository repository;
        public TransactionController(ITransactionRepository repository)
        {
            this.repository = repository;
        }

        [HttpPost]
        public IActionResult createTransaction([FromBody]Transaction transaction)
        {
            // var item = repository.create(transaction);
            //return Ok(item);
            return null;
        }

        [HttpGet("{transactionId}")]
        public IActionResult getAccount(long transactionId)
        {
            var account = repository.getById(transactionId);
            return Ok(account);
        }
    }
}