using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace WordFrequency
{
    class Program
    {
        /*
            Count the occupance of each word in Carl Sagan's famous description of the Pale Blue Dot.
            https://en.wikipedia.org/wiki/Pale_Blue_Dot

            NOTES:
            You might want to research the Dictionary type in C#, including the ContainsKey() method.

            In order to remove punctuation from a string in C#, use the Regex class.

            First you must use the proper namespace.
                Example: using System.Text.RegularExpressions;

            Then later in your code you can do something like this:
                Example: string s1 = Regex.Replace(s, "[^A-Za-z ]", "");
        */
        static void Main(string[] args)
        {
            //Instead of double double-quotes, you can also do \"superstar"\
            string text = @"Look again at that dot. That's here. That's home. That's us. On it everyone you love, everyone you know, everyone you ever heard of, every human being who ever was, lived out their lives. The aggregate of our joy and suffering, thousands of confident religions, ideologies, and economic doctrines, every hunter and forager, every hero and coward, every creator and destroyer of civilization, every king and peasant, every young couple in love, every mother and father, hopeful child, inventor and explorer, every teacher of morals, every corrupt politician, every ""superstar,"" every ""supreme leader,"" every saint and sinner in the history of our species lived there--on a mote of dust suspended in a sunbeam.

            The Earth is a very small stage in a vast cosmic arena. Think of the rivers of blood spilled by all those generals and emperors so that, in glory and triumph, they could become the momentary masters of a fraction of a dot. Think of the endless cruelties visited by the inhabitants of one corner of this pixel on the scarcely distinguishable inhabitants of some other corner, how frequent their misunderstandings, how eager they are to kill one another, how fervent their hatreds.

            Our posturings, our imagined self-importance, the delusion that we have some privileged position in the Universe, are challenged by this point of pale light. Our planet is a lonely speck in the great enveloping cosmic dark. In our obscurity, in all this vastness, there is no hint that help will come from elsewhere to save us from ourselves.

            The Earth is the only world known so far to harbor life. There is nowhere else, at least in the near future, to which our species could migrate. Visit, yes. Settle, not yet. Like it or not, for the moment the Earth is where we make our stand.
            
            It has been said that astronomy is a humbling and character-building experience. There is perhaps no better demonstration of the folly of human conceits than this distant image of our tiny world. To me, it underscores our responsibility to deal more kindly with one another, and to preserve and cherish the pale blue dot, the only home we've ever known.
            - Carl Sagan";

            //This code: /[^a-zA-Z ]/g is a regular expression, it's taking all the text and will ignore all punctuation like . , ' and " :
            // string s1 = Regex.Replace(text, "/[^a-zA-Z ]/g ", "");
            string s1 = Regex.Replace(text, "[^A-Za-z ]", "");

            //string[] gets you the array of strings. Adding a space between the "" (as " ") says to split it on the space, basically.
            string[] words = s1.Split(" ");

            //Dictionary is a collect of key/value pairs:
            Dictionary<string, int> Text = new Dictionary<string, int>();

            //loop through "words" string, and if our dictionary doesn't contain the word we are at, its going to add a value of 1. If it does contain the word we are at then add 1 to the current value.
            foreach (string word in words)
            {
                //added this replace and regular expresion to get rid of the punctuation, don't need this bc we change it on line 41, and if(s2.Trim()...) now goes back to (word.Trim()...)
                // string s2 = Regex.Replace(word, "[^A-Za-z ]", "");

                //"if" is saying if its an empty string just skip it:
                if (word.Trim() == "") {
                    continue;
                }
                //after skipping the empty string, then use this to count the frequency of the word
                if (Text.ContainsKey(word))
                {   //If we already have the word, add 1 to the count
                    Text[word] += 1;
                }
                else
                {   //If we don't  have the word, assign a value of 1
                    Text[word] = 1;
                }
            }

            //Print it to the console:
            //Also could look like this: foreach(KeyValuePair<string, int> word in Text) instead of just using var
            foreach (var word in Text)
            {
                Console.WriteLine($"{word.Key}: {Text[word.Key]}");
            }
        }
    }
}
