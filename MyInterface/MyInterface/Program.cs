using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInterface
{
    public interface MainInterface
    {
        void PrintSomething(string x);
    }
    class Class1 : MainInterface
    {
        //явная реализация интерфейса
        void MainInterface.PrintSomething(string x)
        {
            Console.WriteLine(x);
        }
    }
    class Class2 : MainInterface
    {
       //реализация члена интерфейса, как члена класса
        public void PrintSomething(string x)
        {
            Console.WriteLine(x);
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Class2 class2 = new Class2();
            string temp = "text";
            class2.PrintSomething(temp);

            MainInterface class1 = new Class1(); //Переменной типа интерфейса присваиваем объект класса
            class1.PrintSomething(temp);
            Console.ReadKey();
        }
    }
}
