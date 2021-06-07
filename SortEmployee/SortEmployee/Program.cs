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
        static int CompareNames (Employee x, Employee y)
        {
            return x.Name.CompareTo(y.Name);
        }

        static int CompareNamesLength(Employee x, Employee y)
        {
            return x.Name.Length - y.Name.Length;
        }

        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee {Name = "Alex", Age = 20, Skill = 1 });
            employees.Add(new Employee { Name = "Alexandra", Age = 50, Skill = 10 });
            employees.Add(new Employee { Name = "Andre", Age = 19, Skill = 2 });

            employees.Sort(CompareNames);
            employees.Sort(CompareNamesLength);
            employees.ForEach(Console.WriteLine);
            Console.ReadKey();

            //Создать список сотрудников, ввести в него данные, выполнить сортировки, вывести результат.
        }
    }
}
