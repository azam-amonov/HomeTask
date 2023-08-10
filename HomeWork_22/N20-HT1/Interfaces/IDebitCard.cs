namespace HomeWork_22.N20_HT1;

public interface IDebitCard
{
    string CardNumber { get; set; }
    string BankName { get; set; }
    decimal Balance { get; set; }
}