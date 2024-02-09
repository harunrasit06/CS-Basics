using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Exercise5
    {
        /*5- Write a program and ask the user to enter a series of 
         * numbers separated by comma. Find the maximum of the numbers 
         * and display it on the console. For example, if the user 
         * enters “5, 3, 8, 1, 4", the program should display 8.
         */
        static void Main5(string[] args)
        {
            Console.WriteLine("Write a series of the numbers(separated by comma) : ");
            var userInputs = Console.ReadLine();
            var userArray = 
                userInputs.Split(',');
            Console.WriteLine(userInputs);  //Kontrolle 1,2,3
            
            var max = Convert.ToInt32(userArray[0]);

            foreach (var item in userArray)    // KOntrolle
            {
                var number = Convert.ToInt32(item);
                if (number > max) {  max = number; }

            }
            Console.WriteLine("Max is : " + max);


            /*int c = 0;  
            
            foreach (var item in userInputs)
            {
                userArray[c] = item;
                c++;
                                                          
            }*/


        /*for(var i = 0;i < userArray.Length; i++)    //Kontrolle
        {
            Console.WriteLine(userArray[i]);
        }*/

        //var max2 = userArray.Max();
        //Console.WriteLine("Max is : " + Convert.ToChar(max2));


    }
}
}
