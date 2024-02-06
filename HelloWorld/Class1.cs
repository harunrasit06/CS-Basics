using System;
using HelloWorld.Math;

namespace HelloWorld
{
    public enum ShippingMethod
    {
        RugularAirMail = 1,
        RegisterAirMail =2,
        Express = 3
    }

    class Class1
    {
        static void OldMain()
        {
            var method = ShippingMethod.RugularAirMail;
            Console.WriteLine((int)method);

            var methodId = 2;
            Console.WriteLine((ShippingMethod)methodId);

            var methodName = "Express";

            var shippingMethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(shippingMethod);
            //var john = new Person();
            //john.FirstName = "John";
            //john.LastName = "Smith";
            //john.Introduce();

            //Calculator calculator = new Calculator();
            //var result = calculator.Add(1, 2);
            //Console.WriteLine(result);

            //int[] numbers = new int[] { 1, 2, 3 };

//            var firstName = "Mosh";
//            var lastNane = "Hama";
            

//            var fullName = firstName + lastNane;


//            var myFullName = string.Format("My name is {0} {1}", fullName, firstName);


//            var names = new string[3] { "John", "Jack", "Mary" };

//            var formattedNames = string.Join(", ", names);

//            Console.WriteLine(formattedNames);

//            //@ macht easier, sonst muss man escape Charecter nutzen.
//            var text = @"Hi John        
//Look into the followig paths
//c:\folder\folder2
//c:\folder3\folder4";
//            Console.WriteLine(text);
            

        }
    }
}
