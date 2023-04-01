using System;

public class WorkEvent : Event
{
    private string _type = "Work Event:";
    private bool _status;

    public WorkEvent(string type, string name, string description) : base(type, name, description)
    {
        _status = false;
    }
    public WorkEvent(string type, string name, string description, bool status) : base(type, name, description)
    {
        _status = status;
    }
    public Boolean Finished()
    {
        return _status;
    }

    public override void ListEvent(int i)
    {
        if (Finished() == false)
        {
            Console.WriteLine($"{i}. [ ] {GetName()} ({GetDescription()})");
        }
        else if (Finished() == true)
        {
            Console.WriteLine($"{i}. [X] {GetName()} ({GetDescription()})");
        }
    }
    public override string SaveEvent()
    {
        return ($"{_type}; {GetName()}; {GetDescription()}; {_status}");
    }
    public override string LoadEvent()
    {
        return ($"{_type}; {GetName()}; {GetDescription()}; {_status}");
    }
    public override void RecordGEvent(List<Event> events)
    {
       _status = true;
    }

}