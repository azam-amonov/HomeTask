namespace HomeTask_27_C25.N25_HT1;

public interface IPaymentService
{
    bool CheckOut (decimal amount, DebitCard debitCard);
}