namespace ExpenseAPI.Models;

public class ExpenseModel
{
    private string title { get; set; }
    private int price { get; set; }
    public string? description { get; set; }
    public int uuId { get; set; }
    public DateTime date { get; set; }
    
    public string getTitle()
    {
        return this.title;
    }
    public int getPrice()
    {
        return this.price;
    }
    public string? getDescription()
    {
        return this.description;
    }
    public int getId()
    {
        return this.uuId;
    }
    public DateTime getDate()
    {
        return this.date;
    }


}
