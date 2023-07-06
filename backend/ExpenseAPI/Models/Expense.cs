namespace ExpenseAPI.Models;

public class Expense
{
    private string title { get; set; }
    private int price { get; set; }
    public string? description { get; set; }
    public int uuId { get; set; }
    public DateTime date { get; set; }

}
