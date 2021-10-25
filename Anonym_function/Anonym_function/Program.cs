using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonym_function
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine(program.Minimum(x => -x * x + 5.876554, 0, 10, 0.00001));
            Console.ReadKey();
        }
        public double Minimum(Func<double, double> function, double x1, double x2, double e) 
        {
            double tmp=function(x1);
            for (double x = x1; x <= x2; x += e)
            {
                if (tmp>function(x)) tmp = function(x);
            }
            return tmp;
        }
    }
}
