using System;

namespace OOPractice;

public class Truck : Base
{
    public Truck(string truckName, int speed) : base(truckName, speed)
    {
        Console.WriteLine("this is truck");
    }
}