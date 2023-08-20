namespace HomeTask_27_C25.N25_HT1.Sevice;

public class PaymentService : IPaymentService
{
    public bool CheckOut(decimal amount, DebitCard debitCard)
    {
        if (debitCard.Balance >= amount)
        {
            debitCard.Balance -= amount;
            return true;
        }
        
        return false;
    }
}       