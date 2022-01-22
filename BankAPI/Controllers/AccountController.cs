using Business.DTO.RequestModel.AccountRequestModel;
using Business.Services;
using Data.Models;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BankAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        IAccountService _accountService;
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost]
        public IActionResult CreateAccount([FromQuery]CreateAccountRequestModel accountModel)
        {
            var response = _accountService.createAccount(accountModel);
            
            if(response.Result==1)
            {
                return Ok(response);
            }

            return BadRequest(response);
        }

        [HttpGet]
        public IActionResult GetAccount([FromQuery]GetAccountRequestModel request)
        {
            var account= _accountService.getAccount(request);
            return Ok(account);
        }


    }
}