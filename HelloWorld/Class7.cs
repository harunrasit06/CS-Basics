using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Class7
    {
        static void Main7(string[] args)
        {
            //List
            var numbers = new List<int>() { 1,2,3};
            numbers.Add(4);
            numbers.AddRange(new int[4] { 1,5,6,7} );  //If you see the Enumerable, that meens you can Array and List use

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            //IndexOf
            
            Console.WriteLine("\nIndex of 1 : " + numbers.IndexOf(1));
            Console.WriteLine("Last Index of 1:" + numbers.LastIndexOf(1)); // Findet letzte Index

            //Count
            Console.WriteLine("Count: " + numbers.Count);

            //Remove
            numbers.Remove(1);      // Removed first 1 in List
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            numbers.Add(1);
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                    numbers.Remove(numbers[i]);
            }

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            //Clear
            numbers.Clear();
            Console.WriteLine("Count: " + numbers.Count);

        }


    }
}
