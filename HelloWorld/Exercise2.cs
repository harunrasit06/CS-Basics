using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Exercise2
    {
        /*2- Write a program and continuously ask the user to enter a number or 
         * "ok" to exit. Calculate the sum of all the previously entered numbers 
         * and display it on the console.
         */
        static void Main2(string[] args)
        {
            var sum = 0;
            //var userAntwort = "";

            

            //while (true)
            //{
            //    Console.WriteLine("Please write a number or type 'ok' to exit : ");
            //    var userInput = Console.ReadLine();
            //    if (userInput != "ok")
            //    {
            //        var userNumber = int.Parse(userInput);
            //        sum += userNumber;
            //        Console.WriteLine("Sum is : " + sum);

            //    }
            //    else { Console.WriteLine("Exit!");
            //        break;
            //    }
                
            //}
            
            do
            {
                Console.WriteLine("Please write a number or type 'ok' to exit : ");
                var userInput = Console.ReadLine();

                if (userInput != "ok")
                {
                    var userNumber = int.Parse(userInput);
                    sum += userNumber;
                    Console.WriteLine("Sum is : " + sum);

                }
                else { Console.WriteLine("Exit!");
                    break;
                }
                    
            } while (sum != 0) ;

            
        }
    }
}
