using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtMetod
{
    static class ExtClass
    {
        public static void FillArray(this int [] Fs, int x)//this должно быть у расш. метода
        {
            for (int i = 0; i<Fs.Length; i++)
            {
                Fs[i] = x;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] MyMassive = new int[5];
            MyMassive.FillArray(10); //обратились к расширяющему методу, как будто он метод массива.
        }

    }
}
