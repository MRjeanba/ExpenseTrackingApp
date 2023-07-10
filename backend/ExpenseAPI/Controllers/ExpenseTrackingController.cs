using System.Net;
using Microsoft.AspNetCore.Mvc;
using ExpenseAPI.Models;

namespace ExpenseAPI.Controllers;

[ApiController]
[Route("[controller]/")]
public class ExpenseTrackingController : ControllerBase
{
    public List<ExpenseModel> dummyExpenses { get; } = new()
    {
        new ExpenseModel("Dummy expense",123.99,"a dummy description"),
        new ExpenseModel("Another dummy expense", 16.99, "THis is the second dummy description"),
    };

    [HttpGet]
    [Route("GetAllExpenses")]
    public ResponseModel GetExpenses()
    {
        return new ResponseModel(HttpStatusCode.Accepted,dummyExpenses);
    }
    
    [HttpPost]
    [Route("CreateExpense")]
    public IEnumerable<ExpenseModel> AddExpense()
    {
        return dummyExpenses;
    }




}