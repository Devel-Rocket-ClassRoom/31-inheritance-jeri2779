using System;

class Manager : Employee
{
    public void ShowInfo()
    {
        Console.WriteLine($"소속 부서: {base._department}");
        base.ShowDepartment();
    }
}

