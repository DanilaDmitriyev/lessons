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
                    Name = "Drawing",
                    Discipline = Discipline.drawing,
                    Sex = Sex.boy,
                    Participants = 10
                    // Дописать инициализаторы, а затем расширяющие методы.
                },
                new Competition
                {
                    Date = new DateTime(2022,04,01),
                    Name = "Chess",
                    Discipline = Discipline.chess,
                    Sex = Sex.boy,
                    Participants = 5
                    // Дописать инициализаторы, а затем расширяющие методы.
                },
                new Competition
                {
                    Date = new DateTime(2022,04,02),
                    Name = "Chess",
                    Discipline = Discipline.chess,
                    Sex = Sex.girl,
                    Participants = 4
                    // Дописать инициализаторы, а затем расширяющие методы.
                },
                new Competition
                {
                    Date = new DateTime(2022,04,01),
                    Name = "Music",
                    Discipline = Discipline.music,
                    Sex = Sex.girl,
                    Participants = 20
                    // Дописать инициализаторы, а затем расширяющие методы.
                },
                new Competition
                {
                    Date = new DateTime(2022,05,09),
                    Name = "GloryDay",
                    Discipline=Discipline.music,
                    Sex= Sex.boy,
                    Participants = 50
                }
                
            };
            competition.Where(x => x.Sex == Sex.boy).OrderByDescending(x => x.Participants).First();
            //competition.Where(IsBoy) продолжить здесь!!!!!!!!!!!!!!!!!!!!!
        }
        static bool IsBoy (Competition competition)
        {
            return competition.Sex == Sex.boy;
        }
    }
}
