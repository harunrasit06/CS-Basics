using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Class12
    {
        static void Main12(string[] args)
        {
            var path = @"c:\somefile.jpg";

            File.Copy(@"c:\temp\myfile.txt", @"c:\temp2\myfile.txt", true);  //ohne @, muss \\ schreiben
            File.Delete(path);

            if(File.Exists(path))
            {
                //
            }
            var content = File.ReadAllBytes(path);

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if(fileInfo.Exists) { 
                //
            }
            

        }
    }
}
