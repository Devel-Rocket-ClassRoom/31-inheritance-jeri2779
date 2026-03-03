using System;

// README.md를 읽고 코드를 작성하세요.
//Console.WriteLine("### 1-1. 기본 상속 문법");

//Child child = new Child();
//child.Greet();  
//child.Study();

//Console.WriteLine();
//Console.WriteLine("===================================");
//Console.WriteLine("### 1-2. 동물 클래스 상속");
//Dog dog = new Dog();
//dog.Name = "초코";
//dog.Eat();
//dog.Bark();

//Cat cat = new Cat();
//cat.Name = "나비";
//cat.Eat();
//cat.Meow();


//Console.WriteLine();
//Console.WriteLine("===================================");


//Console.WriteLine("## 2. Object 클래스");

//Product product = new Product
//{
//    Name = "키보드",
//    Price = 50000
//};

//Console.WriteLine(product.ToString());
//Console.WriteLine(product.GetType());

//Console.WriteLine(  );
//Console.WriteLine("===================================");

//Console.WriteLine("## 3. 접근 제한자와 상속");

//Child1 child1 = new Child1();

//child1.ShowValues();
//Console.WriteLine(child1.PublicValue);


//Console.WriteLine();
//Console.WriteLine("===================================");

//Console.WriteLine("## 4. base 키워드");
//Manager manager = new Manager();
//manager.ShowInfo();

//Console.WriteLine();
//Console.WriteLine("===================================");

//Console.WriteLine("### 5-1. 부모 생성자 호출 (base)");
//Student student = new Student("홍길동", 3);
//Console.WriteLine($"이름: {student.Name}, 학년: {student.Grade}");


//Console.WriteLine();
//Console.WriteLine("===================================");

//Console.WriteLine("### 5-2. 암시적 기본 생성자 호출");
//Dog1 dog1 = new Dog1();
//Console.WriteLine();
//Console.WriteLine("===================================");

//Console.WriteLine("### 6-1. 업캐스팅");
//Dog2 dog2 = new Dog2 { Name = "멍멍이" };
//Animal2 animal2 = dog2;
//animal2.Eat1();


//Console.WriteLine();
//Console.WriteLine("===================================");

//Console.WriteLine("### 6-2. 다운캐스팅");

//Dog2 dog3 = (Dog2)animal2;
//dog3.Bark1();

//Console.WriteLine();
//Console.WriteLine("===================================");
//Console.WriteLine("### 6-3. is 연산자로 타입 검사");

//if(animal2 is Dog2)
//{
//    Dog2 dog4 = (Dog2)animal2;
//    dog4.Bark1();
//}

//Console.WriteLine();
//Console.WriteLine("===================================");
//Console.WriteLine("### 6-4. is 패턴 매칭");

//if (animal2 is Dog2 dog5)
//{
//    dog5.Bark1();
//}

//Console.WriteLine();
//Console.WriteLine("===================================");

//Console.WriteLine("### 6-5. as 연산자로 안전한 캐스팅");
//Animal2 animal = new Cat1 { Name = "야옹이" };
//Dog2 dog6 = animal as Dog2;
//if(dog6 != null)
//{
//       dog6.Bark1();
//}
//else
//{
//    Console.WriteLine(" Dog 타입이 아닙니다.");
//}

//Console.WriteLine();
//Console.WriteLine("===================================");
//Console.WriteLine("## 7. 다형성");
//Asset[] asset = new Asset[3];
//asset[0] = new Stock { Name = "삼성전자", Shares = 100 };
//asset[1] = new House { Name = "아파트", Mortgage = 300000000 };
//asset[2] = new Stock { Name = "SK하이닉스", Shares = 50 };

//foreach (Asset asset1 in asset)
//{
//    Console.WriteLine(asset1.Name);
//}


//Console.WriteLine();
//Console.WriteLine("===================================");
//Console.WriteLine("### 8-1. 추상 클래스 기본");

//Rectangle rect = new Rectangle { Name = "사각형", Width = 10, Height = 5 };
//Circle circle = new Circle { Name = "원", Radius = 3 };

//Console.WriteLine($"{rect.Name} 넓이: {rect.GetArea()}");
//Console.WriteLine($"{circle.Name} 넓이: {circle.GetArea():F2}");

//Console.WriteLine();
//Console.WriteLine("===================================");
//Console.WriteLine("### 8-2. 추상 메서드");
//Car car = new Car();
//car.Start();
//car.Stop();


//Console.WriteLine();
//Console.WriteLine("===================================");

//Console.WriteLine("## 9. 봉인 클래스");
//FinalClass obj = new FinalClass();
//obj.Display();


//Console.WriteLine();
//Console.WriteLine("===================================");

//Console.WriteLine("## 10. 멤버 숨기기 (new 키워드)");
//Child2 child2  = new Child2();
//Parent2 parent2 = child2;

//Console.WriteLine($"child.value: {child2.Value}");
//Console.WriteLine($"parent.Value: {parent2.Value}"); // 부모의 Value
//child2.Show();   // 자식의 Show()
//parent2.Show();


//Console.WriteLine();
//Console.WriteLine("===================================");

//Console.WriteLine("## 11. is-a 관계");
//Dog3 dog03 = new Dog3();

//Console.WriteLine(dog03 is Animal3);
//Console.WriteLine(dog03 is Dog3);
//Console.WriteLine(dog03 is Cat3);

//Console.WriteLine();
//Console.WriteLine("===================================");

Console.WriteLine("## 12. 종합 예제: 게임 캐릭터 시스템");

GameCharacter[] characters = new GameCharacter[]
{
    new Warrior("아서", 25),
    new Mage("멀린", 40),
    new Warrior("란슬롯", 30)
};

foreach (GameCharacter character in characters)
{
    character.ShowStatus();
    character.Attack();
    Console.WriteLine();
}


abstract class GameCharacter// 부모 클래스 추상 클래스로 직접 생성 불가  
{
    public string Name;
    public int Health;
    
    protected GameCharacter(string name, int health)
    {
        Name = name;
        Health = health;
    }
    public abstract void Attack();

    public void ShowStatus()
    {
        Console.WriteLine($"[{Name}] 체력 : {Health}");
    }



}

 class Warrior : GameCharacter // 자식 클래스
{
    public int Strength;// 공격력
    public  Warrior(string name,int strength) : base(name, 150)
    {
        Strength = strength;
    }

    public override void Attack()
    {
        Console.WriteLine($"[{Name}]이(가) 검으로 {Strength} 대미지를 입힙니다.");
    }



}

 class Mage : GameCharacter // 자식 클래스
{
    public int MagicPower; // 마법 공격력
    public Mage(string name, int magicPower) : base(name, 100)
    {
        MagicPower = magicPower;
    }

    public override void Attack()
    {
        Console.WriteLine($"[{Name}]이(가) 마법으로 {MagicPower} 대미지를 입힙니다.");
    }
}
