using System.Text;

namespace HT_10;

public class PasGenerator
{
    public bool Letters { get; set; }
    public bool Digits { get; set; }
    public bool Symbols { get; set; }
    public int Length { get; set; }

    public PasGenerator GetParameters()
    {
        Console.Write("Use Letter?[y/n] ");
        string letter = Console.ReadLine();
        if (letter == "y")
            Letters = true;


        Console.Write("Use Digits?[y/n] ");
        string digits = Console.ReadLine();
        if (digits == "y")
            Digits = true;

        Console.Write("Use Symbols?[y/n] ");
        string symbols = Console.ReadLine();
        if (symbols == "y")
            Symbols = true;

        Console.Write("Enter length: ");
        int length = int.Parse(Console.ReadLine());
        Length = length;

        return new PasGenerator
        {
            Letters = Letters,
            Digits = Digits,
            Symbols = Symbols,
            Length = Length
        };
    }

    public string Generate()
    {
        PasGenerator pars = GetParameters();
        StringBuilder password = new StringBuilder();
        Random rand = new Random();
        int length = pars.Length;
        
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