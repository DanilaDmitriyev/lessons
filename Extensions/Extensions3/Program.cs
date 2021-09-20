using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions3
{
    class MyClass
    {
        public MyClass (int x)
        {
            //this.x  = x; 
            m_x = x;
        }

        private int m_x;

        public void MyMetod (int y)
        {
            Console.WriteLine("Поле класса m_x = " + m_x);
            Console.WriteLine("Методу MyMetod передан параметр x= "+y);
        }
    }
    
    static class Extension3
    {
        public static void MyExtension3 (this MyClass myClass, int z)
        {
            for (int i = 0; i < z; i++) myClass.MyMetod(z);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass(100);
            myClass.MyExtension3(5);
            Console.ReadKey();
        }
    }
}
