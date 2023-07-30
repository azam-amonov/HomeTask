// See https://aka.ms/new-console-template for more information

using HomeWork_14.HomeTask.N14_HT1;
using HomeWork_14.HomeTask.N14_HT2;

Console.WriteLine(">>>");
// N14-HT1
// NotificationMessages notificationMessages = new NotificationMessages();
//
// notificationMessages.AddNotification("Console", "Console Message");
// notificationMessages.AddNotification("SuccRegistration", "You successfully registered");
// notificationMessages.AddNotification("AskPassword", "Enter your password");
// notificationMessages.AddNotification("Blocked", "Your account has been blocked");
//
// notificationMessages.SearchMessage("Console");


// N14-HT2 >>> ClassroomAttendance
// ClassroomAttendance classroomAttendance = new ClassroomAttendance("John");
// classroomAttendance.Display();

// --------N14-HT2 >>> Classroom2
UltimateClassroomAttendance classroomAttendance = new UltimateClassroomAttendance("John");
classroomAttendance.Display();
classroomAttendance.Mark("John", false, "He is seek");
classroomAttendance.Mark("Bob", false, "He id Grandpa is dead");
Console.WriteLine("");
classroomAttendance.Display();




