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
            Console.WriteLine("Количество полос по ости Y равно: " + stripNumber);
            
            int knotNumber = stripNumber + 1;
            Console.WriteLine("Количество шагов по оси Y равно: " + knotNumber);
            
            float[] xcoord = new float[knotNumber];
            float[] ycoord = new float[knotNumber];

            float udlinenieX = (float) Math.Round(roomHeightX / roomWidthY, 1);
            

            float tempMarginesWidth = roomWidthY - step * stripNumber;
            float marginesWidth = 0;

            float tempMarginesHeight = roomHeightX - step * stripNumber;
            float marginesHeight = 0;

            if (tempMarginesWidth == 0)
            {
                marginesWidth = step / 2;
                Console.WriteLine("Отступ труб от стены по ширине комнаты = " + (int)marginesWidth);
            }
            else if (tempMarginesWidth < step)
            {
                marginesWidth = (roomWidthY - step * stripNumber) / 2;
                Console.WriteLine("Отступ труб от стены по ширине комнаты = " + (int)marginesWidth);
            }

            if (tempMarginesHeight == 0)
            {
                marginesHeight = step / 2;
                Console.WriteLine("Отступ труб от стены по длине комнаты = " + (int)marginesHeight);
            }
            else if (tempMarginesHeight < step)
            {
                marginesHeight = (roomHeightX - step * stripNumber) / 2;
                Console.WriteLine("Отступ труб от стены по длине комнаты = " + (int)marginesHeight);
            }

            else if (tempMarginesHeight > step)
            {
                marginesHeight = step / 2;
                Console.WriteLine("Отступ труб от стены по длине комнаты = " + (int)marginesHeight);
            }

            xcoord[0] = marginesWidth;
            
            ycoord[0] = marginesHeight;
           

            for (int i = 1; i < knotNumber; i+=4)
            {
                xcoord[i] = xcoord[i - 1];
                xcoord[i + 1] = xcoord[i] + step * (knotNumber -1 - i) * udlinenieX + (tempMarginesHeight - marginesHeight)/(knotNumber + 1); //проблема в неверном расчёте (tempMarginesHeight - marginesHeight)/(knotNumber + 1)
                xcoord[i + 2] = xcoord[i + 1];
                xcoord[i + 3] = xcoord[i + 2] - step * (knotNumber - 3 -i) * udlinenieX - (step * udlinenieX - step) / (knotNumber) - (tempMarginesHeight - marginesHeight)/(knotNumber + 1);
            }

            for (int i = 1; i < knotNumber; i += 4)
            {
                ycoord[i] = ycoord[i-1] + step * (knotNumber - 1 - i);
                ycoord[i + 1] = ycoord[i]; 
                ycoord[i + 2] = ycoord[i + 1] - step * (knotNumber - 3 - i);
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

