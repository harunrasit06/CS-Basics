using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Exercise1
    {
        /*1- Write a program to count how many numbers between 1 and 100 
         * are divisible by 3 with no remainder.Display the count on the console.
         */
        static void Main1(string[] args)
        {   
            var count = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("number is :" + i);
                    count++;
                    Console.WriteLine("Count: " + count);
                    continue;
                }
            }
        }
    }
}
