// See https://aka.ms/new-console-template for more information

using HomeWork_12.N12_HT1;

var user1 = new User
{
  FirstName = "John",
  LastName = "Doe"
};

var user2 = new User
{
  FirstName = "John",
  LastName = "Doe"
};

Console.WriteLine(user1.Equals(user2));