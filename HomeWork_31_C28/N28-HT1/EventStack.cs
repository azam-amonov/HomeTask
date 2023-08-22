namespace HomeWork_31_C28.N28_HT1;

public class EventStack : IEventStack<Event>
{
    List<Event> _events;

    public EventStack()
    {
        _events = new List<Event>();
    }
    
    public void Push(Event myEvent)
    {
        _events.Add(myEvent);
        
        var sortedEvents = _events.OrderByDescending(e => e.Date).ToList();
        _events = sortedEvents;
    }

    public Event Peek()
    {
        var lastEvent = _events.Last();
        
        if(lastEvent is null || _events.Count == 0)
            throw new Exception("Events not found");
        return lastEvent;
    }

    public Event Pop()
    {
        var lastEvent = _events.Last();
        
        if(lastEvent is null)
            throw new Exception("Events not found");
        
        _events.Remove(lastEvent);
        return lastEvent;
    }
}