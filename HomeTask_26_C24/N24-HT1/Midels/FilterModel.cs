namespace HomeTask_26_C24.N24_HT1;

public abstract class FilterModel
{
    public int? PageSize { get; set; }
    public int? PageToken { get; set; }

    protected FilterModel(int? pageSize, int? pageToken)
    {
        PageSize = pageSize;
        PageToken = pageToken;
    }
}