using System;

public class PromptGenerator
{
    public static string[] _prompt = {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "List the places I have been to today.",
        "What frightened you today?",
        "Who do you wish you had talked to today? What would you say?",
        "If you’d had another hour during the day, how would you have spent it?",
        "Did you read a book today? If so what?",
    };
    public List<string> _journalPrompt = new List<string>(_prompt);

    public PromptGenerator()
    {
    }

    public void Display()
    {
        var random = new Random();
        int index = random.Next(_journalPrompt.Count);
        string journalPrompt = _journalPrompt[index];
        Console.WriteLine($"\n{_journalPrompt}");
    }

    public string GetPrompt()
    {
        var random = new Random();
        int index = random.Next(_journalPrompt.Count);
        string journalPrompt = _journalPrompt[index];
        return journalPrompt;
    }
}