// See https://aka.ms/new-console-template for more information

using HomeWork_32_C29.N29_HT1;

Console.WriteLine("Hello, World!");
var currentDirectory = Directory.GetCurrentDirectory();
var parentDirectory = Directory.GetParent(currentDirectory).Parent.Parent.ToString();
var myFileInProjectDirectory = Path.Combine(parentDirectory,"N29-HT1", "myTxtFile.txt");

Console.WriteLine($"Current Dir {currentDirectory}");
Console.WriteLine($"Parent Dir {parentDirectory}");

File.Create(myFileInProjectDirectory);
var user = new UserFileService();
user.PrintDirectory();