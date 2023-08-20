namespace HomeTask_27_C25.N25_HT1;

public class DebitCard
{
    public string CardNumber { get; set; }
    public decimal Balance { get; set; }

    public DebitCard(string cardNumber, decimal balance)
    {
        CardNumber = cardNumber;
        Balance = balance;
    }
}