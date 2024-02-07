using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Exercise3
    {
        static void Main3(string[] args)
        {
            Console.WriteLine("Please write a Number for factorial : ");
            var userInput = int.Parse(Console.ReadLine());
            var sum = 1;
            for (int i = 1; i <= userInput; i++)
            {
                sum = sum * i;
            }
            Console.WriteLine("Sum for factorial " + userInput + " is : " + sum);
        }
    }
}
