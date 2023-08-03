// See https://aka.ms/new-console-template for more information

using HomeWork_17.HomeTask_1;

Console.WriteLine("Car >>>");
CarRentalManagement rentalManagement = new CarRentalManagement();
Bmw bmw1 = new Bmw("M3");
Bmw bmw2 = new Bmw("X5");
Bmw bmw3 = new Bmw("X6");

Audi audi = new Audi("Audi R8");
Audi audi2 = new Audi("Audi A6");
Audi audi3 = new Audi("Audi A7");

rentalManagement.AddCar(audi);
rentalManagement.AddCar(audi2);
rentalManagement.AddCar(audi3);

rentalManagement.AddCar(bmw1);
rentalManagement.AddCar(bmw2);
rentalManagement.AddCar(bmw3);

var rentCar1 = rentalManagement.RentCar("BMW");
await Task.Delay(5000);
rentalManagement.ReturnCar(rentCar1);

var r =rentalManagement.CalculateManagement();
Console.WriteLine(r);