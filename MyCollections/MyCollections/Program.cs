using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollections
{
    public enum Degree { candidate, doctor}
    public class Publication
    {
        public string Article { get; set; }
        public int Year { get; set; }
        public string Publishier { get; set; }
    }

    
    public class Employee
    {
        private Dictionary<string, int> discipline = new Dictionary<string, int>();
        public string Family { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }//отчество
        public DateTime Birth { get; set; }
        public Degree degree { get; set; }
        public Dictionary<string, int> Discipline
        {
            get { return discipline; }
        }
        public List<Publication> Publications { get; } = new List<Publication>();
        public int Throttle() //педагогическая нагрузка
        {
            return discipline.Sum(kv => kv.Value); //расширяющий метод и лямбда выражение
            //kv - это формальный параметр (это объявление параметра) лямбда выражения
            //kv => kv.Value - это фактический параметр (это конкретное фактическое значение параметра) метода Sum
            // лекция 4 слайды 19 и 20
        }

    }
    class Program
    {

        /*Написать класс, описывающий сотрудника кафедры: ФИО, дата рождения, учёная степень,
          список читаемых курсов (название, кол-во часов), список научных трудов (название, год издания, издательство),
          педагогическая нагрузка (общее кол-во часов по всем курсам). Для расчёта педагогической нагрузки использовать Linq*/
        //чем Enum в корне отличается от Коллекций
        //почитать LINQ слайд 17, лекция 4 и слайд 16
        


        static void Main()
        {

        }
    }
}
