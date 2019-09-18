using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcersiseConsoleAppBase
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("This small program will reverse any word or sentence you input");
            Console.WriteLine("Please type your word or sentence now");
            string input = Console.ReadLine();
            
            Console.WriteLine(Reverser(input));
            Console.ReadLine();


        }

        private static string Reverser(string input)
        {
            char[] chars = input.ToCharArray();
            string output = "";
            int length = chars.Length;

            for (int i = length-1; i >= 0; i--)
            {
                output += input[i];
            }

            return output;
        }
    }
}
