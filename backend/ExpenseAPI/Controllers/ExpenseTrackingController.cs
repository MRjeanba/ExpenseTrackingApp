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
    
    // Create
    [HttpPost]
    [Route("AddExpense")]
    public ActionResult<ExpenseModel> AddExpense(ExpenseModelDto model)
    {
        ExpenseModel newModel = new ExpenseModel(model.title, model.price, model.description);
        dummyExpenses.Add(newModel);
        return Ok(model);
    }
    
    // Read
    [HttpGet]
    [Route("GetAllExpenses")]
    public ResponseModel GetExpenses()
    {
        return new ResponseModel(HttpStatusCode.Accepted,dummyExpenses);
    }

    // Update
    [HttpPut]
    [Route("UpdateExpense/{id}")]
    public ResponseModel UpdateExpense(ExpenseModelDto updatedModel, Guid id)
    {
        ExpenseModel update = dummyExpenses.First(model => model.GetId() == id);

        if (update != null)
        {
            update.description = updatedModel.description;
            update.title = updatedModel.title;
            update.price = updatedModel.price;
        }

        
        return new ResponseModel(HttpStatusCode.Accepted,dummyExpenses);
    }

}