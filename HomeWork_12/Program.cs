// See https://aka.ms/new-console-template for more information

using HomeWork_12.N12_HT1;
using HomeWork_12.N12_HT12;

Console.WriteLine("Console Working");
// HomeWork_12.N12_HT
// var user1 = new User
// {
//   FirstName = "John",
//   LastName = "Doe"
// };
//
// var user2 = new User
// {
//   FirstName = "John",
//   LastName = "Doe"
// };
//
// Console.WriteLine(user1.Equals(user2));

EmailModel email = new EmailModel();
email.EmailTo = "john@example.com";
email.EmailFrom = "John@example.com";
email.EmailSubject = "Test Email subject";
email.EmailContent = "Test Email content, subject and content";

Console.WriteLine(email);