﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Exercise2_5
    {
        /*5- Write a program and ask the user to supply a list of comma separated numbers 
         * (e.g 5, 1, 9, 2, 10). If the list is empty or includes less than 5 numbers, 
         * display "Invalid List" and ask the user to re-try; otherwise, 
         * display the 3 smallest numbers in the list.
         */
        static void Main5(string[] args)
        {
            Console.WriteLine("Please write a list of comma separated 5 or more numbers : ");
            var numberInt = new List<int>();
            string quit = "";
            var userInput = "";
            do
            {
                
             var userInputs = Console.ReadLine();
             var listWithoutComma =
             userInputs.Split(',');
                foreach (var item in listWithoutComma)  //Konrolle
                {
                    Console.WriteLine(item);
                }
                                
                if (listWithoutComma.Length < 5){
                    Console.WriteLine("Invalid List, try again.");
                    Array.Clear(listWithoutComma, 0 , listWithoutComma.Length);
                    continue;
                }
                else
                {   
                    foreach (var item in listWithoutComma) {  numberInt.Add(Convert.ToInt32(item)); }

                    numberInt.Sort();
                    Console.WriteLine("kontrol für sort:");
                    foreach (var item in numberInt)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("the 3 smallest numbers : ");
                    for (var i = 0; i < 3; i++)
                    {
                        Console.WriteLine(numberInt[i]);

                    }

                }

            } while (userInput != quit);

            
        }
    }
}
