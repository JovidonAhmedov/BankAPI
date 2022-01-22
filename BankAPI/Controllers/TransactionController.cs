using Business.DTO.RequestModel.TransactionRequestModel;
using Business.Services;
using Data.Models;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BankAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        ITransactionService _transactionService;
        public TransactionController(ITransactionService transactionService)
        {
            _transactionService=transactionService;
        }

        [HttpPost]
        public IActionResult CreateTransaction([FromQuery]CreateTransactionRequestModel transactionModel)
        {
            var response = _transactionService.CreateTransaction(transactionModel);

            if (response.Result == 1)
            {
                return Ok(response);
            }

            return BadRequest(response);
        }

        [HttpGet]
        public IActionResult GetAccount([FromQuery]GetTransactionRequestModel request)
        {
            var account = _transactionService.GetTransaction(request);
            return Ok(account);
        }

    }
}