using SpendSmart.Models;

namespace SpendSmart.Services;

public class BudgetManager
{
    private List<Transaction> transactions = new();

    public void AddTransaction(Transaction transaction)
    {
        transactions.Add(transaction);
    }

    public List<Transaction> GetTransactions()
    {
        return transactions;
    }

    public decimal GetBalance()
    {
        decimal expenses = transactions.Sum(t => t.Amount);

        return currentBalance - expenses;
    }

    public void DeleteTransaction(Guid id)
    {
        var transaction = transactions.FirstOrDefault(t => t.Id == id);

        if (transaction != null)
        {
            transactions.Remove(transaction);
        }
    }

    public void Clear()
    {
        transactions.Clear();
    }

    private decimal currentBalance = 0;

    public void SetBalance(decimal amount)
    {
        currentBalance = amount;
    }


}