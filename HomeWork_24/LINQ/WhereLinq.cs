namespace HomeWork_24.LINQ;

public class WhereLinq
{
     public IList<Student> student = new List<Student>
     {
         new Student(1, 14, "John"),
         new Student(2, 12, "Sara"),
         new Student(3, 15, "Philipp"),
         new Student(4, 10, "Anna"),
         new Student(5, 25, "John"),
         new Student(6, 17, "Adam"),
     };

     public void SelectByContains(string item)
     {
         var res = student.Where(s => s.Name.Contains(item)).ToList();
         res.ForEach(Console.WriteLine);
     }

     public void SelectByAge(int ageA, int ageB)
     {
         var res = student.Where(s => s.Age >= ageA && s.Age <= ageB).ToList();
         res.ForEach(Console.WriteLine);
     }

}

public class Student
{
    public int Id {get; set; }
    public uint Age { get; set; }
    public string Name { get; set; }

    public Student(int id, uint age, string name)
    {
        Id = id;
        Age = age;
        Name = name;
    }
}