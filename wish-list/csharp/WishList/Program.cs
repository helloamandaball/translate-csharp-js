// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//Start with the Intro code from Ch.2 for outer shell. 
using System;

namespace WishList
{
    class Program
    {
        //Main is like saying fuction main() in the JS
        static void Main(string[] args)
        {
            Console.WriteLine("My wishes...");

            //create an array of the wishes:
            List<string> IWishFor = new List<string> () 
            {
                "An original eight track of William Shatner's 'Lucy in the Sky with Diamonds'",
                "The ability to think of interesting wishes on short notice",
                "A washtub of Skittles",
                "World peace, but not the kind of world peace where all the humans are removed from existence",
                "A TV that is NOT internet-capable",
                "The ability to fly, but, like, really fast...not just, like, how fast I can walk, but, like, fast, you know?"
            };

            //create foreach loop here, instead of just a for loop from the JS file. The <string> means ??? but it is acting like the 'const' in the JS code:
            foreach (string wish in IWishFor) 
            {
                Console.WriteLine($"{wish}");
            }

        }
    }
}
