using System;

namespace Pig_latin
{
    class Program
    {
        
        static void Main(string[] args)
        {
            PigLatinGenerator generator = new PigLatinGenerator();
            Console.WriteLine("Hello World!");
            Console.WriteLine("please enter a word");
            string word = Console.ReadLine();

            Console.WriteLine(generator.Generate(word));

            Console.ReadLine();
        }
    }
}
