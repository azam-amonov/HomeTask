// See https://aka.ms/new-console-template for more information

using TodoList;

Console.WriteLine("Hello, ToDo!");
ToDoService service = new ToDoService();

var todo = new ToDoModel { Name = "Write diary" };
var todo2 = new ToDoModel { Name = "Cook eggs"};
var todo3 = new ToDoModel { Name = "Call to friends" };
var todo4 = new ToDoModel { Name = "Write code", IsDone = true };

service.AddToDo(todo);
service.AddToDo(todo2);
service.AddToDo(todo3);
service.AddToDo(todo4);

// service.Display();
// service.AddNewToDo();
// service.MarkAsDone();

TodoView view = new TodoView();
view.Start();
public class TodoView
{
    ToDoService service = new ToDoService();
    public void MainMenu()
    {
        Console.WriteLine("1. Add new task\n" +
                          "2. Mark as done\n" +
                          "3. Display all tasks\n" +
                          "0. Exit");
    }

    public void Start()
    {
        MainMenu();
        while (true)
        {
            try
            {
                Console.Write("Enter Command: ");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                    service.AddNewToDo();
                if (choice == 2)
                    service.MarkAsDone();
                if (choice == 3)
                    service.Display();
                if (choice == 0)
                    break;
            }
            catch (TypeAccessException e)
            {
                Console.WriteLine("Enter true Command");
                throw;
            }
        }
    }
}