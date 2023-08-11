// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
var lnqList = new List<int>(){1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18};

var m = lnqList.Where(n => IsPrime(n)).ToList();
m.ForEach(Console.WriteLine);
 
bool IsPrime(int n)
{
    for (int i = 2; i <= Math.Sqrt(n); i++)
        if (n % i == 0)
            return false;
    return true;
}
