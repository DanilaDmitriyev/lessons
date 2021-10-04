using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateOnceAgain
{
    public delegate void DelOA(bool x);



    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            DelOA delOA = program.MyMetod;
            delOA(true);
            Console.ReadKey();
        }
        public void MyMetod (bool x)
        {
            if (x) Console.WriteLine("True");
            else Console.WriteLine("False");
        }
    }
}
