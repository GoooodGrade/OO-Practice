using System;

namespace OOPractice;

public class Car : Base
{
    public Car(string carName, int speed) : base(carName, speed)
    {
        Console.WriteLine("this is car");
    }
}