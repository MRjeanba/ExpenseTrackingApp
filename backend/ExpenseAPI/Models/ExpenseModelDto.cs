namespace ExpenseAPI.Models;

public class ExpenseModelDto
{
    public string title { get; set; }
    public double price { get; set; }
    public string? description { get; set; }
}