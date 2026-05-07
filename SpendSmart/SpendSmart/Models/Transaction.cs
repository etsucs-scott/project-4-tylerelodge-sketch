namespace SpendSmart.Models;

public class Transaction
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public decimal Amount { get; set; }

    public string Category { get; set; } = "";

    public DateTime Date { get; set; }

    public string Description { get; set; } = "";

    public string Type { get; set; } = "";
}