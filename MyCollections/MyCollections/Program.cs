using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollections
{
    public enum Degree { candidate, doctor}


    
    public class Employee
    {
        private Dictionary<string, int> discipline;
        public string Family { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public DateTime Birth { get; set; }
        public Degree degree { get; set; }
        public Dictionary<string, int> Discipline
        {
            get { return discipline; }
        }
    }
    class Program
    {

        /*Написать класс, описывающий сотрудника кафедры: ФИО, дата рождения, учёная степень,
          список читаемых курсов (название, кол-во часов), список научных трудов (название, год издания, издательство),
          педагогическая нагрузка (общее кол-во часов по всем курсам). Для расчёта педагогической нагрузки использовать Linq*/
        //чем Enum в корне отличается от Коллекций

        


        static void Main(string[] args)
        {
        }
    }
}
