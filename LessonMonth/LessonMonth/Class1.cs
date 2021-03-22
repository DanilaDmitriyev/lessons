using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonMonth
{
    enum OneMoreEnum
    {
        Раз,
        Два,
        Три,
        Четыре,
        Пять
    }
    class Class1
    {
        public Class1() { }
        
        static public void PrintEnum()
        {
            foreach (string x in Enum.GetNames(typeof(OneMoreEnum))) Console.WriteLine(x);
        }
    }
}
