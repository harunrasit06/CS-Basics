using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Exercise3_2
    {
        /*2- Write a program and ask the user to enter a few numbers separated by a hyphen.
         * If the user simply presses Enter, without supplying an input, exit immediately; 
         * otherwise, check to see if there are duplicates.If so, display "Duplicate" on the console.
         */
        static void Main2(string[] args)
        {
            Console.WriteLine("Please write a few numbers  separated by hyphen  : ");
            var userInputs = "";




            userInputs = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(userInputs))
            {
                Console.WriteLine("Invalid Entry");
                return;
            }

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
            bool isDuplicate = false;
            for (int i = 0; i < inputToInt.Length; i++)
            {
                for (int j = i + 1; j < inputToInt.Length; j++)
                {

                    if (inputToInt[i] == inputToInt[j])
                    {
                        isDuplicate = true;
                        //Console.WriteLine("Duplicate!");
                        //break;

                    }
                    
                    

                }


            }
                if (isDuplicate)
                {
                    Console.WriteLine("Duplicate!");

                }
                else { Console.WriteLine("No Duplicate!"); }


        }
    }
}
