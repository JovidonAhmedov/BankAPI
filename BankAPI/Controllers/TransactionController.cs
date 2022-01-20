using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Models;
using Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        IRepository<Transaction> repository;
        public TransactionController(IRepository<Transaction> repository)
        {
            this.repository = repository;
        }

        [HttpPost]
        public IActionResult createTransaction([FromBody]Transaction transaction)
        {
            var item = repository.create(transaction);
            return Ok(item);
        }

        [HttpGet("{transactionId}")]
        public IActionResult getAccount(long transactionId)
        {
            var account = repository.get(transactionId);
            return Ok(account);
        }
    }
}