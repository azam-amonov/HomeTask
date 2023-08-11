namespace HomeWork_23.N21_HT1;

public class CustomList<T>
{
    private readonly T[] _myList;
    private int _index;

    public CustomList()
    {
        _myList = new T[2];
    }

    public void Add(T item)
    {
        _myList[_index++] = item;
    }

    public void AddRange(params T[] items)
    {
        foreach (var i in items)
        {
            _myList[_index++] = i;
        }
    }

    public bool Contains(T item)
    {
       return _myList.Any(i => i is not null && i.Equals(item));
    }
}