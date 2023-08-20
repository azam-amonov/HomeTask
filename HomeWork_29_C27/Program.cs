// See https://aka.ms/new-console-template for more information

using HomeWork_29_C27.N27_HT1;

Console.WriteLine("HomeWork 27");
var userService = new UserService();
var user = new User(1, "JohnDoe@gmail.com", "John Doe", "Doe12qwe3??");
var user2 = new User(2, "SaraDoe@gmail.com", "Sara Doe", "Doeqwr123??");
var user3 = new User(3, "TimDoe@gmail.com", "Tim Doe", "Doe12wqr3??");
var user4 = new User(4, "JohnDoe@gmail.com", "John Doe", "Doe1qwr23??");

try
{
    userService.AddUser(user);
    userService.AddUser(user2);
    userService.AddUser(user3);
    userService.AddUser(user4);
} 
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}




userService.GetUser();