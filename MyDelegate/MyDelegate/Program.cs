using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace MyDelegate
{



    class Program
    {
        static void Main(string[] args)
        {
            MeDelegate meDelegate = MyMetod;
            meDelegate(555);
            Program program = new Program();
            meDelegate = program.MyNeStaticMetod;
            meDelegate(555);

            Console.ReadKey();

        }
        public delegate void MeDelegate(int y);
        public static void MyMetod(int x)
        {
            Console.WriteLine(x);
        }
        public void MyNeStaticMetod (int w)
        {
            Console.WriteLine(w * 2);
        }
    }
}
