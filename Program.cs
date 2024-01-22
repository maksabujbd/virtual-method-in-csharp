using VirtualMethodInCSharp;

Console.WriteLine("Enter the Distance");
var distance = double.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the Hours");
var hour = double.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the Fuel");
var fuel = double.Parse(Console.ReadLine()!);

var objCar = new Car(distance, hour, fuel);

objCar.Average();
objCar.Speed();
Console.ReadKey();