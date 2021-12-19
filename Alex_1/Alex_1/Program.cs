using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alex_1
{
    interface IAboba
    {
        void Biba();
        
    }
    class BaseAboba : IAboba
    {
        void IAboba.Biba() 
        {
            Console.WriteLine("Aboba");
        }

}
    class Program
    {
        static void Main(string[] args)
        {
            IAboba Action2 = new BaseAboba();
            Action2.Biba();

            Console.ReadKey();
        }
    }
}
