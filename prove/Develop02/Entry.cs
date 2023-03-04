using System;

public class Entry
{
    public string _dateTime = "";
    public string _journalPrompt = "";
    public string _journalEntry = "";
    public string _journalFile = "";

    public void Display()
    {
        Console.WriteLine($"Date: {_dateTime}");
        Console.WriteLine($"Prompt: {_journalPrompt}");
        Console.WriteLine($"Entry: {_journalEntry}");
    }

}