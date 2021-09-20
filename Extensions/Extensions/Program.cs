using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    class MyClass
    {
        public void MyMetod()
        {
            Console.WriteLine("MyMetod");
        }
    }

    static class MyStaticClass
    {
        public static void Repiter(this MyClass myClass, int x)
        {
            for (int i = 0; i<x; i++)
            {
                myClass.MyMetod();
            }
        }
    }
    
    
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.Repiter(5);
            Console.ReadKey();
        }
    }
}

