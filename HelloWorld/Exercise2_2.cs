using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Exercise2_2
    {
        /*2- Write a program and ask the user to enter their name. 
         * Use an array to reverse the name and then store 
         * the result in a new string. Display the reversed name on the console.
         */
        static void Main2(string[] args)
        {
            Console.WriteLine("Enter your name : ");
            string name = Console.ReadLine();

            Console.WriteLine("Your name is : " + name);

            char[] chars = name.ToCharArray();
            Array.Reverse(chars);
            string reversedName = new string(chars);    
            
            Console.WriteLine("Your reverse name is : " + reversedName);

        }
    }
}
