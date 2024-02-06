using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Aufgabe2
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("Write first number: ");
            var userInput1 = int.Parse(Console.ReadLine());
            Console.WriteLine("First number is : " + userInput1);

            Console.WriteLine("Write second number: ");
            var userInput2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Second number is : " + userInput2);

            var max = userInput1 > userInput2 ? userInput1 : userInput2;
            Console.WriteLine("Max number is : " + max);
            //if (userInput1 > userInput2)
            //{
            //    Console.WriteLine("Max number is : " + userInput1);
            //}
            //else { Console.WriteLine("Max number is : " + userInput2); }
        }
    }
}
