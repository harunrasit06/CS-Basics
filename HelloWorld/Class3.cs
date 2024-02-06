using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal partial class Class3
    {
        static void Main1(string[] args)
        {
            //int hour = 10;

            //if (hour > 0 && hour < 12)
            //{
            //    Console.WriteLine("Good Morning!");
            //}
            //else if (hour >= 12 && hour < 18)
            //{
            //    Console.WriteLine("Afternoon");
            //}
            //else
            //{
            //    Console.WriteLine("Evening");
            //}

            //bool isGoldCustomer = true;
            //float price;
            //if (isGoldCustomer) price = 19.95f;
            //else price = 29.95f;
            //// short if statement
            //float price2 = (isGoldCustomer) ? 19.95f : 29.95f;

            //Console.WriteLine($"{price}, {price2} ");
            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It includes 9,10,11");
                    break;
                case Season.Summer: Console.WriteLine("It includes 6,7,8");
                    break;
                case Season.Winter:
                case Season.Spring:
                    Console.WriteLine("It includes 12,1,2,3,4,5");
                    break;
                default: Console.WriteLine("All the excepts Mounths");
                    break;
            }
        }
    }
}
