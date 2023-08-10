namespace HomeWork_22.N20_HT1;

public class MilliyHumo : IDebitCard
{
    public string CardNumber { get; set; }
    public string BankName { get; set; }
    public decimal Balance { get; set; }

    public MilliyHumo(string cardNumber, string bankName, decimal balance)
    {
        CardNumber = cardNumber;
        BankName = bankName;
        Balance = balance;
    }
    
    public void GetBalance()
    {
        Console.WriteLine($"Card balance: {Balance}");
    }
}