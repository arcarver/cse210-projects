using System.IO;
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
        foreach (Entry entryInList in _entries)
        {
            entryInList.Display();
        }

    }
    public void SafeToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries) {
                outputFile.WriteLine($"{entry._date}$|${entry._entryText}$|${entry._promptText}");
            }
        }
    }
    public void LoadFromFile(string file)
    {
        string filename = file;
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("$|$");

            string date = parts[0];
            string entryText = parts[1];
            string promptText = parts[2];
            Entry entryFromFile = new Entry()
            {
                _date = date,
                _entryText = entryText,
                _promptText = promptText
            };
            _entries.Add(entryFromFile);
        }
    }

}