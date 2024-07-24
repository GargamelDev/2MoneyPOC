using _2MoneyPOC.Services;
using Microsoft.AspNetCore.Mvc;

namespace _2MoneyPOC.Controllers;

[ApiController]
[Route("[controller]")]
public class TransactionsController(ITransactionsService transactionsService) : ControllerBase
{
    [HttpDelete("{id}")]
    public void DeleteTransaction(int id)
    {
        transactionsService.DeleteTransaction(id);
    }
}
