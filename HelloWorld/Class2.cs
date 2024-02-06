using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Person2
    {
        public int Age;

    }
    class Class2
    {
        static void Main2(string[] args)
        {
            var number = 1;
            Increment(number);
            Console.WriteLine(number);

            var person = new Person2()
            {
                Age = 20
            };
            MakeOld(person); Console.WriteLine(person.Age);

            // References Types example
            //var a = 10;
            //var b = a;
            //b++;
            //Console.WriteLine(string.Format("a: {0} , b: {1}", a, b));

            //var array1 = new int[] { 1, 2, 3 };
            //var array2 = array1;
            //array2[0] = 0;
            //Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));

        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person2 person) {
            person.Age += 10;
        }
    }
}
