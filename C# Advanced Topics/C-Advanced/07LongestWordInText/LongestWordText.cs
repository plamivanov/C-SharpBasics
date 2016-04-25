using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07LongestWordInText
{
    class LongestWordText
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write some text in order to find the largest word in it: ");
            string[] text = Console.ReadLine().Split(new char[] { ':', ',', ';', ' ', '-', '.' }, StringSplitOptions.RemoveEmptyEntries);
            string largestWord = text[0];
            for (int i = 0; i < text.Length; i++)
            {
                if (largestWord.Length > text[i].Length)
                {
                    continue;
                }
                else
                {
                    largestWord = text[i];
                }
            }
            Console.WriteLine(largestWord);
        }
    }
}
