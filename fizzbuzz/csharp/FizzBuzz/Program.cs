using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**This is FizzBuzz**");
            Console.WriteLine("--------------------");

            /*From Wikipedia link: 
                https://en.wikipedia.org/wiki/Fizz_buzz

                Fizz buzz is a group word game for children to teach them about division. Players take turns to count incrementally, replacing any number divisible by three with the word "fizz", and any number divisible by five with the word "buzz".
            */

            /* Changes from the JS version:
                -change let to int
                -change all console.log to Console.WriteLine
                -C# only uses 2 == instead of 3 ===
            */
            
            for(int n=1; n<=100; n++) {
                if (n % 15 == 0) {
                    Console.WriteLine("fizzbuzz");
                } else if (n % 3 == 0) {
                    Console.WriteLine("fizz");
                } else if (n % 5 == 0) {
                    Console.WriteLine("buzz");
                } else {
                    Console.WriteLine(n);
                }
            }
        }
    }
}

