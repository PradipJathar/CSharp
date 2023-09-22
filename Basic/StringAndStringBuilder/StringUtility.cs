using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndStringBuilder
{
    public class StringUtility
    {
        public static string SummerizeText(string text, int maxLength = 20)
        {
            if (text.Length < maxLength)
            {
                return text;
            }

            string[] words = text.Split(' ');
            int totalCharacters = 0;
            List<string> summaryWords = new List<string>();

            foreach (var word in words)
            {
                totalCharacters += word.Length;
                if (totalCharacters > maxLength)
                {
                    break;
                }
                summaryWords.Add(word);
            }

            return String.Join(" ", summaryWords) + "...";
        }
    }
}
