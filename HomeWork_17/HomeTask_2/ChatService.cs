namespace HomeWork_17.HomeTask_2;
/*
Chat servicedan foydalaning 
unda quyidagi propertylar bo'lsin
- Messages - ChatMessage tipidagi kolleksiya

unda quyidagi methodlar bo'lsin 
- Add ( content ) - content valid ekanligini tekshirib, ChatMessage dan object yaratib, kolleksiyaga qo'shilsin - invalid bo'lsa - exception, yaratilgan message Id sini qaytarsin
- Update ( id, content ) - kolleksiyadan Id bo'yicha topib, contentni validate qilib, topilgan message dan copy olinsin, content update qilinib, kolleksiyaga qo'shilsin, topilmasa - exception
- Display - messagelarni jo'natilgan ketma ketligi bo'yicha ekranga chiqarsin, bunda agar bitta message dan bir nechtasi bolsa - ya'ni edit qilingan bo'lsa, oxirgi edit qilingan versiyasi chiqsin

 */
public class ChatService
{
    private List<ChatMassage> ChatMassages { get; set; }

    public ChatService()
    {
        ChatMassages = new List<ChatMassage>();
    }

    public void Add(int id, string content)
    {
        if (ValidChatMessage.IsValidChatMessage(content))
        {
            var message = new ChatMassage(id, content);
            ChatMassages.Add(message);
        }
        else
        {
            throw new AggregateException("Invalid content message");
        }
        
    }

    public void Update(int id, string content)
    {
        var existMessage = ChatMassages.Find(m => m.Id == id);
        if (existMessage is not null)
        {
            existMessage.UpdateContent(content);
        }
        else
        {
            throw new AggregateException("Message does not exist!");
        }
    }

    public void Display()
    {
        foreach (var chatMassage in ChatMassages)
        {
            Console.WriteLine(chatMassage);
        }
    }
    
}