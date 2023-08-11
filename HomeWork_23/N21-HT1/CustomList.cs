namespace HomeWork_23.N21_HT1;

public class CustomList<T>
{
    private T[] _items = new T[2];
    private long _index;


    public void Add(T item)
    {
        EnsureCapacity();
        _items[_index++] = item;
    }

    public void AddRange(IEnumerable<T> items)
    {
        EnsureCapacity((uint)items.Count());
        
        foreach (var item in items)
            _items[_index++] = item;
    }

    public bool Contains(T item)
    {
        foreach (var i in _items) 
            return i.Equals(item);
        
        return false;
    }

    public int IndexOf(T item)
    {
        for (int i = 0; i < _items.Length; i++)
        {
            if(item.Equals(_items[i]))
                 return i;
        }
        return -1;
    }

    public void Insert(uint pos, T item)
    {
        EnsureCapacity();
        
        var newArray = new T[_items.Length + 1];
        
        for (int i = 0; i < _items.Length + 1; i++)
        {
            if (i < pos - 1)
                newArray[i] = _items[i];
            else if (i == pos - 1)
                newArray[i] = item;
            else
                newArray[i] = _items[i + 1];
        }
        _items = newArray;
    }

    public void InsertRange(uint pos, T[] items)
    {
        foreach (var item in items)
        {
            Insert(pos++, item);
        }
    }

    public bool Remove(T item)
    {
        var resList = new T[_index - 1];
        for (int i = 0; i < _items.Length; i++)
        {
            
        }
        return false;
    }

    public void RemoveAt(uint pos)
    {
           
    }

    private void EnsureCapacity(uint additionalCapacity = 1)
    {
        if(_index + additionalCapacity > _items.Length) return;

        var newCapacity = GetNextSize((uint)_index + additionalCapacity);
        var newArray = new T[newCapacity];
        
        Array.Copy(_items, newArray, _items.Length);
        _items = newArray;
    }

    private uint GetNextSize(in uint desiredItemSize)
    {
        var newCapacity = desiredItemSize;
        do
        {
            newCapacity *= 2;
        }while (newCapacity > desiredItemSize);
        
        return newCapacity;
    }
    
}