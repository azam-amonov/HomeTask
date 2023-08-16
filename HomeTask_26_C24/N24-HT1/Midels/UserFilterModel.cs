namespace HomeTask_26_C24.N24_HT1;

public class UserFilterModel: FilterModel
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    
    public UserFilterModel(int? pageSize, int? pageToken,string? firstName, string?
                    lastName) : base(pageSize, pageToken)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}