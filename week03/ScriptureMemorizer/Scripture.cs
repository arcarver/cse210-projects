using System.Dynamic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
    }
    public void HideRandomWords(int numberToHide)
    {

    }
    public string GetDisplayText()
    {
        string displayText = "";
        foreach (Word word in _words)
        {
            if (displayText.Length == 0)
            {
                displayText += word.GetDisplayText();
            }
            else
            {
                displayText += " " + word.GetDisplayText();
            }
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
