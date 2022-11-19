using System;

namespace EnumPrint
{
    internal class Program
    {
        //Печать элементов enum в строку и в столбик.

        enum MyEnum { x, y, z };

        static void Main(string[] args)
        {
            
            MyEnum[] myEnums = (MyEnum[])Enum.GetValues(typeof(MyEnum));


            Console.WriteLine(String.Join(" ", myEnums));
            Console.WriteLine(String.Join(Environment.NewLine, myEnums));


            Console.ReadKey();
        }
    }
}
