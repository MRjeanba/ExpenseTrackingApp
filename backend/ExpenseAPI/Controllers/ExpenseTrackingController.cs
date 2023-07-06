using Microsoft.AspNetCore.Mvc;

namespace ExpenseAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ExpenseTrackingController : ControllerBase
{

    [HttpGet(Name = "GetExpenses")]
    public IEnumerable<String> Get()
    {
        List<String> expenses = new List<string> 
        {
            "noob","test"
        };
        return expenses;
    }
}