using System.Text.Json;
using SpendSmart.Models;

namespace SpendSmart.Services;

public class FileService
{
    private string GetFilePath(string username)
    {
        return $"Data/{username}.json";
    }

    public void SaveData(string username, List<Transaction> transactions)
    {
        try
        {
            Directory.CreateDirectory("Data");

            string path = GetFilePath(username);

            string json = JsonSerializer.Serialize(transactions,
                new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText(path, json);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Save failed: " + ex.Message);
        }
    }

    public List<Transaction> LoadData(string username)
    {
        try
        {
            string path = GetFilePath(username);

            if (!File.Exists(path))
            {
                return new List<Transaction>();
            }

            string json = File.ReadAllText(path);

            return JsonSerializer.Deserialize<List<Transaction>>(json)
                   ?? new List<Transaction>();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Load failed: " + ex.Message);
            return new List<Transaction>();
        }
    }
}