public class PromptGenerator
{
    public List<string> _prompts = new List<string>{"Did you do good to someone today?", "What scripture touched your heart?", "Were you able to see the sunset, how did you feel?", "A summary of your day.", "Did you have an impression from the Holy Spirit?"};

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(_prompts.Count);
        return _prompts[index].ToString();
    }
}