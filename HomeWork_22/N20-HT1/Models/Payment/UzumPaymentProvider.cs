namespace HomeWork_22.N20_HT1;

public class UzumPaymentProvider : IPaymentProvider
{
     public decimal TransferInterest { get; init; }

    public UzumPaymentProvider(double transferInterest)
    {
        TransferInterest = (decimal)transferInterest;
    }
    
    public void Transfer(IDebitCard sourceCard, IDebitCard destinationCard, decimal amount)
    {
        destinationCard.Balance += amount;
        sourceCard.Balance -= CalculatePresent(amount);
    }

    private decimal CalculatePresent(decimal amount) => 
                    amount + (amount * (amount / TransferInterest));
}