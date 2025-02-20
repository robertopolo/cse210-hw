public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        int duration = GetDuration();
        
        for (int i = 0; i < duration / 8; i++)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Breathe in...");
            ShowCountdown(4);
            Console.WriteLine("Now breathe out...");
            ShowCountdown(4);
        }

        Console.WriteLine("\n");
        DisplayEndingMessage();
        ShowSpinner(8);
        Console.Clear();
    }
}