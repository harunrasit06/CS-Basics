using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Class11
    {
        static void Main11(string[] args)
        {
            var builder = new StringBuilder();

            
            builder
                .Append('-', 10)
                .AppendLine()
                .Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);

            builder.Replace('-', '+');
            builder.Remove(0, 10);
            builder.Insert(0, new string('-', 10)); 

            Console.WriteLine(builder);

            Console.WriteLine("First Char: " + builder[0]);
        }
    }
}
