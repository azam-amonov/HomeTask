namespace HomeWork_13.Animals;
// N13-HT1
//
//     - hayvonlar uchun Animal modelidan foydalaning
//     - Animal modelidan MakeSound methodi bo'lsin - shunchaki ekranga "..." chiqsin
//     - undan Bird, Mammal, Fish voris modellarini yarating
//     - Bird modelida Fly methodi bo'lsin - shunchaki ekranga "Fly" deb chiqarsin
//     - Mammal modelida Run methodi bo'lsin - shunchaki ekranga "Run" deb chiqarsin
//     - Fish modelida Swim methodi bo'lsin - shunchaki ekranga "Swim" deb chiqarsin
//     - Bird modelidan Sparrow voris modelini yarating
//     - Mammal modelidan Tiger voris modelini yarating
//     - Fish modelidan Great White Shark voris modelini yarating
//     - vorislik ierarxiyasidagi eng pastdagi modellardan object yarating va o'zlaridagi unique bo'lgan methodlarni ekrangaa chiqaring

public class Animal
{
    public string Name { get; set; }

    public Animal(string name)
    { 
        Name = name;
        Console.WriteLine($"Hi im {Name} ");
    }
    
    public void MakeSound()
    {
        Console.WriteLine(".....");
    }
}

public class Bird : Animal
{
    public Bird(string name) : base(name)
    {
        
    }

    public void Fly()
    {
        Console.WriteLine("Im flying!");
    }

}

public class Mammal : Animal
{
    public Mammal(string name) : base(name)
    {
    }

    public void Run()
    {
        Console.WriteLine("Im running!");
    }
}

public class Fish : Animal
{
    public Fish(string name) : base(name)
    {
    }

    public void Swim()
    {
        Console.WriteLine("Im swimming!");
    }
}

class Sparrow: Bird
{
    public Sparrow(string name) : base(name)
    {
    }
}

class Tiger : Mammal
{
    public Tiger(string name) : base(name)
    {
    }
}

class Shark : Fish
{
    public Shark(string name) : base(name)
    {
    }
}

