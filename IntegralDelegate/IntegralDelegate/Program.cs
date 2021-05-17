using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegralDelegate
{
    delegate double Y(double x);
    
    interface IFunction 
    {
        double Call (double x);
    }

    class Fuction : IFunction
    {
        public double Call(double x)
        {
            return 1;
        }
    }

    class Program
    {
        static double Integral (Y y, double min, double max)
        {
            double sum = 0;
            for (double x = min; x < max; x += 1e-6)
            {
                sum = sum + (y(x) + y(x + 1e-6)) * 1e-6 / 2;
            }
            return sum;
        }
        static double Integral (IFunction y, double min, double max)
        {
            double sum = 0;
            for (double x = min; x < max; x += 1e-6)
            {
                sum = sum + (y.Call(x) + y.Call(x + 1e-6)) * 1e-6 / 2;
            }
            return sum;

        }
        static double StandartIntegral (Func<double, double> y, double min, double max)
        {
            double sum = 0;
            for (double x = min; x < max; x += 1e-6)
            {
                sum = sum + (y(x) + y(x + 1e-6)) * 1e-6 / 2;
            }
            return sum;
        }

        static double Test (double x)
        {
            return 1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Integral(Test, 0, 1));
            Console.WriteLine(Integral(new Fuction(), 0, 1));
            Console.WriteLine(StandartIntegral(Test, 0, 1));
            Console.ReadKey();
            //Задание на следующий урок: написать несколько методов для тестирования и написать метод хорд.
        }
    }
}
