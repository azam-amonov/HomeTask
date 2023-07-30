using System.Net.Sockets;

namespace HomeWork_14.HomeTask.N14_HT1;

#region Task 
// N14-HT1
//
// - NotificationMessages service bo'lsin 
// - NotificationMessages da kolleksiyada message nomi va message kontenti saqlansin 
// - kolleksiya - private dictionary bo'lsin 
// - NotificationMessages da FindMessage ( messaage nomi ) - protected methodi bo'lsin, u messageni topib, KeyValuePair tipida qaytarsin
// - NotificationMessages da SearchMessage ( message nomi ) - public methodi bo'lsin - FindMessage dan foydalanib, messageni o'zini qaytarsin
// - object yarating, bor va yo'q bo'lgan messageni so'rab, ekranga chiqaring
//
// Example : 
//
// "SuccRegistration" - "You successfully registered"
// "AskPassword" - "Enter your password"
// "Blocked" - "Your account has been blocked"
#endregion

#region Logic
// Constructor bo'ladi un ma'lumot olishi kerak
// Add menthod bo'ladi un dictionary-ga ma'lumot qo'shadi
// Find message b'ladi u o'ziga massage nomini oladi va mavjud bo'lsa KeyValuePair qaytaradi ask holda null
// SearchMessage b'ladi u o'ziga massage nomini oladi va FindMessage-dan foydalanib Messageni str ko'rinishda chiqaradi

#endregion




public class NotificationMessages
{
    private Dictionary<string, string> _messageDictionary;
    public NotificationMessages()
    {
        _messageDictionary = new Dictionary<string, string>();
    }

    public void AddNotification(string name, string content)
    {
        _messageDictionary.Add(name, content);
    }
    protected KeyValuePair<string, string>? FindMessage(string name)
    {
        foreach (var ms in _messageDictionary)
        {
            if (ms.Key == name)
                return ms;
        }
        return null;
    }

    public void SearchMessage(string name)
    {
        Console.WriteLine(FindMessage(name).Value);
    }


}