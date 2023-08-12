// See https://aka.ms/new-console-template for more information


using HomeWork_24.N22_HT1;

Console.WriteLine("Hello, World!");
List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 ,11, 12, 13, 14, 15};
var isPrime = new WhereOrderDesc();

isPrime.SelectPrimesOrderByDesc(numbers);