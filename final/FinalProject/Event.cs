using System;

public abstract class Event
{
    private string _type;
    private string _name;
    private string _description;

    public Event(string type, string name, string description)
    {
        _type = type;
        _name = name;
        _description = description;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public abstract void ListEvent(int i);
    public abstract string SaveEvent();
    public abstract string LoadEvent();
    public abstract void RecordGEvent(List<Event> events);
}