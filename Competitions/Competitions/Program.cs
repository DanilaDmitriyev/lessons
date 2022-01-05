using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitions
{
    public enum Discipline
    {
        sport,
        chess,
        drawing,
        music
    }
    public enum Sex
    {
        boy,
        girl
    }
    
    class Competition
    {
        public DateTime Date { get; set; }
        public String Name { get; set; }
        public Discipline Discipline { get; set; }
        public Sex Sex { get; set; }
        public int Participants { get; set; }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Competition[] competition = new Competition[]
            {
                new Competition
                {
                    Date = new DateTime(2022,03,01),
                    // Дописать инициализаторы, а затем расширяющие методы.
                }
            };
        }
    }
}
