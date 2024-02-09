using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Exercise2_4
        { 
        static void Main4(string[] args)
        {
            var numberList = new List<string> { };
            string quit = "Quit";
            var userInput = "";
            do
            {
                Console.WriteLine("Enter a number or type 'Quit' : ");
                userInput = Console.ReadLine();
                
                if (numberList.Contains(userInput))
                {
                    numberList.Remove(userInput);
                    //uniqueList.Add(userInput);
                    //continue;
                }
                else { numberList.Add(userInput); }


            }while (userInput != quit);
            numberList.Remove("Quit");
            Console.WriteLine("Here are all unique numbers you entered: ");
            foreach (var item in numberList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
