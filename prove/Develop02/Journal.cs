using System;
using System.Text.Json;
using System.Text.Json.Serialization;

public class Journal
{

    public List<Entry> _journal = new List<Entry>();
    private string _userFileName;

    public Journal()
    {
    }

    public void Display()
    {
        Console.WriteLine("Journal Entries");
        foreach (Entry journalEntry in _journal)
        {
            journalEntry.Display();
        }
        Console.WriteLine("End");
    }

    public void CreateJournalFile()
    {
        Console.Write("What your file name? ");
        string userInput = Console.ReadLine();
        _userFileName = userInput + ".txt";

        if (!File.Exists(_userFileName))
        {
            File.CreateText(_userFileName);
            Console.Write($" {_userFileName} has been created.");
            SaveJournalFile(_userFileName);
            CreateJSON(userInput);
        }
        else
        {
            Console.Write($"{_userFileName} already exits.");
            Console.Write("Your journal entries have been added.");
            AppendJournalFile(_userFileName);
        }
    }
    public void SaveJournalFile(string _userFileName)
    {
        using (StreamWriter outputFile = new StreamWriter(_userFileName))
        {
            foreach (Entry journalEntry in _journal)
            {
                outputFile.WriteLine($"{journalEntry._dateTime}; {journalEntry._journalPrompt}; {journalEntry._journalEntry}");
            }
        }
    }

    public void AppendJournalFile(string _userFileName)
    {
        using (StreamWriter outputFile = new StreamWriter(_userFileName, append: true))
        {
            foreach (Entry journalEntry in _journal)
            {
                outputFile.WriteLine($"{journalEntry._dateTime}; {journalEntry._journalPrompt}; {journalEntry._journalEntry}");
            }
        }
    }

    public void LoadJournalFile()
    {
        Console.Write("What your file name? ");
        string userInput = Console.ReadLine();
        _userFileName = userInput + ".txt";

        if (File.Exists(_userFileName))
        {
            List<string> readText = File.ReadAllLines(_userFileName).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();
            foreach (string line in readText)
            {
                string[] entries = line.Split("; ");
                Entry entry = new Entry();
                entry._dateTime = entries[1];
                entry._journalPrompt = entries[2];
                entry._journalEntry = entries[3];
                _journal.Add(entry);
            }
        }
    }

    public void CreateJSON(string userInput)
    {
        string fileName = userInput + ".json";
        List<Json> _data = new List<Json>();
        foreach (Entry journalEntry in _journal)
        {
            _data.Add(new Json()
            {
                Date = journalEntry._dateTime,
                Prompt = journalEntry._journalPrompt,
                Entry = journalEntry._journalEntry
            });
        }
        string json = JsonSerializer.Serialize(_data);
        File.WriteAllText(fileName, json);
    }

}