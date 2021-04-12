using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStruct
{
    //на следующем занятии использовать интерфейс!!!!!
    
    interface IFigure
    {
        float square();
    }

    struct Ellipse : IFigure
    {
        public float Height { get; set; }
        public float Width { get; set; }
        public float square()
        {
            return (float)Math.Ceiling(Math.PI * Width * Height);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Ellipse ellipse = default(Ellipse);
            Console.WriteLine("Введите высоту эллипса");
            ellipse.Height = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите ширину эллипса");
            ellipse.Width = float.Parse(Console.ReadLine());
            Console.WriteLine("Площадь эллипса =" + ellipse.square());
            Console.ReadKey();
        }
    }
}
