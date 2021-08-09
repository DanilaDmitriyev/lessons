using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEnum
{
    enum Day { monday = 1, sunday = 2 }
    class Program
    {
        static void Main(string[] args)
        {
            Day day;
            string temp = Console.ReadLine();
                        if (Enum.IsDefined(typeof(Day), temp)) Console.WriteLine("Да");
            else if (int.TryParse(temp, out int result) && Enum.IsDefined(typeof(Day), result))
            {
                Console.WriteLine("Числовое значение enum");
            }
            else Console.WriteLine("Нет");


            /*if (Enum.IsDefined(typeof(Day), temp)) Console.WriteLine("Да");
            else if (int.TryParse(temp, out int result))
            {
                if (Enum.IsDefined(typeof(Day), result)) Console.WriteLine("Числовое значение enum");
                else Console.WriteLine("Нет");
            }
            else Console.WriteLine("Нет");

            */

            Console.ReadKey();

        }
    }
}
