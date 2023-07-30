namespace HomeWork_14.HomeTask.N14_HT2;

#region Task Members
// N14-HT2
//
// - masala logikasini alohida class library projectga ( N14-HT2-CL )
// - ishlash jarayonini esa console projectga yozing
// - class libraryni asosiy dasturga ulang ( Project -> Add Project Reference -> N14-HT2-CL )
//
// - davomat uchun ClassroomAttendance service dan foydalaning - service public bo'lsin
// - unda davmoatni ekranga chiqaruvchi public Display methodi bo'lsin
// - o'quvchilar protected bo'lgan dictionary da saqlansin
// - o'quvchilarni belgilash uchun Mark methodi bo'lsin - fullname va true/false qiymatli isPresent parameterlari bo'lsin
// - true/false qiymatni true -> present, false -> absent string qiymatga o'giring
// - internal protected bo'lgan GetStats methodi bo'lsin - unda darsda nechta o'quvchi qatnashganligi foizda hisoblansin 

// - console projectda UltimateClassroomAttendance dan object olib, 5 ta o'quvchi keldi/kelmadi va sababi bilan qo'shing
// - display methodi orqali ekraga chiqaring
//
#endregion

#region Task Logic 

/*
 * 1. ClassroomAttendance nomli class ochaman
 * 2. Protected bo'lgan classroomattendance nomli dictionary yrataman <string, string > tipida bo'ladi
 * 3. AddStudent nomli method yozaman un student qo'shadi
 * 4. GetsStatus method yozaman u o'zuga hechrasa qabul qilmaydi va Present statuslarni sanab foizni qaytaradi
 * 5. Mark method yozaman u o'ziga mavjud bo'lgan student nomini va stasutni oladi o'zgartidadi]
 * 
 */

#endregion
public class ClassroomAttendance
{
 
    private bool IsPresent { get; set; }
    protected Dictionary<string, string> attendtsStudent = new Dictionary<string, string>();

    public ClassroomAttendance(string student, bool isPresent = false)
    {
        AddStudent(student, isPresent);
        AddStudent("Anna", false);
        AddStudent("Philipp", true);
        AddStudent("Bob", true);
        AddStudent("John");
        AddStudent("Vargan", true);
    }

    public void AddStudent(string studentName, bool isPresent = false)
    {
        var status = isPresent ? "Present" : "Absent";
        attendtsStudent[studentName] = status;
    }
 

    internal protected double GetStatus()
    {
        int totalStudent = attendtsStudent.Count;
        int presentStudent = 0;

        foreach (var st in attendtsStudent.Values)
        {
            if (st == "Present")
                presentStudent++;
        }

        return (double)presentStudent / totalStudent * 100;

    }

    public virtual void Mark(string student, bool isPresent)
    {
        attendtsStudent[student] = isPresent ? "Present" : "Absent";
    }
    
    public void Display()
    {
        foreach (var st in attendtsStudent)
        {
            Console.WriteLine($"Name: {st.Key}__________{st.Value}");
        }

        // var inPresent = GetStatus();
        // Console.WriteLine($"Present of students: {inPresent}%");
    }
    
}
