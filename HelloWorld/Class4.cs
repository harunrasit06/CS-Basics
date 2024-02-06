using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            for (int i = 10;i >= 0; i--)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            var name = "John Smith";
            var numbers = new int[] { 1,2,3,4};
            foreach (var item in name)
            {
                Console.WriteLine(item);
            }
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
