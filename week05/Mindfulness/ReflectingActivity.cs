public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity(string name, string description, List<string> prompts, List<string> questions) : base(name, description)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("\n");
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("\n");
        DisplayPrompt();
        Console.WriteLine("\n");
        Console.WriteLine("When you have something in mind, press any key to continue.");
        Console.ReadLine();
        Console.WriteLine("\n");
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.WriteLine("You may begin in: ");
        ShowCountdown(5);

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            DisplayQuestions();
            ShowSpinner(5);
        }
        
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"--> {GetRandomPrompt()} <--");
    }

    public void DisplayQuestions()
    {
        Console.WriteLine($"> {GetRandomQuestion()}");
        ShowSpinner(5);
    }
}