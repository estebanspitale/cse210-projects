using System;

public class MainMenu
{
    private string _menu = $@"
        Main Menu Options
        Select one option:

        1. Create New Event
        2. List Events
        3. Save Events
        4. Load Events
        5. Record Event
        6. Quit

        >>>:  ";

    public string _userInput;
    private int _userChoice = 0;

    public int UserChoice()
    {
        Console.Write(_menu);
        _userInput = Console.ReadLine();
        _userChoice = 0;
        try
        {
            _userChoice = int.Parse(_userInput);
        }
        catch (FormatException)
        {
            _userChoice = 0;
        }
        catch (Exception exception)
        {
            Console.WriteLine(
                $"Unexpected error:  {exception.Message}");
        }
        return _userChoice;
    }
}
public class EventMenu
{
    private string _menu = $@"
    The Types of Events are:

    1. Church Event
    2. Family Event
    3. Work Event
    4. Hobby Event
    5. Other Event
    6. Checklist Event
    7. Back to Main Menu

    What type of event would you like to create?  ";

    public string _eventInput;
    private int _eventChoice = 0;

    public int EventChoice()
    {
        Console.Write(_menu);
        _eventInput = Console.ReadLine();
        _eventChoice = 0;
        try
        {
            _eventChoice = int.Parse(_eventInput);
        }
        catch (FormatException)
        {
            _eventChoice = 0;
        }
        catch (Exception exception)
        {
            Console.WriteLine(
                $"Unexpected error:  {exception.Message}");
        }
        return _eventChoice;
    }
}