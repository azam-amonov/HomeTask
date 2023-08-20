namespace HomeTask_27_C25.N25_HT1;

public interface IOrderService
{
    bool Order(int orderId, DebitCard debitCard);
    bool Order(ProductFilterDataModel filterModel, DebitCard debitCard);
}