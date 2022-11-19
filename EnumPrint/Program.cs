using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumPrint
{
    internal class Program
    {
        //Печать элементов enum в строку и в столбик.

        enum MyEnum { x, y, z };

        static void Main(string[] args)
        {
            Console.WriteLine("Hello Danila");

            MyEnum[] myEnums = (MyEnum[])Enum.GetValues(typeof(MyEnum));


            Console.WriteLine(String.Join(" ", myEnums));
            Console.WriteLine(String.Join(Environment.NewLine, myEnums));


            Console.ReadKey();
        }
    }
}
