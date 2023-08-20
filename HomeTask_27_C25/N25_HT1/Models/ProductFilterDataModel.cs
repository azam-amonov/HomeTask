namespace HomeTask_27_C25.N25_HT1;

public class ProductFilterDataModel
{
    public List<string?> ProductTypes { get;}
    
    public ProductFilterDataModel(List<IProduct> productTypes)
    {
        ProductTypes = productTypes.Count == 0 
                        ? new() 
                        : productTypes.Select(item => item.GetType().FullName).Distinct().ToList();
    }
    
    // public override string ToString()
    // {
    //     var fullName = ProductTypes.GetType().FullName;
    //     if (fullName != null)
    //         return $"{fullName
    //                         .Substring(30, fullName.Length)}";
    // }
}