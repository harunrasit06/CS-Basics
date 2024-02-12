using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Exercise3_1
    {
        /*1- Write a program and ask the user to enter a few numbers separated by a hyphen. 
         * Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" 
         * or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".
         */
        static void Main1(string[] args)
        {
            Console.WriteLine("Please write a list of hyphen separated a few numbers : ");
            var userInputs = "";
            var isConsecutive = true;
            do
            {
                userInputs = Console.ReadLine();

            } while (String.IsNullOrWhiteSpace(userInputs));

            Console.WriteLine("Kontrol:" + userInputs);

            var inputsWithoutHypen = userInputs.Split('-');
            int[] inputToInt = new int[inputsWithoutHypen.Length];

            var count = 0;
                foreach (var input in inputsWithoutHypen)
                {
                    inputToInt[count] = Convert.ToInt32(input);
                    Console.WriteLine("Kontrol input to int:" + inputToInt[count]);
                count++;

                }

            
            for (int i = 1; i < inputToInt.Length; i++)
            {
                if (inputToInt[i] != inputToInt[i - 1] + 1 && inputToInt[i] != inputToInt[i-1] - 1)
                { 
                    isConsecutive = false;
                    
                }
                
            }


            if (isConsecutive)
            {
                Console.WriteLine("Consecutive!");

            }
            else { Console.WriteLine("Mixed!"); }
            


        }
    }
}
