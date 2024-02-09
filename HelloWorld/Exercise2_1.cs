using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Exercise2_1
    {
        /*1- When you post a message on Facebook, depending on the number of people 
         * who like your post, Facebook displays different information.

If no one likes your post, it doesn't display anything.
If only one person likes your post, it displays: [Friend's Name] likes your post.
If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
If more than two people like your post, it displays: [Friend 1], [Friend 2] and 
        [Number of Other People] others like your post.
Write a program and continuously ask the user to enter different names, 
        until the user presses Enter (without supplying a name). 
        Depending on the number of names provided, display a message based on the above pattern.
        */
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
