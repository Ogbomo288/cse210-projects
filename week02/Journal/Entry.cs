public class Entry
{
    public string _date;
    public string _promptText;
    // What will be displayed
    public string _entryText;
    // What the user will type

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}");
        Console.WriteLine("");

    }
}