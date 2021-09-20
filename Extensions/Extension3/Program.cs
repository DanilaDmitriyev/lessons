using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension3
{
    struct MyClass
    {
        int x;
        public MyClass(int x = 5)
        {
            this.x = x;
                    }
        public void MyMetod()
        {
        Console.WriteLine("Метод MyMetod из класса MyClass, знания бы на " + x);
        }
    }
    
    static class MyExtClass
    {
        public static void MyExtMetod (this MyClass myClass, int y, int z)
        {
            for (int i = 0; i < y; i++)
                myClass.MyMetod();

        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass(5);
            myClass.MyExtMetod(10, 10);
            Console.ReadKey();
        }
    }
}
