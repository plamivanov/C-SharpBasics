using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03LongestAreaInArray
{
    class LongestAreaInArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write a number and some repeating strings:");
            int n = int.Parse(Console.ReadLine());
            string[] poredica = new string[n];
            List<string> list1 = new List<string> { };
            List<string> list2 = new List<string> { };
            List<string> list3 = new List<string> { };
            List<string> result = new List<string> { };
            
            for (int i = 0; i < n; i++)
           
            {
                poredica[i] = Console.ReadLine();
            
            }
           
            
            for (int i = 0; i < poredica.Length-1; i++)
            {  
                if(poredica[i+1]==poredica[i])
                   if(!list1.Contains(poredica[i]))
                   {
                       list1.Add(poredica[i+1]);
                   }
            }
            for (int i = 0; i <list1.Count; i++)
            {

                for (int j = 0; j < poredica.Length; j++)
                {
                    if (i%2==0)
                    {
                        if (list1[i] == poredica[j])
                        {

                                list2.Add(poredica[j]);
                           
                        }
                        

                    }
                    else
                    {
                        if (list1[i] == poredica[j])
                        {

                           
                            list3.Add(poredica[j]);
                        }
                       
                    }
                    
                    
                }
                if (list2.Count >= list3.Count)
                {
                    list3.Clear();
                }
                else if (list2.Count <= list3.Count)
                {
                    list2.Clear();
                }
            }
            //if (list2.Count >= list3.Count)
            //{
            //    Console.WriteLine(list2.Count);
            //    foreach (var item in list2)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(list3.Count);
            //    foreach (var item in list3)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            //DO tuka eksperiment,inache ima kratko reshenie...........................................
            string mostCommonValue = poredica.GroupBy(v => v)
                            .OrderByDescending(g => g.Count())
                            .Select(g => g.Key)
                            .FirstOrDefault();
            for (int i = 0; i < poredica.Length; i++)
            {
                if (mostCommonValue == poredica[i])
                {
                    result.Add(poredica[i]);
                }

            }
            Console.WriteLine(result.Count);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        
        
        
        
        }



















    }
}
