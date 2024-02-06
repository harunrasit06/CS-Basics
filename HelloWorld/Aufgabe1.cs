using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Aufgabe1
    {
        static void Main3(string[] args)
        {
            Console.WriteLine("Write a number: \n");
            var userInput = int.Parse(Console.ReadLine());


            if (userInput > 0 && userInput < 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }


        }
    }
}
