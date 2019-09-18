namespace Pig_latin
{
    public class PigLatinGenerator
    {
        public string Generate(string word)
        {
            string firstLetter = word.Substring(0,1);
            string alteredWord = word.Remove(0, 1);
            switch (firstLetter)
            {
                case "a":
                {

                    return alteredWord + $"-{firstLetter}ay";
                }

                case "b":
                {
                    return alteredWord + $"-{firstLetter}ay";
                }

                case "c":
                {
                    return alteredWord + $"-{firstLetter}ay";
                }

                case "d":
                {
                    return alteredWord + $"-{firstLetter}ay";
                }

                case "e":
                {
                    return alteredWord + $"-{firstLetter}ay";
                }

                case "f":
                {
                    return alteredWord + $"-{firstLetter}ay";
                }

                case "g":
                {
                    return alteredWord + $"-{firstLetter}ay";
                }

                case "h":
                {
                    return alteredWord + $"-{firstLetter}ay";
                }

                case "i":
                {
                    return alteredWord + $"-{firstLetter}ay";
                }

                case "j":
                {
                    return alteredWord + $"-{firstLetter}ay";
                }

                case "k":
                {
                    return alteredWord + $"-{firstLetter}ay";
                }

                case "l":
                {
                    return alteredWord + $"-{firstLetter}ay";
                }
                case "m":
                {
                    return alteredWord + $"-{firstLetter}ay";
                }

                case "n":
                {
                    return alteredWord + $"-{firstLetter}ay";
                }

                case "o":
                {
                    return alteredWord + $"-{firstLetter}ay";
                }

                case "p":
                {
                    return alteredWord + $"-{firstLetter}ay";
                }

                case "q":
                {
                    return alteredWord + $"-{firstLetter}ay";
                }

                case "r":
                {
                    return alteredWord + $"-{firstLetter}ay";
                }

                case "s":
                {
                    return alteredWord + $"-{firstLetter}ay";
                }

                case "t":
                {
                    return alteredWord + $"-{firstLetter}ay";
                }

                case "u":
                {
                    return alteredWord + $"-{firstLetter}ay";
                }

                case "v":
                {
                    return alteredWord + $"-{firstLetter}ay";
                }

                case "w":
                {
                    return alteredWord + $"-{firstLetter}ay";
                }

                case "x":
                {
                    return alteredWord + $"-{firstLetter}ay";
                }

                case "y":
                {
                    return alteredWord + $"-{firstLetter}ay";
                }

                case "z":
                {
                    return alteredWord + $"-{firstLetter}ay";
                }
                default:
                {
                    return "thats not a word";
                }
            }

            return "this shouldnt be reached";
        }
    }
}