using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Aufgabe4
    {
        /*4- Your job is to write a program for a speed camera. For simplicity, 
         * ignore the details such as camera, sensors, etc and focus purely on 
         * the logic. Write a program that asks the user to enter the speed limit. 
         * Once set, the program asks for the speed of a car. If the user enters a 
         * value less than the speed limit, program should display Ok on the console. 
         * If the value is above the speed limit, the program should calculate the 
         * number of demerit points. For every 5km/hr above the speed limit, 
         * 1 demerit points should be incurred and displayed on the console. 
         * If the number of demerit points is above 12, the program should display License Suspended.
         */
        static void Main4(string[] args)
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
