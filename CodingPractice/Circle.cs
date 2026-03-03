using System;

class Circle : Shape
{
    public double Radius;

    public override double GetArea()
    {
            return Math.PI * Radius * Radius;
    }
}

