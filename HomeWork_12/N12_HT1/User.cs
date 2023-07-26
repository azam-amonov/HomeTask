namespace HomeWork_12.N12_HT1;

public class User
{
    private string _firstName;
    private string _lastName;
    private string _fullName;

    public string FirstName
    {
        get => _firstName;
        set
        {
            _firstName = value;
            RecalculateFullName();
        }
    }

    public string LastName
    {
        get => _lastName;
        set
        {
            _lastName = value;
            RecalculateFullName();
        }
    }

    private void RecalculateFullName()
    {
        _fullName = $"{FirstName} {LastName}";
    }

    public override bool Equals(object obj)
    {
        if (obj is not User other)
        {
            return false;
        }
        return GetHashCode() == other.GetHashCode();
    }

    public override int GetHashCode()
    {
        return _fullName.GetHashCode();
    }
}