// See https://aka.ms/new-console-template for more information

using HomeTask_26_C24.N24_HT1.Service;

Console.WriteLine("HomeWork -> 24");
var userService = new UserService();
var userCredentials = new UserCredentialService();

var registration = new RegistrationService(userService, userCredentials);

registration.Register("John", "Doe", "JohnDoe@gmail.com", "JohnDoe1234");
registration.Register("Jane", "Smith", "JaneSmith@gmail.com", "JaneSmith5678");
registration.Register("Michael", "Johnson", "MichaelJohnson@gmail.com", "Michael1234");
registration.Register("Emily", "Williams", "EmilyWilliams@gmail.com", "Emily5678");
registration.Register("William", "Brown", "WilliamBrown@gmail.com", "William1234");
registration.Register("Olivia", "Jones", "OliviaJones@gmail.com", "Olivia5678");
registration.Register("James", "Miller", "JamesMiller@gmail.com", "James1234");
registration.Register("Sophia", "Davis", "SophiaDavis@gmail.com", "Sophia5678");
registration.Register("Benjamin", "Wilson", "BenjaminWilson@gmail.com", "Benjamin1234");
registration.Register("Emma", "Moore", "EmmaMoore@gmail.com", "Emma5678");

// var list = userService.Get(2,1);
// list.ForEach(Console.WriteLine);
userService.GetAllData().ForEach(Console.WriteLine);