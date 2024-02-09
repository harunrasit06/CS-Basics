using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Exercise2_3
    {
        /*3- Write a program and ask the user to enter 5 numbers. 
         * If a number has been previously entered, display an error message 
         * and ask the user to re-try. Once the user successfully enters 5 unique numbers, 
         * sort them and display the result on the console.
         */
        static void Main3(string[] args)
        {
            var numberList = new List<int> { };
            //var compareList = new List<string>();


            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Enter please 5 unique numbers, " + (i + 1) + ".number : ");
            //    numberList.Add(Console.ReadLine());
            //    if (numberList.Count > 0)
            //        for (int c = 0; c < i; c++)
            //        {
            //            if (numberList[c] == numberList[i])
            //            {
            //                Console.WriteLine("The number is not unique, Try Again!");
            //                numberList.RemoveAt(i);
            //                i--;
            //                continue;

            //            }
            //        }
                             
            //}
            
            while (numberList.Count < 5) {
                Console.WriteLine("Enter please 5 unique numbers, " + (numberList.Count +1) + ".number : ");
                int userInput = Convert.ToInt32(Console.ReadLine());
                
                if (numberList.Contains(userInput))
                {
                    Console.WriteLine("The number is not unique, Try Again!");
                    continue;
                }
                else { numberList.Add(userInput); }
               
            }

            numberList.Sort();
            Console.WriteLine("Sortiert List: ");
            foreach (var item in numberList)
            {
                Console.WriteLine(item);
            }


        }
    }
}
