using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Aufgabe2
    {
        static void Main4(string[] args)
        {
            var userInput1 = int.Parse(Console.ReadLine());
            var userInput2 = int.Parse(Console.ReadLine());

            var max = userInput1 > userInput2 ? userInput1 : userInput2;
            Console.WriteLine(max);
            //if (userInput1 > userInput2)
            //{
            //    Console.WriteLine("Max number is : " + userInput1);
            //}
            //else { Console.WriteLine("Max number is : " + userInput2); }
        }
    }
}
