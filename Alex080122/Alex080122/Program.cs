using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alex080122
{
    public enum MyEnum
    {
        Вася,
        Петя,
        Коля
    }
    
    class MyClass
    {
        private MyEnum myEnum;
        public MyEnum MyEnum
        {
            get { return myEnum; }
            set { myEnum = value; }
        }

    }
    
    
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.MyEnum = (MyEnum) Enum.Parse(typeof( MyEnum), Console.ReadLine());
            //myClass.MyEnum = Enum.Parse<MyEnum>(Console.ReadLine());
        }
    }
}
