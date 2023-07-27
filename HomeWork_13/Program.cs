// See https://aka.ms/new-console-template for more information

using HomeWork_13.Animals;
using HomeWork_13.OwnPractic_Inheret.Vehicle_Classes;
using HomeWork_13.PasswordGenerator;

Console.WriteLine("********************************");
// VehicleModel vehicleModel = new VehicleModel("Not car");
// vehicleModel.Move();
// Console.WriteLine(vehicleModel);

// Car someCar = new Car("Nexia", "UZAM");
// someCar.Move();
// Console.WriteLine(someCar);



// Bird bird = new Bird("Rio");
// Tiger tiger = new Tiger("Alex");
// Fish fish = new Fish("Nemo");
//
//
// bird.MakeSound();
// tiger.MakeSound();
// fish.MakeSound();

// PasswordGenerator generator = new PasswordGenerator(8, true);
// generator.Generate();

SecurePasswordGenerator generator2 = new SecurePasswordGenerator(6, true, true);
generator2.Generate(true);