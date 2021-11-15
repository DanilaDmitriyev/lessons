 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonym_once_again
{
    public delegate double MyFunction(double x, double y); 
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyMaximum(0, 5, 0, 5, Mf));
            Console.WriteLine(MyMaximum(0, 5, 0, 5, (x,y)=>x*x+y+10));//Анонимный метод
            Console.ReadKey();

        }
        static double Mf(double x, double y) { return(x * x + y + 10); }
        static double MyMaximum (double xmin, double xmax, double ymin, double ymax, MyFunction myFunction) {
            double Max = double.MinValue;
            for(double x=xmin; x<=xmax; x = x + 0.0001)
            {
                for (double y = ymin; y <= ymax; y = y + 0.0001)
                {
                    if (myFunction(x, y) > Max) Max = myFunction(x, y);
                    
                }
            }
            return Max;
        }
    }
}
