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
    public class AccountController : ControllerBase
    {
        IRepository<Account> repository;
        public AccountController(IRepository<Account> repository)
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
            var account = repository.get(accountCode);
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