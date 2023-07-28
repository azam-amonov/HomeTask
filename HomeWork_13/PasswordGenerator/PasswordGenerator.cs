using System.Text;

namespace HomeWork_13.PasswordGenerator;

// N13-HT2
//
// 1.
// - password yasash uchun PasswordGenerate service dan foydalaning
//     - undan object olish uchun quyidagi parameterlar kerak bo'lsin 
//     - length
//     - hasLetters   
//     - hasDigits - optional
//     - unda Generate methodi bo'lsin - parametersiz faqat generate bo'lgan password ni qaytaradigan
//     - bitta object yarating, password yarating va ekranga chiqaring
//



public class PasswordGenerator
{
    public bool Letters { get; set; }
    public bool Digits { get; set; }
    public int Length { get; set; }

    public PasswordGenerator( int length, bool letters, bool digits = false)
    {
        Length = length;
        Letters = letters;
        Digits = digits;
        
    }
    public void Generate()
    {
        StringBuilder password = new StringBuilder();
        Random rand = new Random();
        int length = Length;
        
        while (length != 0 )
        {
            var i = Digits ? 3 : 2;
            int randType = rand.Next(i);
            
            if (Letters && randType == 0)
                password.Append((char)rand.Next('a', 'z'));
            if (Letters && randType == 1)
                password.Append((char)rand.Next('A', 'Z'));
            if (Digits && randType == 2)
                password.Append((char)rand.Next('0', '9'));
            --length;
        }
        
        Console.WriteLine(password);
    }
}

// 2. 
//
// - xavfsiz password lar uchun SecurePasswordGenerator service dan foydalaning
//     - u PasswordGenerator dan vorislik olgan bo'lsin
//     - undan object olish uchun quyidagi parameterlar kerak bo'lsin 
//     - length
//     - hasLetters   
//     - hasDigits - optional 
//     - Generate methodi e'lon qiling - unda hasSymbols parameteri bo'lsin
//     - bitta object yarating, password yarating va ekranga chiqaring
//
public class SecurePasswordGenerator : PasswordGenerator
{
    public bool Symbols { get; set; }
    
    public SecurePasswordGenerator(int length, bool letters,bool digits = false):
        base(length, letters, digits)
    {
    }

    public string Generate(bool symbols)
    {
        StringBuilder password = new StringBuilder();
        Random rand = new Random();
        
        int length = Length;
        Symbols = symbols;
        
        while (length != 0 )
        {
            int randType = rand.Next(5);

            if (Letters && randType == 0)
                password.Append((char)rand.Next('a', 'z'));
            else if (Letters && randType == 1)
                password.Append((char)rand.Next('A', 'Z'));
            else if (Symbols && randType == 2)
                password.Append((char)rand.Next('!', '&'));
            else if (Symbols && randType == 3)
                password.Append((char)rand.Next('?', '@'));
            else if (Digits && randType == 4)
                password.Append((char)rand.Next('0', '9'));
            --length;
        }
        
        return password.ToString();
    }
    
}

// 3.
// - takrorlanmas password lar uchun UniquePasswordGenerate service dan foydalaning
//     - u SecurePasswordGenerator dan vorislik olgan bo'lsin
//     - unda GenerateUniqePassword methodi bo'lsin - parametersiz faqat yaratilgan password ni qaytaradigan
//     - yaratilgan passowrdlar kolleksiyaga saqlab borilsin
//     - agar yaratilgan password allaqachon bor bo'lsa boshqasi yaratilsin
//     - bitta object yarating, password yarating va ekranga chiqaring
class  UniquePasswordGenerator : SecurePasswordGenerator
{
    public bool Symbols { get; set; } = true;
    public int Count { get; set;}
    
    public UniquePasswordGenerator(int count, int length, bool letters = true, bool digits = true, bool symbols = true) 
        : base(length, letters, digits)
    {
        Count = count;
        Symbols = symbols;
    }

    public void GenerateUniquePassword()
    { 
        List<string> passwords = new List<string>();
        int i = 0;
        
        while (Count != 0)
        {
            var pass = Generate(true);
            if(passwords.Contains(pass))
                continue;
            else
                passwords.Add(pass);
            Count--;
        }

        foreach (var p in passwords)
        {
            Console.WriteLine(p);
        }
    }
}






























