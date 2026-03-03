using System;

class Employee
{
    protected string _department = "개발팀";

    public void ShowDepartment()
    {
        Console.WriteLine($"부서: {_department}");
    }

}

