using System;

class Person
{
    public string Name;

    public Person(string name)
    {
        Name = name;
        Console.WriteLine($"Person 생성자 호출 {name}");
    }
}
