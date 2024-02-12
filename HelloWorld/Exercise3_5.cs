using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Exercise3_5
    {
        /*5- Write a program and ask the user to enter an English word. 
         * Count the number of vowels (a, e, o, u, i) in the word. 
         * So, if the user enters "inadequate", the program should display 6 on the console.
         */
        static void Main5(string[] args)
        {
            Console.WriteLine("Enter an English word : ");
            var userInput = Console.ReadLine().ToLower();
            var count = 0;
            foreach (var item in userInput)
            {
                
                if (item == 'a' || item == 'e' || item == 'o' || item == 'u' || item == 'i')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
