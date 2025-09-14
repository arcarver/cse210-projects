public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine("Here is my journal entry!");
        Console.WriteLine($"Date is: {_date} ");
        Console.WriteLine($"Writing prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
    }
}