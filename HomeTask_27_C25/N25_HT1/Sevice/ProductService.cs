using System.Runtime.InteropServices.ComTypes;

namespace HomeTask_27_C25.N25_HT1.Sevice;

public class ProductService : IProductService
{

    public List<IProduct> Inventory { get; }

    
    public ProductService()
    {
        Inventory = new List<IProduct>();
    }


    public void Add(IProduct product)
    {
        Inventory.Add(product);
    }

    public ProductFilterDataModel GetFilterData()
    {
        return new ProductFilterDataModel(Inventory);
    }

    public List<IProduct> Get(ProductFilterDataModel filterModel)
    {
        var filter = Inventory.Where(item =>
                        filterModel.ProductTypes.Contains(item.GetType().FullName)).ToList();
        var result = new List<IProduct>(filter);
        return result;
    }

    public IProduct Order(int productId)
    {
        var product = Inventory.FirstOrDefault(item => item.Id == productId);
        if (product is not null)
            product.IsOrdered = true;
        else
            throw new Exception("Product not found!");
        
        return product;
    }

    public IProduct Return(int productId)
    {
        var product = Inventory.FirstOrDefault(item => item.Id == productId);
        if (product is not null)
            product.IsOrdered = false;
        else
            throw new Exception("Product not found!");
        
        return product;
    }

    public void DisplayProducts()
    {
        foreach (var product in Inventory)
        {
            Console.WriteLine($"Id: {product.Id}\n" +
                              $"Name: {product.Name}\n" +
                              $"IsOrdered: {product.IsOrdered}\n");
        }
    }
}