namespace VirtualMethodInCSharp;

public class Vehicle
{
    private readonly double _distance;
    private readonly double _hour;
    private readonly double _fuel;

    protected Vehicle(double distance, double hour, double fuel)
    {
        _distance = distance;
        _hour = hour;
        _fuel = fuel;
    }

    public void Average()
    {
        var average = _distance / _fuel;
        Console.WriteLine("Vehicle Average is {0:0.00}", average);
    }

    public virtual void Speed()
    {
        var speed = _distance / _hour;
        Console.WriteLine("Vehicle Speed is {0:0.00}", speed);
    }
}