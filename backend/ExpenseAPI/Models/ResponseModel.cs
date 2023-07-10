using System.Net;

namespace ExpenseAPI.Models;

public class ResponseModel
{
    public HttpStatusCode Status { get; set; }

    public object Data { get; set; }

    public ResponseModel(HttpStatusCode status, object data)
    {
        Status = status;
        Data = data;
    }
}