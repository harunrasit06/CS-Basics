using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Class9
    {
        static void Main9(string[] args)
        {
            //Trim
            var fullName = "Harun Aktas ";
            Console.WriteLine("Trim : '{0}'", fullName.Trim());
            Console.WriteLine("Trim : '{0}'", fullName.Trim().ToUpper());

            //Substring
            var index = fullName.IndexOf(' ');  
            var firstName = fullName.Substring(0, index);   
            var lastName = fullName.Substring(index + 1);   
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

            //Split
            var names = fullName.Split(' ');

            foreach ( var name in names ) { Console.WriteLine(name); }

            //Replace
            Console.WriteLine(fullName.Replace("Harun", "Rasit") ); 

            if (String.IsNullOrEmpty(null) ) { Console.WriteLine("Invalid1");  } // or empty ""
            if (String.IsNullOrWhiteSpace("") ) { Console.WriteLine("Invalid2"); }

            //String to number convert

            var str = "27";
            Convert.ToInt32(str);

            float price = 29.95f;
            //price.ToString("C");
            Console.WriteLine(price.ToString("C0"));


        }
    }
}
