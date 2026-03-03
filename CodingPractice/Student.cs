using System;

class Student : Person
{
    public int Grade;

    public Student(string name, int grade ) : base(name)
    {
        Grade = grade;
        Console.WriteLine($"Student 생성자 호출 {grade}학년");
    }
}