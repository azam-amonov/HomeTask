namespace HomeWork_25_C23.N23_HT1;

public class ProductService
{
    private List<Product> _productsList;

    public ProductService()
    {
        _productsList = new List<Product>()
        {
            new Product(1, "iPhone", 5, 80),
            new Product(1, "iPhone", 5, 80),
            new Product(2, "Samsung Galaxy", 8, 65),
            new Product(3, "Google Pixel", 6, 75),
            new Product(4, "Sony Xperia", 4, 60),
            new Product(5, "LG G Series", 3, 50),
            new Product(6, "Xiaomi Mi", 7, 70),
            new Product(7, "OnePlus Nord", 9, 85),
            new Product(8, "Huawei P40", 2, 45),
            new Product(9, "Motorola Edge", 4, 55),
            new Product(10, "Nokia 9 PureView", 3, 40),
            new Product(11, "ASUS ZenFone", 6, 65),
            new Product(12, "Lenovo Moto", 5, 60),
                        
        };
    }

    public void Display()
    {
        var orderedByRating = _productsList.OrderBy(x => x.Star).Take(5).ToList();
        foreach (var item in orderedByRating)
        {
            Console.WriteLine(item.Name);
        }
    }
}