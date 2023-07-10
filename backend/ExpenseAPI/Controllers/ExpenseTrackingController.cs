using System.Net;
using Microsoft.AspNetCore.Mvc;
using ExpenseAPI.Models;

namespace ExpenseAPI.Controllers;

[ApiController]
[Route("[controller]/")]
public class ExpenseTrackingController : ControllerBase
{
    public static List<ExpenseModel> dummyExpenses { get; set; } = new()
    {
        new ExpenseModel("Dummy expense",123.99,"a dummy description"),
        new ExpenseModel("Another dummy expense", 16.99, "THis is the second dummy description"),
    };
    
    [HttpPost]
    [Route("AddExpense")]
    public ActionResult<ExpenseModel> AddExpense(ExpenseModel model)
    {
        dummyExpenses.Add(model);
        return Ok(model);
    }
    
    [HttpGet]
    [Route("GetAllExpenses")]
    public ResponseModel GetExpenses()
    {
        return new ResponseModel(HttpStatusCode.Accepted,dummyExpenses);
    }
    




}