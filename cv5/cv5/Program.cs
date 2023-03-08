// See https://aka.ms/new-console-template for more information
using cv5;

Console.WriteLine("Hello, World!");
Car Volvo = new Car(Vehicle.FuelType.Gasoline, 80, 5);
Truck Mann = new Truck(Vehicle.FuelType.Diesel, 300, 30);
Console.WriteLine(Volvo);
try
{
    Volvo.FillTank(85, Vehicle.FuelType.Diesel);
}
catch (Exception e){ 
    Console.WriteLine("Error occured: " + e.Message);
}

Volvo.FillTank(80, Vehicle.FuelType.Gasoline);
Volvo.RadioSavePreset(1, 55.5);
Volvo.RadioSavePreset(2, 102.2);
Volvo.RadioLoadPreset(1);
Volvo.RadioTurn(true);
Console.WriteLine(Volvo);
Console.WriteLine(Mann);