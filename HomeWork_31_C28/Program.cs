// See https://aka.ms/new-console-template for more information

using HomeWork_31_C28.N28_HT1;

Console.WriteLine("HomeTask: 28");
EventStack myEventStack = new EventStack ();

myEventStack.Push(new Event("Call to home", DateTime.Now.AddHours(3)));
myEventStack.Push(new Event("Take a break", DateTime.Now.AddHours(2)));
myEventStack.Push(new Event("Go to the Meetup", DateTime.Now.AddDays(2)));
myEventStack.Push(new Event("Call to friends", DateTime.Now.AddHours(3)));


while (true)
{
    try
    {
        var myEvent = myEventStack.Pop();
        Console.WriteLine(myEvent);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
        break;
    }
}