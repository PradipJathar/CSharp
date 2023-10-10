using System;
using System.Linq;

namespace System
{
    public static class StringExtensions
    {
        public static string Shorten(this String str, int numberOfWords)
        {
            if (numberOfWords < 0)
            {
                throw new ArgumentOutOfRangeException("numberOfWords", "Number of words should be greater than or equal to 0.");
            }

            if (numberOfWords == 0)
            {
                return "";
            }

            string[] words = str.Split(' ');

            if (words.Length <= numberOfWords)
            {
                return str;
            }

            return String.Join(" ", words.Take(numberOfWords)) + "...";
        }
    }
}
