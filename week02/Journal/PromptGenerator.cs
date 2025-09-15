public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public PromptGenerator()
    {
        _prompts.Add("What is something that happened today that had never happened to you before? ");
        _prompts.Add("What is a good thing that happened in the world? ");
        _prompts.Add("What tender mercies did you notice today? ");
        _prompts.Add("What does a normal day look like for you? ");
        _prompts.Add("What is a goal you are working on and what did you do today to get closer to your goal? ");
    }

    public string GetRandomPrompt()
    {
        int selectPrompt = new Random().Next(5);
        
        return (_prompts[selectPrompt]);
    }

}