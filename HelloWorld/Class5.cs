using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Class5
    {
        static void Main5(string[] args)
        {
            var random = new Random();

            const int passwordLength = 10;
            var buffer = new char[passwordLength];

            for (int i = 0; i < passwordLength; i++)
                buffer[i] = (char)('a' + random.Next(0,26));

            var password = new string(buffer);
            Console.WriteLine(password);
            
            
        }
    }
}
