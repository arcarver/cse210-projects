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

    }
    public void LoadFromFile(string file)
    { 

    }

}