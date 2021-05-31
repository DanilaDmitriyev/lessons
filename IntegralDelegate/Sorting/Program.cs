using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class River
    {
        public string name;
        public int length;
        public int depth;

        public override string ToString()
        {
            return name;
        }

    }
    
    
    class Program
    {

        static int CompareByName (River river1, River river2)
        {
            return river1.name.CompareTo(river2.name);
        }

        static int CompareByLength(River river1, River river2)
        {
            return river1.length - river2.length;
        }

        static int CompareByDepth(River river1, River river2)
        {
            return river1.depth - river2.depth;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Введите количество рек: ");
            int riversNumber = int.Parse(Console.ReadLine());


            List<River> rivers = new List<River>();
           

            for(int x = 0; x<riversNumber; x++)
            {
                River river = new River();
                Console.Write("Введите название реки: ");
                river.name = Console.ReadLine();
                Console.Write("Введите длину реки: ");
                river.length = int.Parse(Console.ReadLine());
                Console.Write("Введите глубину реки: ");
                river.depth = int.Parse(Console.ReadLine());
                rivers.Add(river);
            }

            rivers.Sort(CompareByName);//Отсортировали список по имени реки.
            rivers.ForEach(Console.WriteLine);
            Console.WriteLine();
            rivers.Sort(CompareByLength);
            rivers.ForEach(Console.WriteLine);
            Console.WriteLine();
            rivers.Sort(CompareByDepth);
            foreach(River x in rivers)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();

        
        }
    }
}//Сравнить реки по другим критериям и сделать ввод и вывод данных (пользователь ввёл несколько рек и программа отсортировала и вывела на экран). Реку переопределить tostring.