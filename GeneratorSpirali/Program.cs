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
                streamWriter.WriteLine("<svg width=\"500\" height=\"202\">");
                streamWriter.WriteLine("<polyline stroke=\"blue\" stroke-width=\"4px\" points=\"0,0, 500,200\"/>");
                streamWriter.WriteLine("<polyline stroke=\"blue\" stroke-width=\"4px\" points=\"500,0, 0,200\"/>");
                streamWriter.WriteLine("<path stroke=\"blue\" fill=\"transparent\" stroke-width=\"4px\" d=\"M 2 0 C 2 50, 2 200, 250 200\"/>");
                streamWriter.WriteLine("</svg>");
            }

        }
    }
}
