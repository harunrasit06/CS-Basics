using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Exercise1
    {
        static void Main1(string[] args)
        {   
            var count = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("number is :" + i);
                    count++;
                    Console.WriteLine("Count: " + count);
                    continue;
                }
            }
        }
    }
}
