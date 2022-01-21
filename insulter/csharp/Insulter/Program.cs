// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace Insulter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let me insult you...");
            Console.WriteLine("");

            //Create a collection of insults
            List<string> Insults = new List<string> () 
            {
                "You look like what morning breath smells like.",
                "If you tried to give me cpr I would probably throw myself back under water",
                "I am not a fan of you",
                "You think you're so special...and you are. The fact of your existence is nearly impossible to believe",
                "I'd rather walk than be on the same plane as you",
                "If I were given a million dollars to hang out with you...I would, but then I'd have to spend half of it on therapy",
                "Do you have to be so...like that?"
            };

            //Random generator for 3 numbers (indexes)
            List<int> Indexes = new List<int> ()
            {
                //What goes in here??? Nothing! This is like your empty array, and a number gets generated and added into it.
            };
            
            //.Count is the same as .length in JS
            while (Indexes.Count <3) 
            {
                // .Next(minimum number of insults "0", maximum number of insults "6". Adding -1 at the end so it doesn't come back as 0?)
                int randomNum = new Random().Next(0, Insults.Count -1);
                //.Any evalutes to true, the ! bang does something
                if(!Indexes.Any(number => number == randomNum)) {
                    Indexes.Add(randomNum);
                };
            };

            //loop through the generated numbers and pull out the 3 insults in those positions
            foreach (int Index in Indexes)
            {
                Console.WriteLine(Index); //this just pulls the actual index number out before displaying the actual insult in that number position below.
                Console.WriteLine(Insults[Index]);
            };
        }
    }
}
