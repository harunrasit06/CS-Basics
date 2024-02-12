using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;



namespace HelloWorld
{
    class Class10
    {
        static void Main(string[] args)
        {
            //LoremIpsumGenarator loremText = new LoremIpsumGenarator();
            //var sentenceLorem = loremText.LoremIpsum(20, 30, 5, 10, 1);
            //Console.WriteLine(sentenceLorem);

            var sentence = "This is going to be a really really really really really really really really really long text.";
            var summary = StringUtility.SummerizeText(sentence, 25);
            Console.WriteLine(summary);
        }

    }    
}
