using System;

namespace OOPractice;

public class Base
{
    private string carName;
    private int currentSpeed;

    public Base(string carName, int speed)
    {
        this.carName = carName;
        this.currentSpeed = speed;
        Console.WriteLine("this is base");

    }

    public virtual string CarSpeedUp()
    {
        return ($"{this.carName}: speed up {this.currentSpeed}km/h");
    }
}