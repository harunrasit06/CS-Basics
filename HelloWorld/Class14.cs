using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Class14
    {
        static void Main14(string[] args)
        {
            var path = @"C:\Tosca_Projects\ToscaCommander\Standard.tsu";

            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(0, dotIndex);

            Console.WriteLine("Extension : " + Path.GetExtension(path));
            Console.WriteLine("File Name : " + Path.GetFileName(path));
            Console.WriteLine("File Name without Extension : " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory Name : " + Path.GetDirectoryName(path));
        }
    }
}
