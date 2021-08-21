using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Enumus1
{
    enum What
    {
        road = 1,
        door = 2,
        Car = 10,
        Smit = 9020

        }
        class Program
    {
        

        static void Main(string[] args)
        {
            What what;
            string temp = Console.ReadLine();
            if (Enum.IsDefined(typeof(What), temp)) Console.WriteLine("Yes");
            else if (int.TryParse(temp, out int result))
            {
                if (Enum.IsDefined(typeof(What), result))
                    Console.WriteLine("Числовое значение Enum");

                else
                    Console.WriteLine("no");
            }
            else
                Console.WriteLine("no");
            Console.ReadKey();
        }
    }
}