using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Exercise3_4
    {
        static void Main4(string[] args)
        {
            Console.WriteLine("Enter a few words separated by a space : ");
            var userInput = Console.ReadLine();
            var inputWithoutSpace = userInput.Split(' ');
            string[] elements = inputWithoutSpace.ToArray();
            //Console.WriteLine("Kontrol");
            //foreach (var item in elements)
            //{
            //    Console.WriteLine(item);
            //}
            var count = 0;
            foreach (var item in inputWithoutSpace) 
            {
                elements[count] = item.ToUpper();
                //Console.WriteLine("Kontrol : " + elements[count]);
                count++;
            }
            
            foreach (var item in elements)
            {   
                var firstCase = item.ElementAt(0);
                //Console.WriteLine(firstCase);
                var pascalCase = item.Substring(1);

                Console.Write(firstCase + pascalCase.ToLower());
            }
            Console.WriteLine();
        }
    }
}
