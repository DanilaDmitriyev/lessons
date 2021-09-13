using System;
using System.Collections.Generic;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Anonym
{
    class Employer
    {
        public int age;
        public string name;
        public string business;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employer[] factory = new Employer[10];
            factory.Where(employer => employer.age > 30);
            factory.Where(employer_real);
        }
        static bool employer_real (Employer employer)
        {
            return employer.age > 30;
        }
    }
}
//Лекция №4, слайд №1, 19, 20.
