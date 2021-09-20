using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Svoistvo
{
    class SomeSecrets
    {
        private int secret;
        public int noSecret
        {
            set
            {
                secret = value;
            }

            get => noSecret = secret;
        }
        public SomeSecrets()
        {
            secret = 777;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            SomeSecrets someSecrets = new SomeSecrets();
            Console.WriteLine("Печатаем значение приватного поля secret = {0}", someSecrets.noSecret);
            Console.Write("Введите новое значение приватного поля secret: ");
            someSecrets.noSecret = int.Parse(Console.ReadLine());
            Console.WriteLine("Печатаем значение приватного поля secret = {0}", someSecrets.noSecret);
            Console.ReadKey();
        }
    }
}
