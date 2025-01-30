using System.ComponentModel.DataAnnotations;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"\nDate: {_date} - Prompt: {_promptText}\n{_entryText}");
    }
}