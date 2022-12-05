using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorKoordinat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int step = 6;
            //int nX = 10; //количество узлов по оси Х.
            //int nY = 10; //количество узлов по оси У.
           
            float x1 = 0;
            float y1 = 0;
            float x2 = 0;
            float y2 = 14;
            float x3 = 14;
            float y3 = 14;
            float x4 = 14;
            float y4 = 2;


            List<float> xcoord = new List<float>();
            List<float> ycoord = new List<float>();


            xcoord.Add(x1);
            xcoord.Add(x2);
            xcoord.Add(x3);
            xcoord.Add(x4);
            ycoord.Add(y1);
            ycoord.Add(y2);
            ycoord.Add(y3);
            ycoord.Add(y4);

            for (int i=0; i < step/2; i++)
            {
              
                x1 = x1 + 2; //координата х первой точки
                y1 = y1 + 2; //координата y первой точки равна y1
                x2 = x2 + 2; //координата х второй точки
                y2 = y2 - 2 ; //координата у второй точки равна у1
                x3 = x3 - 2; //координата х третьей точки
                y3 = y3 - 2; //координата у третьей точки
                x4 = x4 - 2;     //координата х четвертой точки
                y4 = y4 + 2; //координата у четвертой точки
                xcoord.Add(x1);
                xcoord.Add(x2);
                xcoord.Add(x3);
                xcoord.Add(x4);
                ycoord.Add(y1);
                ycoord.Add(y2);
                ycoord.Add(y3);
                ycoord.Add(y4);

            }
            x1=x4;
            y1 = y4 + 1;
            x2 = x1 -3;
            y2 = y1;
            x3 = x2;
            y3 = y2 -4;
            x4 = x3 + 6;
            y4 = y3;

            xcoord.Add(x1);
            xcoord.Add(x2);
            xcoord.Add(x3);
            xcoord.Add(x4);
            ycoord.Add(y1);
            ycoord.Add(y2);
            ycoord.Add(y3);
            ycoord.Add(y4);

            Console.WriteLine("X");           
            foreach(var item in xcoord)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Y");
            foreach (var item in ycoord)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            */
            Console.WriteLine("Введите ширину комнаты в мм, например 4000");
            float roomWidth = float.Parse (Console.ReadLine());

            Console.WriteLine("Введите длину комнат в мм, например 8000");
            float roomHeight = float.Parse (Console.ReadLine());

            Console.WriteLine("Введите шаг трубы в мм (расстояние межуд параллельными трубами), к примеру 200");
            float step = float.Parse (Console.ReadLine());
            
            int stripNumberX = (int) Math.Round(roomWidth / step);
            int stripNumberY = (int) Math.Round(roomHeight / step);

            int knotNumberWidth = stripNumberX + 1;
            int knotNumberHeight = stripNumberY + 1;

            float tempMarginesWidth = roomWidth - step * stripNumberX;
            float MarginesWidth = 0;
            
            if (tempMarginesWidth == 0)
            {
                MarginesWidth = step/2;
                Console.WriteLine("Отступ труб от стены по ширине комнаты = " + MarginesWidth);
            }
            else if ((0 < tempMarginesWidth)&(tempMarginesWidth < step/2))
            {
                MarginesWidth = (roomWidth - step * stripNumberX) / 2 + step;
                knotNumberWidth = knotNumberWidth - 1;
                Console.WriteLine("Отступ труб от стены по ширине комнаты = " + MarginesWidth);
            }
            else if (0 > tempMarginesWidth)
            {
                MarginesWidth = tempMarginesWidth - отброшенная при округлении часть
            }
            
            Console.ReadKey();
        }
    }
}
