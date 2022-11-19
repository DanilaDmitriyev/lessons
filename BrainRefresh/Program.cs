using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BrainRefresh
{
    internal class Program
    {

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
