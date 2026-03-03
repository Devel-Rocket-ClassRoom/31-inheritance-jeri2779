using System;

class Child2 : Parent2
{
    public new int Value = 20;
    public new void Show()
    {
        Console.WriteLine("Child.Show()");
    }
}