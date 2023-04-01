using System;
using System.IO;

public class ControlEvent

{
    private List<Event> _events = new List<Event>();
    private int _totalPoints;

    public ControlEvent()
    {
        _totalPoints = 0;
    }
    public List<Event> GetEventsList()
    {
        return _events;
    }
    public void ListEvents()
    {
    
    }
    public void RecordGEvent()
    {
        ListEvents();
        Console.Write("\nWhich event did you accomplished?  ");
        int select = int.Parse(Console.ReadLine())-1;
        GetEventsList()[select].RecordGEvent(_events);
    }
    public void SaveEvents()
    {
        Console.Write("\nWhat is the name for this event file?  ");
        string userInput = Console.ReadLine();
        string userFileName = userInput + ".txt";
    }

    public void LoadEvents()
    {
        Console.Write("\nWhat is the name of your event file?  ");
        string userInput = Console.ReadLine();
        string userFileName = userInput + ".txt";

        if (File.Exists(userFileName))
        {
            string[] readText = File.ReadAllLines(userFileName);
            readText = readText.Skip(1).ToArray();
            foreach (string line in readText)
            {
                string[] entries = line.Split("; ");

                string type = entries[0];
                string name = entries[1];
                string description = entries[2];
                bool status = Convert.ToBoolean(entries[3]);

                if (entries[0] == "Church Event:")
                {
                    ChurchEvent chEvent = new ChurchEvent(type, name, description, status);
                    // AddEvent(chEvent);
                }
                if (entries[0] == "Family Event:")
                {
                    FamilyEvent fEvent = new FamilyEvent(type, name, description, status);
                    // AddEvent(fEvent);
                }
                 if (entries[0] == "Work Event:")
                {
                    WorkEvent wEvent = new WorkEvent(type, name, description, status);
                    // AddEvent(wEvent);
                }
                 if (entries[0] == "Hobby Event:")
                {
                    HobbyEvent hEvent = new HobbyEvent(type, name, description, status);
                    // AddEvent(hEvent);
                }
                 if (entries[0] == "Other Event:")
                {
                    OtherEvent oEvent = new OtherEvent(type, name, description, status);
                    // AddEvent(oEvent);
                }
                if (entries[0] == "Check List Event:")
                {
                    int numberTimes = int.Parse(entries[4]);
                    int counter = int.Parse(entries[5]);
                    ChecklistEvent clEvent = new ChecklistEvent(type, name, description, status, counter);
                    // AddEvent(clEvent);
                }
            }
        }
    }
}