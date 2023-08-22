namespace HomeWork_31_C28.N28_HT1;

public interface IEvent
{
    Guid Id { get; set; }
    string Name { get; set; }
    DateTime Date { get; set; }
}