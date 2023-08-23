// See https://aka.ms/new-console-template for more information

using HomeWork_31_C28.N28_HT1;
using HomeWork_31_C28.N28_HT2;

Console.WriteLine("HomeTask: 28");

#region N28-HT-1
// EventStack myEventStack = new EventStack ();
//
// myEventStack.Push(new Event("Call to home", DateTime.Now.AddHours(3)));
// myEventStack.Push(new Event("Take a break", DateTime.Now.AddHours(2)));
// myEventStack.Push(new Event("Go to the Meetup", DateTime.Now.AddDays(2)));
// myEventStack.Push(new Event("Call to friends", DateTime.Now.AddHours(3)));
//
//
// while (true)
// {
//     try
//     {
//         var myEvent = myEventStack.Pop();
//         Console.WriteLine(myEvent);
//     }
//     catch (Exception e)
//     {
//         Console.WriteLine(e.Message);
//         break;
//     }
// }
#endregion

#region N28-HT-2

CloneableList<StorageFile> storageFiles = new CloneableList<StorageFile>();
storageFiles.Add(new StorageFile { Id = Guid.NewGuid(), Name = "Storage-1", Description = "N/A", Size = 234 });
storageFiles.Add(new StorageFile { Id = Guid.NewGuid(), Name = "Storage-2", Description = "N/B", Size = 24 });
storageFiles.Add(new StorageFile { Id = Guid.NewGuid(), Name = "Storage-3", Description = "N/C", Size = 23 });

CloneableList<StorageFile>  cloneFiles = (CloneableList<StorageFile>)storageFiles.Clone();
storageFiles[0].Description = "Changed!";

Console.WriteLine("Storage files");

foreach (var file in storageFiles)
    Console.WriteLine($"{file.Name} {file.Description} {file.Size}");


Console.WriteLine("Copy files...");

foreach (var copy in cloneFiles)
    Console.WriteLine($"{copy.Name} {copy.Description} {copy.Size}");

#endregion