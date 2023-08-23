namespace HomeWork_32_C29.N29_HT1;

public class UserFileService
{
    List<string> _userNames = new List<string>();
    
    static string CurrentDirectory = Directory.GetCurrentDirectory();
    static string _directoryPath = Directory.GetParent(CurrentDirectory).Parent.Parent.ToString();
    string _directoryToSaveFile = Path.Combine(_directoryPath,"N29-HT1","file.txt");
 
    // var currentDirectory = Directory.GetCurrentDirectory();
    // var parentDirectory = Directory.GetParent(currentDirectory).Parent.Parent.ToString();
    // var myFileInProjectDirectory = Path.Combine(parentDirectory,"N29-HT1", "myTxtFile.txt");

    public void PrintDirectory()
    {
        Console.WriteLine(CurrentDirectory);
        Console.WriteLine(_directoryPath);
        Console.WriteLine(_directoryToSaveFile);
        // File.Create(_directoryToSaveFile);
    }
    
}