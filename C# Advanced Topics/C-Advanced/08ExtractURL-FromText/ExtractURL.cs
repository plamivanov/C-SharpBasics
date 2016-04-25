using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08ExtractURL_FromText
{
    class ExtractURL
    {
        static void Main(string[] args)
        {

            Console.Write("Write some text to find websites:");
            string words = Console.ReadLine();
            string[] items = words.Split(' '); ;
            List<string> webLink = new List<string> { };
            foreach (string word in items)
            {
                if (!webLink.Contains(word) && word.Length > 6)
                {
                    if (word.Substring(0, 3) == "htt" || word.Substring(0, 4) == "www."||word.Substring(word.Length-4,4)==".com")
                    {
                        webLink.Add(word);
                    }
                }

            }

            foreach (string word in webLink)
            {
                Console.WriteLine(word);
            }
            
        }
        
    }
}
