using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WriteToFile
{
    public class MyList <T> : IEnumerable<T> 
    {
        T[] values = null;
        int count = 0;
        int firstElement = 0;
        public void Add (T value)
        {
            if (values == null) { values = new T[4]; }
            if (values.Length <= count) 
            {
                T[] newValues = new T[values.Length * 2];
                for(int i = 0; i < count; i++)
                {
                    newValues[i+firstElement] = values[(i+ firstElement)%values.Length];
                }
                values = newValues;
            }
            values[(count + firstElement)%values.Length] = value; 
            count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i<count; i++) { yield return values[(i + firstElement) % values.Length]; }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();

        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {

            MyList<char> chars = new MyList<char>();
            chars.Add('a');
            chars.Add('b');
            chars.Add('c');
            chars.Add('d');
            chars.Add('e');
            chars.Add('f'); 
            chars.Add('g');
            chars.Add('i');
            chars.Add('j');
            chars.Add('k');

            using (StreamWriter myStream = new StreamWriter("myFile.txt"))

            foreach(char x in chars) { myStream.WriteLine(x); }


            Console.ReadKey();

        }

    }
}
