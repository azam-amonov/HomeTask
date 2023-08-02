// See https://aka.ms/new-console-template for more information

using HomeWork_16.N16_HT1;
using HomeWork_16.N16_HT2;

#region HomeTask_1

Console.WriteLine("HT- 16");
// SpaceShip spaceShip = new SpaceShip("SpaceY",12, 200, "Jupiter");
// SpaceShip spaceShip2 = new SpaceShip("SpaceD", 230, 500, "Mars");
//
// Console.WriteLine(spaceShip);
// Console.WriteLine(spaceShip2);
#endregion

#region HomeTask_2

SmartHomeService smartHomeService = new SmartHomeService("Kucharaku");
smartHomeService.Activate(true);
smartHomeService.DisplayTemperature();


#endregion