using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GeneratorSpirali
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter streamWriter = new StreamWriter("spirali.html"))
            {
                //streamWriter.WriteLine(@"<svg width=""500"" height=""200"">" );
                streamWriter.WriteLine("<svg width=\"500\" height=\"200\">");
                streamWriter.WriteLine("</svg>");
            }

        }
    }
}
