using System;
using System.Collections.Generic;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Anonym
{
    public delegate int MyDelegate(int x);
    struct Employer
    {
        public int age;
        public string name;
        public string business;
        public void EmpMetod(MyDelegate myDelegate) { Console.WriteLine(myDelegate(age)); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employer[] factory = new Employer[10];
            factory.Where(employer => employer.age > 30);//нажми F12
            factory.Where(employer_real);
            factory.Where(delegate (Employer employer ) { return employer.age > 30; });//Здесь анонимный метод
            factory.OrderBy(employer => employer.business);
            factory[0].age = 28;
            factory[0].EmpMetod(x => x * x);
            Console.ReadKey();

        }
        static bool employer_real (Employer employer)
        {
            return employer.age > 30;
        }
    }
}
//Лекция №4, слайд №1, 19, 20.
