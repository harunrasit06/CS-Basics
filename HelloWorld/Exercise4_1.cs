using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Exercise4_1
    {
        /*1- Write a program that reads a text file and displays the number of words.*/
        static void Main1(string[] args)
        {
            var filePath = Path.GetFullPath(@"C:\temp\myfile.txt");
            var fileContent = File.ReadAllText(filePath);

            var contentWithoutSpace = fileContent.Split(' ');
            var count = 1;
            foreach (var item in contentWithoutSpace)
            {
                Console.WriteLine(item);
                count++;
            }
            Console.WriteLine("Number of Words: " + count);
            
        }
    }
}
