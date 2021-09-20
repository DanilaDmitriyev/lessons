using System;

namespace ConsoleApp1
{
    class Parent
    {
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public Parent(int x)
        {
            age = x;
        }
    }

    class Child1 : Parent
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public Child1(string y) : base(x)
        {
            name = y;
        }


    } 
    
    class Program
    {
        static void Main(string[] args)
        {
            Parent parent = new Parent(30);
            Console.WriteLine("Вызвал свойство Age, чтобы узнать значение age и оно раво {0}", parent.Age);
            Console.WriteLine("Введите новое значение, которое будет записано в приватное поле age");
            parent.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Вызвал свойство Age, чтобы узнать значение age и оно раво {0}", parent.Age);
            Child1 child1 = new Child1("Danila");
            Console.ReadKey();
        }
    }
}
