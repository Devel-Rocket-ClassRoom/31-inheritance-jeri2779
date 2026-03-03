using System;

abstract class  Vehicle
{
    public abstract void Start();
    public void Stop()
    {
        Console.WriteLine("정지합니다.");
    }   
}
