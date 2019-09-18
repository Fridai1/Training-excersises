using System.Collections.Generic;

namespace CountVowels
{
    public class VowelCounter
    {
        public string Count(string word)
        {
            Dictionary<string, int> voweldDictionary = new Dictionary<string, int>()
            {
                {"a", 0}, {"e", 0}, {"i", 0}, {"o", 0}, {"u", 0},
            };
            int numberOfVowels = 0;
            char[] charArray = word.ToCharArray();
            foreach (var c in charArray)
            {
                if (voweldDictionary.ContainsKey(c.ToString()))
                {
                    voweldDictionary[c.ToString()]++;
                    numberOfVowels++;
                }
            }

            return
                $"there were a total of {numberOfVowels} vowels, out of those there where a: {voweldDictionary["a"]} e: {voweldDictionary["e"]} i: {voweldDictionary["i"]} o: {voweldDictionary["o"]} u: {voweldDictionary["u"]}";
        }
    }
}