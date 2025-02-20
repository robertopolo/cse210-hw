public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity(string name, string description, List<string> prompts) : base(name, description)
    {
        _prompts = prompts;
    }

    public void Run()
    {
        DisplayStartingMessage();
        _count = GetDuration();
        Console.WriteLine("List as many responses you can to the following prompt:");
        GetRandomPrompt();
        Console.WriteLine("You may begin in: ");
        ShowCountdown(5);
        GetListFromUser();
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine($"--> {_prompts[index]}<--");
    }

    public List<string> GetListFromUser()
    {
        List<string> prompts = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_count);
        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            string prompt = Console.ReadLine();
            prompts.Add(prompt);
        }
        Console.WriteLine($"You listed {prompts.Count} items!");
        return prompts;
    }
}