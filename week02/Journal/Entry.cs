public class Entry
{
    public DateTime _date;
    public string _promptTest;
    public string _entryTest;

    public Entry(string prompt, string response, DateTime date)
    {
        _promptTest = prompt;
        _entryTest = response;
        _date = date;
    }


    public void Display()
    {
        // Console.WriteLine($"Date: {_date.ToShortDateString()}");
        // Console.WriteLine($"Prompt: {_promptTest}");
        // Console.WriteLine($"Entry: {_entryTest}");

        Console.WriteLine($"Date: {_date}\nPrompts: {_promptTest}\nEntry text: {_entryTest}.");
    }
}