using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Class13
    {
        static void Main13(string[] args)
        {
            Directory.CreateDirectory(@"c:\temp3");
            var files = Directory.GetFiles(@"c:\Tosca_Projects", "*.*", SearchOption.AllDirectories);
            foreach (var item in files)
            {
                Console.WriteLine(item);
            }

            var directories = Directory.GetDirectories(@"c:\Tosca_Projects", "*.*", SearchOption.AllDirectories);
            foreach (var d in directories) { 
            Console.WriteLine(d);}

            Directory.Exists("...");

            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
        }
    }
}
