using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Aufgabe3
    {
        /*3- Write a program and ask the user to enter the width and height of an image. 
         * Then tell if the image is landscape or portrait.
         */
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
