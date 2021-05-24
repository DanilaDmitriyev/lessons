using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class River
    {
        public string name;
        public int length;
        public int depth;

        
        
    }
    
    
    class Program
    {

        static int CompareByName (River river1, River river2)
        {
            return river1.name.CompareTo(river2.name);
        }
        
        static void Main(string[] args)
        {

            

            List<River> rivers = new List<River>();

            rivers.Sort(CompareByName);//Отсортировали список по имени реки.
        
        }
    }
}//Сравнить реки по другим критериям и сделать ввод и вывод данных (пользователь ввёл несколько рек и программа отсортировала и вывела на экран). Реку переопределить tostring.