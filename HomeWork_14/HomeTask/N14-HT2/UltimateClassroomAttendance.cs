namespace HomeWork_14.HomeTask.N14_HT2;

#region Tasks
// - UltimateClassroomAttendance servisdan foydalaning
// - unda Mark methodiga overload bo'lsin - fullname, isPresent, cause paramterlari bo'lsin, cause - optional parameter
// - bunda dictionaryga fullname, isPresent ( absent / present qiymatda + cause ) qilib qo'shilsin
// - Display methodini override qiling va unda parentdagi Display methodini chaqiring va GetStats dan foydalanib, ekranga qatnashganlik foizini chiqaring

#endregion

public class UltimateClassroomAttendance : ClassroomAttendance
{
    public UltimateClassroomAttendance(string student, bool isPresent = false)
                    : base(student, isPresent)
    {
        AddStudent(student, isPresent);
    }

    public void Mark(string student, bool isPresent, string casue = null)
    {
        if (casue == null)
        {
            base.Mark(student, isPresent);
        }
        else
        {
            attendtsStudent[student] = isPresent ? $"Present: {casue}" : $"Absent: {casue}";
        }
    }

    public void Display()
    {
        base.Display();
        Console.WriteLine($"Present of students: {base.GetStatus()}%");
    }

}