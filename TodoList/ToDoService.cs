namespace TodoList;
// - ToDo list service ->
//     - Display -> o'ziga  todo pidifagi lsit qabul qiladi va barcha vazifalarni ko'rsatadi
//     - Mark as done -> o'ziga todo tipda list qabul qiladi, vzifa indexi orqali murojaat 
//     qilib bajarilgan deb belgilaydi
//     - Add -> o'ziga todo tipida list qabul qiladi, qo'shib qo'yadi

public class ToDoService
{
    public List<ToDoModel> models = new List<ToDoModel>();
    private ToDoModel _toDoModel = new ToDoModel();

    public void AddNewToDo()
    {
        Console.Write("Add new todo name: ");
        _toDoModel.Name = Console.ReadLine();
        AddToDo(_toDoModel);
    }
    public void AddToDo(ToDoModel todo)
    {
        models.Add(todo);
    }
    public void Display()
    {
        int i = 0;
        foreach (ToDoModel todo in models)
        {
            Console.WriteLine($"{++i}. {todo.Name}:  {todo.IsDone}");
        }
    }

    public void MarkAsDone()
    {
        Display();
        Console.Write("Enter todo number to mark as done: ");
        int choice = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < models.Count; i++)
        {
            if (choice - 1 == i && models[i].IsDone == false)
                models[i].IsDone = true;
        }
        Display();
    }

    
    
}