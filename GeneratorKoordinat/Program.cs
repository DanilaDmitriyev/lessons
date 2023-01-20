using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace GeneratorKoordinat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
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
            */

            Console.WriteLine("Введите ширину комнаты в мм (шириной считаем меньшую сторону прямоугольника комнаты), например 4000");
            string inputRW = Console.ReadLine();
            float roomWidthY = String.IsNullOrEmpty(inputRW) ? 4000 : float.Parse(inputRW); //ввод значения по умолчанию через Enter
            

            Console.WriteLine("Введите длину комнаты в мм (длиной считаем большую сторону прямоугольника комнаты), например 4000");
            string inputRH = Console.ReadLine();
            float roomHeightX = String.IsNullOrEmpty(inputRH) ? 4000 : float.Parse(inputRH);


            Console.WriteLine("Введите шаг трубы в мм (расстояние межуд параллельными трубами), к примеру 200");
            string inputS = Console.ReadLine();
            float step = String.IsNullOrEmpty(inputS) ? 200 : float.Parse(inputS);
            

            int stripNumber = (int)(roomWidthY / step);
            Console.WriteLine("Количество полос по ости Y или X равно: " + stripNumber);
            
            
            
            float[] xcoord = new float[stripNumber + 1];
            float[] ycoord = new float[stripNumber + 1];

            
            float tempMarginesWidthY = roomWidthY - step * stripNumber;
            float marginesWidthY = 0;

            if (tempMarginesWidthY == 0)
            {
                marginesWidthY = step / 2;
                Console.WriteLine("Отступ труб от стены по ширине комнаты = " + (int)marginesWidthY);
            }
            else if (tempMarginesWidthY < step)
            {
                marginesWidthY = (roomWidthY - step * stripNumber) / 2;
                Console.WriteLine("Отступ труб от стены по ширине комнаты = " + (int)marginesWidthY);
            }

            float marginesHeightX = step / 2;
            float stepX = (roomHeightX - step) / stripNumber;

            xcoord[0] = marginesWidthY;
            
            ycoord[0] = marginesHeightX;
           

            for (int i = 1; i < stripNumber + 1; i+=4)
            {
                xcoord[i] = xcoord[i - 1];
                xcoord[i + 1] = xcoord[i] + step * (stripNumber - i); 
                xcoord[i + 2] = xcoord[i + 1];
                xcoord[i + 3] = xcoord[i + 2] - step * (stripNumber -2 -i);
            }

            for (int i = 1; i < stripNumber + 1; i += 4)
            {
                ycoord[i] = ycoord[i-1] + step * (stripNumber - i);
                ycoord[i + 1] = ycoord[i]; 
                ycoord[i + 2] = ycoord[i + 1] - step * (stripNumber -2 - i);
                ycoord[i + 3] = ycoord[i + 2];
            }

            Console.WriteLine("шаг = " + step);
            Console.WriteLine("X"); 
            foreach (float x in xcoord)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("Y");
            foreach (float y in ycoord)
            {
                Console.WriteLine(y);
            }
            Console.ReadKey();
            


        }
        
    }
}

