namespace ExpenseAPI.Models;

public class ExpenseModel
{
    private string title { get; set; }
    private double price { get; set; }
    public string? description { get; set; }
    public Guid uuId { get; set; }
    public DateTime date { get; set; }
    
    public ExpenseModel(string title, double price, string description)
    {
        this.title = title;
        this.price = price;
        this.description = description;
        this.uuId = Guid.NewGuid();
        this.date = DateTime.Now;
    }
    public string getTitle()
    {
        return this.title;
    }
    public double getPrice()
    {
        return this.price;
    }
    public string? getDescription()
    {
        return this.description;
    }
    public Guid getId()
    {
        return this.uuId;
    }
    public DateTime getDate()
    {
        return this.date;
    }


}
