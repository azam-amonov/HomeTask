namespace HomeWork_31_C28.N28_HT2;

public class StorageFile: ICloneable
{
    public Guid Id {get; set; }
    public string Name {get; set; }
    public string Description {get; set; }
    public int Size {get; set; }

    public StorageFile(){}
    
    public StorageFile(string name, string description, int size)
    {
        Id = Guid.NewGuid();
        Name = name;
        Description = description;
        Size = size;
    }
    public object Clone()
    {
        return new StorageFile
        {
            Id = this.Id,
            Name = this.Name,
            Description = this.Description,
            Size = this.Size
        };
    }
}