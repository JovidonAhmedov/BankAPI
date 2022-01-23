using BankAPI.Security;
using Business.DTO.RequestModel.TransactionRequestModel;
using Business.Services;
using Data.Models;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BankAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiAuthKey]
    public class TransactionController : ControllerBase
    {
        ITransactionService _transactionService;
        public TransactionController(ITransactionService transactionService)
        {
            _transactionService=transactionService;
        }

        [Route("createTransaction/")]
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

        [Route("checkTransaction/")]
        [HttpGet]
        public IActionResult GetTransaction([FromQuery]GetTransactionRequestModel request)
        {
            var account = _transactionService.GetTransaction(request);
            return Ok(account);
        }

    }
}