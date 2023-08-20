namespace HomeWork_28_C26.N26_HT1;

public class Money
{
    private List<Money> _moneyList;
    private decimal Amount { get; set; }
    private MoneyType MoneyType { get; set; }
    private Currency Currency { get; set; }
    
    public Money()
    {
        _moneyList = new List<Money>
        {
                        new Money(100.00m, MoneyType.InBalance, Currency.USD),
                        new Money(50.00m, MoneyType.InBalance, Currency.UZS),
                        new Money(200.00m, MoneyType.Loan, Currency.USD),
                        new Money(75.00m, MoneyType.InBalance, Currency.RUB),
                        new Money(150.00m, MoneyType.Loan, Currency.UZS),
                        new Money(25.00m, MoneyType.InBalance, Currency.RUB),
                        new Money(50.00m, MoneyType.InBalance, Currency.USD),
                        new Money(10.00m, MoneyType.Loan, Currency.RUB),
                        new Money(5.00m, MoneyType.Loan, Currency.UZS),
                        new Money(100.00m, MoneyType.InBalance, Currency.USD),
        };
    }
    public Money(decimal amount, MoneyType moneyType, Currency currency)
    {
        Amount = amount;
        MoneyType = moneyType;
        Currency = currency;
    }

    private static decimal MoneyConvert(Money money)
    {
        if (money.Currency == Currency.USD)
            return money.Amount * 12000;
        
        if (money.Currency == Currency.RUB)
            return money.Amount * 128;
        
        return money.Amount;
    }
    
                    
    public static decimal operator + (Money moneyA, Money moneyB)
    {
        if (moneyA.MoneyType == MoneyType.InBalance && moneyB.MoneyType == MoneyType.Loan)
            return MoneyConvert(moneyA) - MoneyConvert(moneyB);
        
        if (moneyA.MoneyType == MoneyType.Loan && moneyB.MoneyType == MoneyType.InBalance)
            return MoneyConvert(moneyB) + MoneyConvert(moneyA);
        
        return MoneyConvert(moneyA) + MoneyConvert(moneyB);
    }

    public void DisplayCash()
    {
        var cash = _moneyList.Sum(m => MoneyConvert(m) + MoneyConvert(m));
        Console.WriteLine($"Money in balance: {cash} UZS");
    }
}