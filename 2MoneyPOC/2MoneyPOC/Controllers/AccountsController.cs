using _2MoneyPOC.Dtos;
using _2MoneyPOC.Persistance;
using _2MoneyPOC.Services;
using Microsoft.AspNetCore.Mvc;

namespace _2MoneyPOC.Controllers;

[ApiController]
[Route("[controller]")]
public class AccountsController(IAccountsService _accountsService) : ControllerBase
{


    //[HttpGet(Name = "GetAccounts")]
    [HttpGet(Name = "")]
    public IEnumerable<GetAccountDTO> GetAccounts()
    {
        return _accountsService.GetAccounts();
    }

    //[HttpPost(Name = "AddAccount")]
    [HttpPost(Name = "")]
    public IEnumerable<Account> AddAccount(Account account)
    {

        return null;
    }
}
