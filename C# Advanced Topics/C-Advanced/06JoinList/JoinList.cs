using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06JoinList
{
    class JoinList
    {
        static void Main(string[] args)
        {
            Console.Write("Write some int numbers separated by space: ");
            string numbers1 = Console.ReadLine();
            string[] numbers1Arr = numbers1.Split();
            int[] numbers1IntArr = Array.ConvertAll(numbers1Arr,int.Parse);
            Console.Write("Write some int numbers separated by space: ");
            string numbers2 = Console.ReadLine();
            string[] numbers2Arr = numbers2.Split();
            int[] numbers2IntArr = Array.ConvertAll(numbers2Arr, int.Parse);

            List<int> list1 = new List<int>(numbers1IntArr);
            List<int> list2 = new List<int>(numbers2IntArr);

            List<int> ulist = list1.Union(list2).ToList();
            ulist.Sort();
            foreach (var item in ulist)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
        }
    }
}
