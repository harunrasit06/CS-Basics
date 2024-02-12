using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Exercise3_3
    {
        /*3- Write a program and ask the user to enter a time value 
         * in the 24-hour time format (e.g. 19:00). A valid time should be 
         * between 00:00 and 23:59. If the time is valid, display "Ok"; 
         * otherwise, display "Invalid Time". If the user doesn't provide any values, 
         * consider it as invalid time.
         */
        static void Main3(string[] args)
        {
            Console.WriteLine("Enter a time value in the 24-hour time format (e.g. 19:00):");
            //var userInput = Console.ReadLine();
            var userFirstInput = Console.ReadLine();
            try
            {
                var userInput = Convert.ToDateTime(userFirstInput);
                var shortUserInput = userInput.ToString("HH:mm");
                Console.WriteLine(shortUserInput);
                
                Console.WriteLine("Ok");
                
            }catch (Exception ex)
            {
                Console.WriteLine("Invalid Time!");
            }
            //var index = userInput.IndexOf(":");
            //var hours = userInput.Substring(0, index);
            //var minutes = userInput.Substring(index + 1);
            
            
            

        }
    }
}
