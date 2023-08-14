namespace HomeWork_24.N22_HT1;

public class WhereOrderDesc
{
    public void SelectPrimesOrderByDesc(List<int> numbers)
    {
        var primeNumbers = numbers.Where(n =>
                        IsPrime(n)).OrderDescending().ToList();
        primeNumbers.ForEach(Console.WriteLine);
    }

    private bool IsPrime(int n)
    {
        for (int i = 2; i <= Math.Sqrt(n); i++)
            if (n % i == 0)
                return false;
        return true;
    }
    
}