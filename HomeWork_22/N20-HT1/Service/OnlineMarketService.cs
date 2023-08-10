namespace HomeWork_22.N20_HT1.Service;

// OnlineMarket servisidan foydalaning
// unda quyidagi konstruktor bo'lsin
// - OnlineMarket ( IPaymentProvider provider ) - bunda provider private readonly fieldga saqlansin
//
// unda quyidagi methodlar bo'lsin
// - Add ( product ) - productlar qatoriga berilgan productni qo'shsin ) 
// - Buy ( name, number, card ) - product lar ichidan berilgan nomdagi produktni berilgan sonda hisoblab, kartadan pul yechishni payment provider orqali amalga oshirsin
//
public class OnlineMarketService
{
    private readonly KapitalUzCard _card;
    private readonly List<Product> _productsList;
    private readonly UzumPaymentProvider _uzumPaymentProvider;
    private readonly PaymePaymentProvider _paymePaymentProvider;


    public OnlineMarketService(IPaymentProvider provider)
    {
        _productsList = new List<Product>();

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
        var sumOfProduct = _productsList.FirstOrDefault(n => n.Name == nameOfProduct).Price * countOfProduct;
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


