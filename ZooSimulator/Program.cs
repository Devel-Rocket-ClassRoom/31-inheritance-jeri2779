using System;

// README.md를 읽고 코드를 작성하세요.
Animal[] zoo = new Animal[] //동물 배열 생성후 정보 출력
//foreach문을 사용하여 정보/소리/행동 출력
{
    new Lion("시바", 5),
    new Elephant("덤보", 10),
    new Penguin("뽀로로", 3)
};
Console.WriteLine("=== 동물원에 오신 것을 환영합니다! ===");
Console.WriteLine();
Console.WriteLine("[동물 정보]");
foreach (Animal animal in zoo)//   동물의 정보를 출력
{
    animal.DisplayInfo();
}
Console.WriteLine();
Console.WriteLine("[동물 소리]");//  동물의 울음소리를 출력

foreach (Animal animal in zoo)
{
    animal.MakeSound();
}
Console.WriteLine();
Console.WriteLine("[동물 행동]");
foreach (Animal animal in zoo)//  동물의 행동을 출력 
//부모클래스가 자식 클래스 요소를 이용해야 하므로 다운 캐스팅 작업
// 방법 1. 명시적 캐스팅
// 방법 2. is 연산자로 타입 검사
// 방법 3. is 패턴 매칭
// 방법 4. as 연산자로 안전한 캐스팅

{
    animal.Eat();//
    if (animal is Lion lion)//  다운캐스팅 is 연산자로 타입 검사
    {
        lion.Hunt();//  다운캐스팅 is 패턴 매칭
    }
    else if (animal is Elephant elephant)
    {
        elephant.SprayWater();
    }
    else if (animal is Penguin penguin)
    {
        penguin.Swim();
    }
}

class Animal // 부모 클래스
{
    protected string Name;
    protected int Age;
    protected string _sound;
    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public void Eat()// 부모 클래스의 공통 메서드
    {
        Console.WriteLine($"{Name}이(가) 먹이를 먹습니다.");
    }
    public void MakeSound()
    {
        Console.WriteLine($"{Name}: {_sound}");
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"이름: {Name}, 나이: {Age}살");
    }

}
class Lion : Animal // 자식 클래스
{
    public Lion(string name, int age) : base(name, age)// 부모 클래스의 생성자(name,age 호출
    {
        _sound = "으르렁!";

    }
    public void Hunt()// 자식 클래스의 고유 메서드 
    //부모 클래스가 이를 이용할려면 다운캐스팅 작업 필요
    {
        Console.WriteLine($"{Name}이(가) 사냥을 합니다.");
    }
}

class Elephant : Animal // 자식 클래스2
{
    public Elephant(string name, int age) : base(name, age)
    {
        _sound = "뿌우!";
    }
    public void SprayWater()
    {
        Console.WriteLine($"{Name}이(가) 물을 뿌립니다.");
    }
}

class Penguin : Animal // 자식 클래스3
{
    public Penguin(string name, int age) : base(name, age)
    {
        _sound = "꽥꽥!";
    }
    public void Swim()
    {
        Console.WriteLine($"{Name}이(가) 수영을 합니다.");
    }
}

 

