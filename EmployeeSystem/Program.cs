using System;

// README.md를 읽고 코드를 작성하세요.
  

Employee manager = new Manager("김부장", 5000000, 1000000);
Employee developer = new Developer("이개발", 4000000, 10);
Employee intern = new Intern("박인턴");

Console.WriteLine("=== 직원 급여 시스템 ===");
Console.WriteLine();
manager.PrintInfo();
Console.WriteLine();
developer.PrintInfo();
Console.WriteLine();
intern.PrintInfo();

class Employee
{
    protected string _name;
    protected int _baseSalary;

    //생성자, 이름과 기본급을 받아 초기화
    public Employee(string name, int baseSalary)
    {
        _name = name;
        _baseSalary = baseSalary;
    }

    public void GetName()
    {
        Console.WriteLine($"이름: {_name}");

    }

    public virtual void GetBaseSalary()//
    {
        Console.WriteLine($"급여: {_baseSalary:N0}원");


    }

     
    public virtual int CalculatePay()
    {
        return _baseSalary;
    }

    // PrintInfo()를 virtual로 추가하여 파생 클래스에서 override할 수 있도록 함
    public virtual void PrintInfo()
    {
        Console.WriteLine($"[직원] {_name}");
        Console.WriteLine($"기본급: {_baseSalary:N0}원");
        Console.WriteLine($"총 급여: {CalculatePay():N0}원");
        Console.WriteLine();
    }


}

class Manager : Employee
{
    protected int _bouns;

    public Manager(string name, int baseSalary, int bonus) : base(name, baseSalary)
    {
        _bouns = bonus;
    }

    public override int CalculatePay()
    {
        return _baseSalary + _bouns;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"[매니저] {_name}");
        Console.WriteLine($"기본급: {_baseSalary:N0}원");
        Console.WriteLine($"보너스: {_bouns:N0}원");
        Console.WriteLine($"총 급여: {CalculatePay():N0}원");
    }

}

class Developer : Employee
{
    protected int _overtimeHours;
    public Developer(string name, int baseSalary, int overtimeHours) : base(name, baseSalary)
    {
        _overtimeHours = overtimeHours;
    }
    public override int CalculatePay()
    {
        return _baseSalary + _overtimeHours * 20000;
    }
    public override void PrintInfo()
    {
        Console.WriteLine($"[개발자] {_name}");
        Console.WriteLine($"기본급: {_baseSalary:N0}원");
        Console.WriteLine($"초과근무시간: {_overtimeHours}시간");
        Console.WriteLine($"총 급여: {CalculatePay():N0}원");
    }
}
 
class Intern : Employee
{
    public Intern(string name) : base(name, 1500000) { }

    public override int CalculatePay()
    {
        return _baseSalary;
    }
    public override void PrintInfo()
    {
        Console.WriteLine($"[인턴] {_name}");
        Console.WriteLine($"기본급: {_baseSalary:N0}원");
        Console.WriteLine($"총 급여: {CalculatePay():N0}원");
    }
}


//초기 출력은 직급이 직원으로 통일되어 출력. 계산결과가 조건에 맞지 않게 나옴
//조사 결과 virtual과 override 키워드를 사용하여 각 요소가 적용되는걸 확인함.
//부모클래스가 virual, 자식 클래스가 override로 선언하는 이유를 이해할 필요 있음.
//virtual : 부모 클래스에서 메서드가 자식 클래스에서 재정의될 수 있음을 나타냄
//override : 자식 클래스에서 부모 클래스의 virtual 메서드를 재정의할 때 사용. 부모 클래스의 메서드와 동일한 시그니처를 가져야 함