using BankAPI.Security;
using Business.DTO.RequestModel.AccountRequestModel;
using Business.Services;
using Data.Models;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BankAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[ApiAuthKey]  // We can use this attribute or middleware
    public class AccountController : ControllerBase
    {
        IAccountService _accountService;
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [Route("createAccount/")]
        [HttpPost]
        public IActionResult CreateAccount([FromQuery]CreateAccountRequestModel accountModel)
        {
            var response = _accountService.CreateAccount(accountModel);
            
            if(response.Result==1)
            {
                return Ok(response);
            }

            return BadRequest(response);
        }

        [Route("getAccount/")]
        [HttpGet]
        public IActionResult GetAccount([FromQuery]GetAccountRequestModel request)
        {
            try
            {
                var account = _accountService.GetAccount(request);
                return Ok(account);
            }
            catch
            {
                return Ok("result=-1");
            }
        }


    }
}