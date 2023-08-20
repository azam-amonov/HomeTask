// See https://aka.ms/new-console-template for more information

using HomeTask_27_C25.N25_HT1;
using HomeTask_27_C25.N25_HT1.Models;
using HomeTask_27_C25.N25_HT1.Sevice;

Console.WriteLine("Product Service !");
var productService = new ProductService();
var paymentService = new PaymentService();

var debitCard = new DebitCard("8600", 10000000);
var orderService = new OrderService(productService, paymentService);


var laptop = new Laptop(1,"Macbook", "Pro 13 inch", false, 12000m, "AppleSilicon", "M1");
var laptop1 = new Laptop(2,"Macbook", "Pro 13 inch", false, 15000m, "AppleSilicon", "M1 Pro");

var chair = new Chair(3,"HiperX", "", false, 500m,12, "Silk");
var chair1 = new Chair(4,"HiperY", "", false, 700m,12, "Silk");

var monitor = new Manitor (5, "Asus", "", false,800,15, 120);
var monitor2 = new Manitor (6, "Samsung", "", false,1200,23, 180);

productService.Add(laptop);
productService.Add(laptop1);
productService.Add(chair);
productService.Add(chair1);
productService.Add(monitor);
productService.Add(monitor2);

var filterData = productService.GetFilterData();
foreach (var data in filterData.ProductTypes)
{
    var typeName = Type.GetType(data).Name;
    Console.WriteLine(typeName);
}

productService.DisplayProducts();
orderService.Order(2, debitCard);
orderService.Order(4, debitCard);
productService.DisplayProducts();



