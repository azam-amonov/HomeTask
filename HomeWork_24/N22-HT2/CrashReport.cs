namespace HomeWork_24.N22_HT2;

public class CrashReport: IReview
{
    public int Id { get; set; }
    public int Star { get; set; }
    public string Message { get; set; }
    public string ScreenShot { get; set; } 
}