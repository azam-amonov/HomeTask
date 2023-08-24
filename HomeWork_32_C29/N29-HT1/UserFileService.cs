namespace HomeWork_32_C29.N29_HT1;

public class UserFileService
{
    private readonly List<string> _userNames;
    
    static readonly string CurrentDirectory = Directory.GetCurrentDirectory();
    static readonly string DirectoryPath = Directory.GetParent(CurrentDirectory).Parent.Parent.ToString();

    public UserFileService()
    {
        _userNames = new List<string>
        {
            "John",
            "Philipp",
            "Annabel",
            "Smith",
            "Jennifer"
        };
    }

    public async Task CreateFilesForUsers()
    {
        var createFilesTasks = _userNames.Select(user => Task.Run(() =>
        {
            string directoryToSaveFile = Path.Combine(DirectoryPath,"N29-HT1",$"{user.ToLower()}.txt");
            var fileStream = File.Create(directoryToSaveFile);
            return fileStream;
        })).ToList();
        
        await Task.WhenAll(createFilesTasks);

        foreach (var user in createFilesTasks)
        {
            Console.WriteLine($"Creating files for {user.GetType().Name}");
        }
    }
    
    
}