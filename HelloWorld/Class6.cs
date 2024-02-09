using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Class6
    {
        static void Main6(string[] args)
        {
            var numbers = new[] { 3, 2, 9, 4, 7, 1, 23};

            //Length
            Console.WriteLine("Length : " + numbers.Length);

            //IndexOf()
            
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9 : " + index);

            //Clear
            Array.Clear(numbers, 0, 2);

            foreach (var item in numbers)   // IN Boolean element clearing to False,
            {                               // Strings and other clearing to Default value of the type's fields
                Console.WriteLine(item);    // All int and float to 0
            }                               // DateTime clearing to DateTime.MinValue

            //Copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);
            Console.WriteLine("Effect of Copy()");
            foreach (var item in another)
            {
                Console.WriteLine(item);
            }

            //Sort()
            Array.Sort(numbers);
            Console.WriteLine("Effect of Sort()");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            //Reverse()
            Array.Reverse(numbers);
            Console.WriteLine("Effect of Revers()");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

        }
    }
}
