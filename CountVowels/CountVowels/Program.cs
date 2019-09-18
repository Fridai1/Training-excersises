using System;

namespace CountVowels
{
    class Program
    {
        static void Main(string[] args)
        {
            VowelCounter counter = new VowelCounter();
            
            Console.WriteLine("please enter a word with vowels");
            string word = Console.ReadLine();
            Console.WriteLine(counter.Count(word));

            Console.ReadLine();
        }
    }
}
