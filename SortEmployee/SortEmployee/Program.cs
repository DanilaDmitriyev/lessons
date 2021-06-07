using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortEmployee
{
    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Skill { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
    
    
    class Program
    {
        static void Main(string[] args)
        {
            //Создать список сотрудников, ввести в него данные, выполнить сортировки, вывести результат.
        }
    }
}
