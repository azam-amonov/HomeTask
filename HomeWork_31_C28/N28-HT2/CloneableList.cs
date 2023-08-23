namespace HomeWork_31_C28.N28_HT2;

public class CloneableList<T> : List<T>, ICloneable where T : ICloneable
{
    private List<T> _cloneables;

    public CloneableList()
    {
        _cloneables = new List<T>();
    }
    public object Clone()
    {
       CloneableList<T> clone = new CloneableList<T>();
       foreach (T obj in this)
       {
           clone.Add((T)obj.Clone());
       }
       return clone;
    }
}