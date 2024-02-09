using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Exercise2_1
    {
        static void Main1(string[] args)
        {
            var likedPeople = new List<string>();
            while (true)
            {
                Console.WriteLine("Enter different names, who likes your post : ");
                
                likedPeople.Add(Console.ReadLine());
                if (likedPeople.Count <= 0 || likedPeople.Contains(""))
                    break;
                
            }
            if (likedPeople.Count <= 1 && likedPeople.Contains(""))
            {
                Console.WriteLine("No one likes your post, it doesn't display anything");
            }
            else if (likedPeople.Count == 2)
            {
                Console.WriteLine(likedPeople[0]  + " like your post");
            }
            else if (likedPeople.Count == 3)
            {
                Console.WriteLine(likedPeople[0] + " and " + likedPeople[1] + " like your post");
            }
            else if (likedPeople.Count > 3)
            {
                Console.WriteLine(likedPeople[0] + " ," + likedPeople[1] + " and " + (likedPeople.Count - 3) + " others like your post");
            }
        }
    }
}
