namespace HomeWork_22.N20_HT1;

public class PaymePaymentProvider : IPaymentProvider
{
    public decimal TransferInterest { get; init; }
    
    public PaymePaymentProvider(decimal transferInterest)
    {
        TransferInterest = transferInterest;
    }
    
    public void Transfer(IDebitCard sourceCard, IDebitCard destinationCard, decimal amount)
    {
        destinationCard.Balance += amount;
        sourceCard.Balance -= CalculatePresent(amount);
    }

    private decimal CalculatePresent(decimal amount) => 
                    amount + (amount * (amount / TransferInterest));
}
