using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Hello;
/*//네임스페이스
namespace Hello
{
    class Say
    {
        public void SayHello()
        {
            Console.WriteLine("안녕하세요");
        }
    }
}*/
namespace ConsoleApp1
{
    /*//인스턴스
    class Person
    {
        public string name; //필드 클래스의 데이터를 저장하는 멤버입니다.
        private string name2;
        //private를 사용하면 함수 내에서만 사용가능하다 사용하려면 함수를 이용한다
        public void SetName(string n)
        {
            name2 = n;
        }
        public string GetName()
        {
            return name2;
        }
    }*/
    /*//생성자
    class Person
    {
        public string Name;
        public int Age;
        public Person()//기본 생성자
        {
            Name = "Unknown";
            Age = 0;
        }
        public Person(string name)//매개변수 생성자
        {
            Name = name;
            Age = 0;
        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
*/
    /*//소멸자
    class MyResource
    {
        ~MyResource()
        {
            Console.WriteLine("삭제 될떄 호출");
        }

    }*/
    /*//추상클래스(Abstract Class)
    //추상클래스는 객체를생성할수 없는 클래스로, 상속을 통해서만사용가능
    //공통적인 기능을 정의하고. 상속받은 클래스가 이를 구현하도록 강제할때 상요
    //abstract 키워드를 사용
    //추상 메서드는 선언만 하고 구현은 하지 않는다.
    //상속받은 클래스는 반드시 구현해야한다.

    abstract class Animal
    {
        //추상 메서드(구현 X, 상속받은 클래스가 구현)
        public abstract void MakeSound();
        //일반 메서드
        public void sleep()
        {
            Console.WriteLine("동물이 잠을 잡니다.");
        }
    }
    //추상 클래스를 상속받아 구체적인 클래스구현
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("멍멍!");
        }
    }
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("냐옹!");
        }
    }*/
    /*//부모클래스의 생성자 호출
    class Parent
    {
        public Parent(string message)
        {
            Console.WriteLine("부모생성자" + message); //실행2
        }
    }
    class Child : Parent
    {
        public Child():base("하하하하성공")//부모생성자 호출 1
        {
            Console.WriteLine("자식 생성자 호출");//3
        }
    }*/
    /*//부모클래스의 생성자 호출2
    class Parent
    {
        protected string name;
        //부모생성자에서  name초기화
        public Parent(string name)
        {
            this.name = name;
            Console.WriteLine($"부모 생성자 : {name}");
        }
    }
    class Child : Parent
    {
        private int age;
        //부모 생성자를 호출하면서 name 전달 + 추가로 age 초기화
        public  Child(string name, int age):base(name)
        {
            this.age = age;
            Console.WriteLine($"자식 생성자 : 나이 {age}");
        }
        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {name} 나이 : {age}");
        }
    }*/

    class Program
    {
        /*//메서드 ref, out
        //ref 포인터개념 참조
        static void Increase(ref int i)
        {
            i++;
        }
        //out은 반환이 여러개일때 유용
        static void OutFunc(int a, int b, out int x, out int y)
        {
            x =a;
            y = b;
        }*/
        static void Main(string[] args)
        {
            /*//네임스페이스
            Hello.Say Sa = new Hello.Say();
            //using을 사용하면 Hello 생략가능
            Say Sa = new Say();
            Sa.SayHello();*/
            /*//인스턴스
            Person p = new Person(); //객체로 만들기 인스턴스
            p.name = "Alice";// 이름이라는 필드에 값넣기
            p.SetName("Bob"); //private set에 값 집어넣기
            Console.WriteLine(p.name+ " "+ p.GetName());*/
            /*//생성자
            Person p = new Person(); //기본생성자
            Person p1 = new Person("앨리스");//1개짜리 매개변수있는 생성자
            Person p2 = new Person("밥", 23);//2개짜리 매개변수있는 생성자

            Console.WriteLine(p.Name + ", "+ p.Age);
            Console.WriteLine(p1.Name + ", " + p1.Age);
            Console.WriteLine(p2.Name + ", " + p2.Age);*/
            /*//소멸자
            MyResource r = new MyResource();
            //가비지컬렉션 GC에 의해 나중에 소멸자 호출
            //가비지컬렉션은 더이상 참조되지 않는 객체를 정리합니다.*/
            /*//메서드 ref, out
            int a = 10;
            int b = 20;
            Increase(ref a);
            Console.WriteLine("A의 값 : " + a);
            int x, y;
            OutFunc(a, b, out x, out y);
            Console.WriteLine($"x : {x} y : {y}");*/
            /*//추상클래스
            Animal myDog = new Dog();
            myDog.MakeSound();//멍멍
            myDog.sleep();

            Animal myCat = new Cat();
            myCat.MakeSound();//냐옹
            myDog.sleep();*/
            /*//부모클래스의 생성자 호출
            Child child = new Child(); //0 객체 생성시작*/
            /*//부모클래스의 생성자 호출2
            Child child = new Child("홍길동", 25);
            child.ShowInfo();*/

        }
    }
}
