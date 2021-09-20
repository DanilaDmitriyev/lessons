using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions2
{
    public interface IMyInterface
    {
        void MyMetod();
    }

    static public class MyInterfaceExtensions
    {
        public static void Repiter(this IMyInterface myInterface, int x)
        {
            for (int i=0; i<x; i++)
            {
                myInterface.MyMetod();
            }
        }
    }
    public class MyInterface : IMyInterface
    {
        public void MyMetod()
        {
            Console.WriteLine("MyMetod");
        }
    }
    public class MyInterface2 : IMyInterface
    {
        public void MyMetod()
        {
            Console.WriteLine("MyMetod2");
        }
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            MyInterface myInterface = new MyInterface();
            MyInterface2 myInterface2 = new MyInterface2();
            myInterface.Repiter(5);
            myInterface2.Repiter(5);
            Console.ReadKey();
        }
    }
}
