using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Aufgabe1
    {
        /*1- Write a program and ask the user to enter a number.
         * The number should be between 1 to 10. If the user enters a valid number, 
         * display "Valid" on the console.Otherwise, display "Invalid". (This logic 
         * is used a lot in applications where values entered into input boxes need to be validated.)
         */
        static void Main1(string[] args)
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
