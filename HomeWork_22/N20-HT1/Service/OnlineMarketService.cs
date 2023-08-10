namespace HomeWork_22.N20_HT1.Service;

public class OnlineMarketService
{
    private List<Product> _productsList;
    private readonly IDebitCard _card;
    private readonly IPaymentProvider _paymentProvider;

    public OnlineMarketService(IDebitCard card, IPaymentProvider provider)
    {
        _card = card;
        _paymentProvider = provider;
        _productsList = new List<Product>();
        Add(new Product {Name = "Fresh", Price = 10});

    }

    public void Add(Product product)
    {
        _productsList.Add(product);
        _productsList.Add(new Product { Name = "Apple", Price = 2.3 });
        _productsList.Add(new Product { Name = "Pineapple", Price = 4.8 });
        _productsList.Add(new Product { Name = "Orange", Price = 3.0 });
        _productsList.Add(new Product { Name = "Watermelon", Price = 5 });
    }

    public void Buy(string nameOfProduct, int countOfProduct, IDebitCard card)
    {
        var sumOfProduct = _productsList.FirstOrDefault(n =>
                        n.Name == nameOfProduct).Price * countOfProduct;
        
        if (sumOfProduct is not 0)
            card.Balance -= (decimal)sumOfProduct;
    }

    public void Display()
    {
        foreach (var product in _productsList)
        {
            Console.WriteLine($"{product.Name}: {product.Price}$");
        }
    }


}


