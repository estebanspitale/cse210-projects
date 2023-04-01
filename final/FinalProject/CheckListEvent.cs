using System;

public class ChecklistEvent : Event
{
    private string _type = "Check List Event:";
    private bool _status;
    private int _count;

    public ChecklistEvent(string type, string name, string description) : base(type, name, description)
    {
        _status = false;
        _count = 0;
    }
    public ChecklistEvent(string type, string name, string description, bool status, int count) : base(type, name, description)
    {
        _status = status;
        _count = count;
    }
     public int GetCount()
    {
        return _count;
    }
    public void SetCount()
    {

    }
    public Boolean Finished()
    {
        return _status;
    }

    public override void ListEvent(int i)
    {
        if (Finished() == false)
        {
            Console.WriteLine($"{i}. [ ] {GetName()} ({GetDescription()})  --  Currently Completed: {GetCount()}");
        }
        else if (Finished() == true)
        {
            Console.WriteLine($"{i}. [X] {GetName()} ({GetDescription()})  --  Completed: {GetCount()}");
        }

    }
    public override string SaveEvent()
    {
        return ($"{_type}; {GetName()}; {GetDescription()}; {_status}; {GetCount()}");
    }
    public override string LoadEvent()
    {
        return ($"Church Event:; {GetName()}; {GetDescription()}; {_status}; {GetCount()}");
    }
    public override void RecordGEvent(List<Event> events)
    {
           _status = true;
    }
}