using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Class8
    {
        static void Main8(string[] args)
        {
            var timeSpan = new TimeSpan(1,0,0);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;   
            var end = DateTime.Now.AddMinutes(2);
            
            var duration = end - start; 
            Console.WriteLine("Duration: " +  duration);

            //Properties
            Console.WriteLine("Minutes : " + timeSpan.Minutes);
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

            //ADD
            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            //Subtract
            Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            //ToString
            Console.WriteLine("ToString " + timeSpan.ToString());
            // Parse
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));
        }
    }
}
