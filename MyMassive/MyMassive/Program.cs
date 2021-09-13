using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;



namespace MyMassive
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,,,] MyMassive = new int[100, 100, 100, 100, 100];

            int n1, n2, n3, n4, n5;
            int i = 1;
            do
            {
                Console.WriteLine("Введите номер элемента в первом измерении");
                n1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Введите номер элемента во втором измерении");
                n2 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Введите номер элемента в третьем измерении");
                n3 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Введите номер элемента в четвертом измерении");
                n4 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Введите номер элемента в пятом измерении");
                n5 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Введите значение элемента номер " + n1 + " " + n2 + " " + n3 + " " + n4 + " " + n5 + " ");
                MyMassive[n1, n2, n3, n4, n5] = int.Parse(Console.ReadLine());
                Console.WriteLine("Для завершения работы нажмите 0, для продолжения любую другую цифру.");
                i = int.Parse(Console.ReadLine());
            }
            while (i > 0);
        }
    }
}

