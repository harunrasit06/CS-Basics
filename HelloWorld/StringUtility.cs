using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class StringUtility
    {
        public static string SummerizeText(string text, int maxLength = 20)
        {

            if (text.Length < maxLength)
            {
                return text;
            }
            else
            {
                var words = text.Split(' ');
                var totalCharactors = 0;
                var summaryWords = new List<string>();

                foreach (var word in words)
                {
                    summaryWords.Add(word);

                    totalCharactors += word.Length + 1;
                    if (totalCharactors > maxLength)
                    {
                        break;
                    }

                }
                return String.Join(" ", summaryWords) + "...";
            }

        }
    }
}
