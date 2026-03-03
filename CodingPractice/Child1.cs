using System;

class Child1 : Parent1
{
    public void ShowValues()
    {

        //Console.WriteLine(privateValue);
        Console.WriteLine(protectedValue);
        Console.WriteLine(PublicValue);
    }
}


