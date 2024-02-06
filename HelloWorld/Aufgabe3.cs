using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Aufgabe3
    {
        static void Main3(string[] args)
        {
            Console.WriteLine("Write width :");
            int witdh = int.Parse(Console.ReadLine());

            Console.WriteLine("Write height :");
            int height = int.Parse(Console.ReadLine());

            string image = witdh > height ? "landscape" : "portrait";
            Console.WriteLine(image);
        }
    }
}
