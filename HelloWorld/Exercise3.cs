using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Exercise3
    {
        /*3- Write a program and ask the user to enter a number. 
         * Compute the factorial of the number and print it on the console. 
         * For example, if the user enters 5, the program should 
         * calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
         */
        static void Main3(string[] args)
        {
            Console.WriteLine("Please write a Number for factorial : ");
            var userInput = int.Parse(Console.ReadLine());
            var sum = 1;
            for (int i = 1; i <= userInput; i++)
            {
                sum = sum * i;
            }
            Console.WriteLine("Sum for factorial " + userInput + " is : " + sum);
        }
    }
}
