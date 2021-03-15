using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonMonth

{
    enum Month : byte
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }



    class Program
    {


        static void Main(string[] args)
        {

            for (; ; )
            {
                Console.WriteLine("Введите название месяца (англ)");
                foreach (string x in
                     Enum.GetNames(typeof(Month))) Console.WriteLine(x);

                try
                {
                    Month month = (Month)Enum.Parse(typeof(Month), Console.ReadLine(), true);
                    if (!Enum.IsDefined(typeof(Month), month)) Console.WriteLine("Введите число от 1 до 12");
                    else
                    Console.WriteLine(month);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);

                }
                if (Console.ReadKey().KeyChar == 'z') break;

            }

        }

    }

}
