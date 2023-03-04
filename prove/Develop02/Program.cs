using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        int action = 0;
        Console.WriteLine("Welcome to the Journal");
        
        Journal journal = new Journal();
        PromptGenerator jp = new PromptGenerator();

        while (action != 5)
        {
            action = Choices();
            switch (action)
            {
                case 1:
                    string dateInfo = GetDateTime();
                    string prompt = jp.GetPrompt();

                    Entry entry = new Entry();
                    entry._dateTime = dateInfo;
                    entry._journalPrompt = prompt;

                    Console.Write($"{prompt}\n");
                    Console.Write(">");
                    string userEntry = Console.ReadLine();
                    entry._journalEntry = userEntry;
                    journal._journal.Add(entry);
                    break;
                case 2:
                    journal.Display();
                    break;
                case 3:
                    journal.LoadJournalFile();
                    break;
                case 4:
                    journal.CreateJournalFile();
                    break;
                case 5:
                    Console.WriteLine("\nThank you for using the Journal App!\n");
                    break;
            }
        }
    }

    static int Choices()
    {
        string options = (@$"Please select one of the following choices:
        1. Write
        2. Display
        3. Load
        4. Save
        5. Quit
        What would you like to do? ");

        Console.Write(options);
        string userInput = Console.ReadLine();
        int action = 0;
        try
        {
            action = int.Parse(userInput);
        }
        catch (FormatException)
        {
            action = 0;
        }
        catch (Exception exception)
        {
            Console.WriteLine(
                $"Error:  {exception.Message}");
        }
        return action;
    }

    static string GetDateTime()
    {
        DateTime now = DateTime.Now;
        string currentDateTime = now.ToString();
        return currentDateTime;
    }
    static void AddJournalEntry()
    {
        string JournalFile = "journal.txt";
        File.AppendAllText(JournalFile, "");
    }

    static string GetEntryId()
    {
        Guid entryuuid = Guid.NewGuid();
        string entryuuidAsString = entryuuid.ToString();
        return entryuuidAsString;
    }
}