using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledovanie
{
    class Father
    {
        public void FPrint (string x) { Console.WriteLine(x); }
    }

    interface IMother
    {
        void MPrint(string x);
    }

    class Child : Father, IMother
    {
        void IMother.MPrint(string x) { Console.WriteLine(x); }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child();
            child.FPrint("Класс");
            IMother mother = new Child();
            mother.MPrint("интерфейс");
            Console.ReadKey();

        }
    }
}
