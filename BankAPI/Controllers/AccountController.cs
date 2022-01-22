using Data.Models;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BankAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        IAccountRepository repository;
        public AccountController(IAccountRepository repository)
        {
            this.repository = repository;
        }

        [HttpPost]
        public IActionResult createAccount([FromBody]Account account)
        {
            var item = repository.create(account);
            return Ok(item);
        }

        [HttpGet("{accountCode}")]
        public IActionResult getAccount(long accountCode)
        {
            var account = repository.getByaccountCode(accountCode);
            return Ok(account);
        }

        //[HttpGet("{msisdn}")]
        //public IActionResult getAccount(long id)
        //{
        //    var account = repository.get(id);
        //    return Ok(account);
        //}

    }
}