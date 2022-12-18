using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
            y1 = y4 -1;
            x2 = x1 + 1;
            y2 = y1;
            x3 = x2 ;
            y3 = y2 + 2;
            x4 = x3 - 4;
            y4 = y3;

            xcoord.Add(x1);
            xcoord.Add(x2);
            xcoord.Add(x3);
            xcoord.Add(x4);
            ycoord.Add(y1);
            ycoord.Add(y2);
            ycoord.Add(y3);
            ycoord.Add(y4);

            using (StreamWriter streamWriter = new StreamWriter("figura.html"))
            {
                streamWriter.WriteLine("<svg width=\"500\" height=\"500\">");
                streamWriter.Write($"<path stroke=\"blue\" fill=\"transparent\" stroke-width=\"4px\" d=\"M {2 + xcoord[0]*35 } {498 - ycoord[0]*35 } ");
                for (int i = 1; i<xcoord.Count; i++)
                {
                    streamWriter.Write($"L {2 + xcoord[i] * 35} {498 - ycoord[i] * 35} ");
                }
                streamWriter.WriteLine(" \"/>");
                streamWriter.WriteLine("</svg>");
            }
            
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
            float roomWidth = float.Parse(Console.ReadLine());

            Console.WriteLine("Введите длину комнат в мм, например 8000");
            float roomHeight = float.Parse(Console.ReadLine());

            Console.WriteLine("Введите шаг трубы в мм (расстояние межуд параллельными трубами), к примеру 200");
            float step = float.Parse(Console.ReadLine());

            int stripNumberX = (int)(roomWidth / step);
            Console.WriteLine("Количество полос по ости Х равно: " + stripNumberX);
            int stripNumberY = (int)(roomHeight / step);

            int knotNumberWidth = stripNumberX + 1;
            Console.WriteLine("Количество шагов по оси Х равно: " + knotNumberWidth);
            int knotNumberHeight = stripNumberY + 1;

            float[] xcoord = new float[knotNumberWidth];
            float[] ycoord = new float[knotNumberHeight];

            float tempUdlinenieХ = roomWidth / roomHeight;
            float tempUdlinenieY = roomHeight / roomWidth;
            float udlinenieX = 1;
            float udlinenieY = 1;

            if (tempUdlinenieY / tempUdlinenieХ > 1)
            {
                udlinenieY = tempUdlinenieY / tempUdlinenieХ;
            }
            else if (tempUdlinenieY / tempUdlinenieХ < 1)
            {
                udlinenieX = tempUdlinenieY / tempUdlinenieY;
            }
            else if (tempUdlinenieY == tempUdlinenieХ)
            {
                udlinenieX = 1;
                udlinenieY = 1;
            }


            float tempMarginesWidth = roomWidth - step * stripNumberX;
            float MarginesWidth = 0;

            float tempMarginesHeight = roomHeight - step * stripNumberY;
            float MarginesHeight = 0;

            if (tempMarginesWidth == 0)
            {
                MarginesWidth = step / 2;
                Console.WriteLine("Отступ труб от стены по ширине комнаты = " + (int)MarginesWidth);
            }
            else if (tempMarginesWidth < step)
            {
                MarginesWidth = (roomWidth - step * stripNumberX) / 2;
                Console.WriteLine("Отступ труб от стены по ширине комнаты = " + (int)MarginesWidth);
            }

            if (tempMarginesHeight == 0)
            {
                MarginesHeight = step / 2;
                Console.WriteLine("Отступ труб от стены по длине комнаты = " + (int)MarginesHeight);
            }
            else if (tempMarginesHeight < step)
            {
                MarginesHeight = (roomHeight - step * stripNumberY) / 2;
                Console.WriteLine("Отступ труб от стены по длине комнаты = " + (int)MarginesHeight);
            }

            xcoord[0] = MarginesWidth;
            ycoord[0] = 0;

            for (int i = 1; i < 5; i++)
            {
                xcoord[i] = xcoord[i - 1];
                xcoord[i + 1] = xcoord[i] + step * (knotNumberWidth - i);
                xcoord[i + 2] = xcoord[i + 1];
                xcoord[i + 3] = xcoord[i + 2] - step * (knotNumberWidth - i);
            }

            Console.WriteLine("X"); 
            foreach (float x in xcoord)
            {
                Console.WriteLine(x);
            }
        
            Console.ReadKey();
            
        }
    }
}

