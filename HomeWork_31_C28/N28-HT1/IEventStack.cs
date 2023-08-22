namespace HomeWork_31_C28.N28_HT1;

public interface IEventStack<TEvent> where TEvent : IEvent 
{
    public void Push(TEvent myEvent);
    public TEvent Peek();
    public TEvent Pop();
}