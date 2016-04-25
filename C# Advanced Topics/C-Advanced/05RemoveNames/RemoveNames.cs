using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05RemoveNames
{
    class RemoveNames
    {
        static void Main(string[] args)
        {
            Console.Write("Write some names,separated by space: ");
            string imena1 = Console.ReadLine();
            string[] imenaNow = imena1.Split();
            List<string> imenaL = new List<string>(imenaNow);
            Console.Write("Write the names you wish to be excluded: ");
            string imena2 = Console.ReadLine();
            string[] imenaEx = imena2.Split();
            List<string> imenaR = new List<string>(imenaEx);
            for (int i = 0 ; i <imenaL.Count; i++)
            {
                for (int j = 0; j < imenaR.Count; j++)
                {
                    if (imenaL[i]== imenaR[j])
                        imenaL.RemoveAt(i);
                }
            }
            foreach (var item in imenaL)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            
        }
    }
}
