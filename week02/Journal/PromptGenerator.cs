public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public PromptGenerator()
    {
        _prompts.Add("a");
        _prompts.Add("B");
        _prompts.Add("C");
        _prompts.Add("D");
        _prompts.Add("E");
    }

    public string GetRandomPrompt()
    {
        int selectPrompt = new Random().Next(5);
        
        return (_prompts[selectPrompt]);
    }

}