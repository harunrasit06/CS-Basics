using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Exercise2
    {
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
