using System;
using System.IO;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        ControlEvent events = new ControlEvent();
        Console.Clear();
        Console.Write("\nWelcome to the Events Program \n");
        MainMenu choice = new MainMenu();
        EventMenu eventChoice = new EventMenu();


        int action = 0;
        while (action != 6)
        {
            action = choice.UserChoice();
            switch (action)
            {
                case 1:
                    Console.Clear();
                    int eventInput = 0;
                    while (eventInput != 7)
                    {
                        eventInput = eventChoice.EventChoice();
                        switch (eventInput)
                        {
                            case 1:
                                Console.WriteLine("What is the name of your event?  ");
                                string name = Console.ReadLine();
                                name = textInfo.ToTitleCase(name);
                                Console.WriteLine("What is a short description of your event?  ");
                                string description = Console.ReadLine();
                                description = textInfo.ToTitleCase(description);
                                ChurchEvent chEvent = new ChurchEvent("Church Event:", name, description);
                                events.AddEvent(chEvent);
                                eventInput = 8;
                                break;
                            case 2:
                                Console.WriteLine("What is the name of your event?  ");
                                name = Console.ReadLine();
                                name = textInfo.ToTitleCase(name);
                                Console.WriteLine("What is a short description of your event?  ");
                                description = Console.ReadLine();
                                description = textInfo.ToTitleCase(description);
                                FamilyEvent fEvent = new FamilyEvent("Family Event:", name, description);
                                events.AddEvent(fEvent);
                                eventInput = 8;
                                break;
                            case 3:
                                Console.WriteLine("What is the name of your event?  ");
                                name = Console.ReadLine();
                                name = textInfo.ToTitleCase(name);
                                Console.WriteLine("What is a short description of your event?  ");
                                description = Console.ReadLine();
                                description = textInfo.ToTitleCase(description);
                                WorkEvent wEvent = new WorkEvent("Work Event:", name, description);
                                events.AddEvent(wEvent);
                                eventInput = 8;
                                break;
                            case 4:
                                Console.WriteLine("What is the name of your event?  ");
                                name = Console.ReadLine();
                                name = textInfo.ToTitleCase(name);
                                Console.WriteLine("What is a short description of your event?  ");
                                description = Console.ReadLine();
                                description = textInfo.ToTitleCase(description);
                                HobbyEvent hEvent = new HobbyEvent("Hobby Event:", name, description);
                                events.AddEvent(hEvent);
                                eventInput = 8;
                                break;
                            case 5:
                                Console.WriteLine("What is the name of your event?  ");
                                name = Console.ReadLine();
                                name = textInfo.ToTitleCase(name);
                                Console.WriteLine("What is a short description of your event?  ");
                                description = Console.ReadLine();
                                description = textInfo.ToTitleCase(description);
                                OtherEvent oEvent = new OtherEvent("Other Event:", name, description);
                                events.AddEvent(oEvent);
                                eventInput = 8;
                                break;
                            case 6:
                                Console.WriteLine("What is the name of your event?  ");
                                name = Console.ReadLine();
                                name = textInfo.ToTitleCase(name);
                                Console.WriteLine("What is a short description of your event?  ");
                                description = Console.ReadLine();
                                description = textInfo.ToTitleCase(description);
                                ChecklistEvent clEvent = new ChecklistEvent("Check List Event:", name, description);
                                events.AddEvent(clEvent);
                                eventInput = 8;
                                break;
                            case 7:
                                break;
                            default:
                                Console.WriteLine($"\nSorry the option you entered is not valid.");
                                break;
                        }
                    }
                    break;
                case 2:
                    Console.Clear();
                    events.ListEvents();
                    break;
                case 3:
                    events.SaveEvents();
                    break;
                case 4:
                    Console.Clear();
                    events.LoadEvents();
                    break;
                case 5:
                    Console.Clear();
                    events.RecordGEvent();
                    break;
                case 6:
                    Console.WriteLine("\nThank you for using The Events Program!\n");
                    break;
                default:
                    Console.WriteLine($"\nSorry the option you entered is not valid.");
                    break;
            }
        }
    }
}