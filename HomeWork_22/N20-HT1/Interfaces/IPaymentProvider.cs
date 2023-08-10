namespace HomeWork_22.N20_HT1;

public interface IPaymentProvider
{ 
    decimal TransferInterest { get; init; }
    void Transfer(IDebitCard sourceCard, IDebitCard destinationCard, decimal amount);
    
}