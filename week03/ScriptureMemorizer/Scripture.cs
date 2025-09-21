using System.Dynamic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        // Console.WriteLine(_reference.GetDisplayText() + " " + text);
        List<string> stringList = text.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
        List<Word> wordList = stringList.Select(s => new Word(s)).ToList();
        _words = wordList;
    }
    public void HideRandomWords(int numberToHide)
    {
        Random randomGenerator = new Random();
        List<Word> filteredList = _words.Where(item => !item.IsHidden()).ToList();
        while (filteredList.Count > 0 && numberToHide > 0)
        {
            int magicNumber = randomGenerator.Next(0, filteredList.Count);
            Word wordToHide = filteredList[magicNumber];
            wordToHide.Hide();
            filteredList.Remove(wordToHide);
            numberToHide--;
        }
    }
    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + " -";
        // Console.WriteLine(_reference.GetDisplayText());
        foreach (Word word in _words)
        {
            displayText += " " + word.GetDisplayText();
        }

        return displayText;
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
