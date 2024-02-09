using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Exercise4
    {
        /*4- Write a program that picks a random number between 1 and 10. 
         * Give the user 4 chances to guess the number. 
         * If the user guesses the number, display “You won"; otherwise, 
         * display “You lost". (To make sure the program is behaving correctly, 
         * you can display the secret number on the console first.)
         */
        static void Main6(string[] args)
        {

            var number = new Random();
            var randomNumber = number.Next(1,10);

            for (int i = 4; i > 0; i--)
            {
                Console.WriteLine("Write your guess : ");
                var userGuess = int.Parse(Console.ReadLine());
                if (userGuess == randomNumber)
                {
                    Console.WriteLine("You won!");
                    break;
                }else { Console.WriteLine((i-1) + " guesses left" ); continue; }
            }

            Console.WriteLine("Random was: " + randomNumber + " You Lost!");
            
        }
    }
}
