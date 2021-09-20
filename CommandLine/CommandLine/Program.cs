using System;
using System.Text;

namespace CommandLine
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < args.Length; i++)
            {
                builder.Append(args[i]);
                builder.Append(" ");
            }
            Console.WriteLine(builder.ToString());
            //Console.WriteLine(string.Join(" ", args));
            Console.ReadKey();
        }
    }
}

