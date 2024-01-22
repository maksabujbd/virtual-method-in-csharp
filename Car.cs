namespace VirtualMethodInCSharp;

public class Car(double distance, double hour, double fuel) : Vehicle(distance, hour, fuel)
{
    private readonly double _distance1 = distance;
    private readonly double _hour1 = hour;
    private readonly double _fuel1 = fuel;

    public new void Average()
    {
        var average = _distance1 / _fuel1;
        Console.WriteLine("Car Average is {0:0.00}", average);
    }

    public override void Speed()
    {
        var speed = _distance1 / _hour1;
        Console.WriteLine("Car Speed is {0:0.00}", speed);
    }
}