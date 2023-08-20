namespace HomeTask_27_C25.N25_HT1.Sevice;

public class OrderService: IOrderService
{
    private readonly ProductService _productService;
    private readonly PaymentService _paymentService;

    public OrderService(ProductService productService, PaymentService paymentService)
    {
        _productService = productService;
        _paymentService = paymentService;
    }

    public bool Order(int orderId, DebitCard debitCard)
    {
        var product = _productService.Order(orderId);
        if (_paymentService.CheckOut(product.Price, debitCard))
            return true;
        return false;
    }

    public bool Order(ProductFilterDataModel filterModel, DebitCard debitCard)
    {
        var products = _productService.Get(filterModel);
        var total = products.Sum(p => p.Price);
        if(_paymentService.CheckOut(total, debitCard))
            return true;
        return false;
    }
}