using System.Text.Json;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {

        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        Console.WriteLine($"Displaying {_entries.Count} journal entries");
        Console.WriteLine("");
        foreach (Entry entryInList in _entries)
        {
            entryInList.Display();
        }

    }
    public void SafeToFile(string file)
    {
        JsonSerializerOptions options = new JsonSerializerOptions()
        {
            IncludeFields = true
        };
        string jsonString = JsonSerializer.Serialize(_entries, options);
        string filePath = file;
        File.WriteAllText(filePath, jsonString);
    }
    public void LoadFromFile(string file)
    {
        string jsonString = File.ReadAllText(file);
        JsonSerializerOptions options = new JsonSerializerOptions()
        {
            IncludeFields = true
        };
        _entries = JsonSerializer.Deserialize<List<Entry>>(jsonString, options);
    }
}