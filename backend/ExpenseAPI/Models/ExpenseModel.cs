namespace ExpenseAPI.Models;

public class ExpenseModel
{
    public string title { get; set; }
    public double price { get; set; }
    public string? description { get; set; }
    private Guid uuId { get; set; }
    public DateTime date { get; set; }
    
    public ExpenseModel(string title, double price, string description)
    {
        this.title = title;
        this.price = price;
        this.description = description;
        uuId = Guid.NewGuid();
        date = DateTime.Now;
    }
    public string GetTitle()
    {
        return this.title;
    }
    public double GetPrice()
    {
        return this.price;
    }
    public string? GetDescription()
    {
        return this.description;
    }
    public Guid GetId()
    {
        return this.uuId;
    }
    public DateTime GetDate()
    {
        return this.date;
    }


}

