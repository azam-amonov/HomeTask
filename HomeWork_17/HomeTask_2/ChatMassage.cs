using System.Data;

namespace HomeWork_17.HomeTask_2;
// ChatMessage modelidan foydalaning ( unique Id, SentTime, EditedTime, Content )
// unda quyidagi konstruktorlar bo'lsin
// - parameterized ( content ) - konstruktorda Id, SentTime va Content ga qiymat berilsin
// - copy ( chatMessage ) - chatMessage objectidagi barcha qiymatlarni o'ziga o'zlashtirsin, EditedDate ga hozirgi vaqt qo'yilsin

public class ChatMassage
{
    public int Id { get; set; }
    public DateTime SentTime { get; set; }
    public DateTime EditedDateTime { get; set; }
    public string Content { get; set; }

    public ChatMassage(int id, string content)
    {
        Id = id;
        Content = content;
        SentTime = DateTime.Now;
    }

    public ChatMassage(ChatMassage message)
    {
        Id = message.Id;
        Content = message.Content;
        SentTime = message.SentTime;
        EditedDateTime = DateTime.Now;
    }

    public ChatMassage Copy()
    {
        return new ChatMassage(this);
    }

    public void UpdateContent(string content)
    {
        if (ValidChatMessage.IsValidChatMessage(content))
        {
            EditedDateTime = DateTime.Now;
            Content = content;
        }
        else
        {
            throw new InvalidOperationException("Invalid content");
        }
    }

    public override string ToString()
    {
        return $"{Id} {Content} {SentTime} //// {EditedDateTime}";
    }


}