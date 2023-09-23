
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithFilesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Other\Learning\CSharp\Basic\WorkingWithFilesExercise\MyInfo.txt";

            if (!File.Exists(path))
            {
                return;
            }

            string text = File.ReadAllText(path);

            string[] words = text.Split(' ');

            Console.WriteLine($"Number of words in file: {words.Length}");

            int maxLength = 0;
            int index = 0;
            for (int i = 0; i < words.Length; i++)            
            {
                if (words[i].Length > maxLength)
                {
                    maxLength = words[i].Length;
                    index = i;
                }
            }

            Console.WriteLine($"Longest word in the file: {words[index]}");
        }
    }
}
