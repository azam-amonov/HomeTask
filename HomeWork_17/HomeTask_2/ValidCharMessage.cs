namespace HomeWork_17.HomeTask_2;

public static class ValidChatMessage
{
    public static bool IsValidChatMessage(string content)
    {
        if (string.IsNullOrEmpty(content) && content.Length > 10)
        {
            throw new ArgumentException("Invalid content massage!");
        }
        return true;
    }
}