// See https://aka.ms/new-console-template for more information

using HomeWork_32_C29.N29_HT1;

Console.WriteLine("Hello, World!");

#region Saving file in project directory

// var currentDirectory = Directory.GetCurrentDirectory();
// var parentDirectory = Directory.GetParent(currentDirectory).Parent.Parent.ToString();
// var myFileInProjectDirectory = Path.Combine(parentDirectory,"myTxtFile.txt");
//
// Console.WriteLine($"Current Dir {currentDirectory}");
// Console.WriteLine($"Parent Dir {parentDirectory}");
//
// File.Create(myFileInProjectDirectory);
#endregion


var fileService = new UserFileService();
fileService.CreateFilesForUsers();