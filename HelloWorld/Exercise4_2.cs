using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Exercise4_2
    {
        /*2- Write a program that reads a text file and displays the longest word in the file.*/
        static void Main(string[] args)
        {
            var file = File.ReadAllText(@"C:\temp\myfile.txt");
            var filewithoutSpace = file.Split(' ');
            //string[] words = new string[] { };
            //var count = 0;
            //Console.WriteLine("Kontrol");
            //foreach ( var item in file )
            //{
            //    Console.WriteLine(item);
            //}
            var maxWord = 0;
            var longestWord = "";
            //var itemlength = 0;
            foreach ( var item in filewithoutSpace)
            {   
                //itemlength = item.Length;
                if (item.Length > maxWord)
                {
                    //maxWord = itemlength;
                    longestWord = item;
                }
                //Console.WriteLine("Kontrol");
                //Console.WriteLine(item);
            }
            Console.WriteLine(longestWord);
            
        }
    }
}
