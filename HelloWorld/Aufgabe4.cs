using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Aufgabe4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Write Speed Limit for Cars");
            int speedLimit = int.Parse(Console.ReadLine());
            Console.WriteLine("Speed Limit is " + speedLimit);
            Console.WriteLine("What is the Carspeed? : ");
            int carSpeed = int.Parse(Console.ReadLine());
            if (carSpeed >= speedLimit)
            {
                var demerit = carSpeed - speedLimit;
                var points = demerit / 5;
                Console.WriteLine("Demerit Points: " + points);
                if (points > 12) { Console.WriteLine("License Suspended!"); }

            }
            else { Console.WriteLine("O.K."); }
             
        }
    }
}
