using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class dopylnitelni
    {
        static void Main(string[] args)  //////zaigrafka pari i machove i rezultati
        {
            float pari = float.Parse(Console.ReadLine());
            int  arsenal=0; 
            int chelsea=0; 
            int manchesterCity=0; 
            int manchesterUnited=0;
            int liverpool=0;
            int everton=0;
            int southampton=0; 
            int tottenham=0;
            string g="";
            float result = 0;

            do
            {
                g = Console.ReadLine();
                


                    string[] arr = g.Split(new char[] { ':', ',', ';', ' ', '-', '.' }, StringSplitOptions.RemoveEmptyEntries);
                   
                    if (arr[1] == "X")
                    {
                        if (arr[0] == "ManchesterUnited")
                        {
                            manchesterUnited += 1;
                        }
                        else if (arr[0] == "Arsenal")
                        {
                            arsenal += 1;
                        }
                        else if (arr[0] == "Liverpool")
                        {
                            liverpool += 1;
                        }
                        else if (arr[0] == "Tottenham")
                        {
                            tottenham += 1;
                        }
                        else if (arr[0] == "ManchesterCity")
                        {
                            manchesterCity += 1;
                        }
                        else if (arr[0] == "Everton")
                        {
                            everton += 1;
                        }
                        else if (arr[0] == "Chelsea")
                        {
                            chelsea += 1;
                        }
                        else if (arr[0] == "Southampton")
                        {
                            southampton += 1;
                        }
                        
                        if (arr[2] == "ManchesterUnited")
                        {
                            manchesterUnited += 1;
                        }
                        else if (arr[2] == "Arsenal")
                        {
                            arsenal += 1;
                        }
                        else if (arr[2] == "Liverpool")
                        {
                            liverpool += 1;
                        }
                        else if (arr[2] == "Tottenham")
                        {
                            tottenham += 1;
                        }
                        else if (arr[2] == "ManchesterCity")
                        {
                            manchesterCity += 1;
                        }
                        else if (arr[2] == "Everton")
                        {
                            everton += 1;
                        }
                        else if (arr[2] == "Chelsea")
                        {
                            chelsea += 1;
                        }
                        else if (arr[2] == "Southampton")
                        {
                            southampton += 1;
                        }
                    }
                    if (arr[1] == "2")
                    {
                        if (arr[2] == "ManchesterUnited")
                        {
                            manchesterUnited += 3;
                        }
                        else if (arr[2] == "Arsenal")
                        {
                            arsenal += 3;
                        }
                        else if (arr[2] == "Liverpool")
                        {
                            liverpool += 3;
                        }
                        else if (arr[2] == "Tottenham")
                        {
                            tottenham += 3;
                        }
                        else if (arr[2] == "ManchesterCity")
                        {
                            manchesterCity += 3;
                        }
                        else if (arr[2] == "Everton")
                        {
                            everton += 3;
                        }
                        else if (arr[2] == "Chelsea")
                        {
                            chelsea += 3;
                        }
                        else if (arr[2] == "Southampton")
                        {
                            southampton += 3;
                        }

                    }
                    if (arr[1] == "1")
                    {
                        if (arr[0] == "ManchesterUnited")
                        {
                            manchesterUnited += 3;
                        }
                        else if (arr[0] == "Arsenal")
                        {
                            arsenal += 3;
                        }
                        else if (arr[0] == "Liverpool")
                        {
                            liverpool += 3;
                        }
                        else if (arr[0] == "Tottenham")
                        {
                            tottenham += 3;
                        }
                        else if (arr[0] == "ManchesterCity")
                        {
                            manchesterCity += 3;
                        }
                        else if (arr[0] == "Everton")
                        {
                            everton += 3;
                        }
                        else if (arr[0] == "Chelsea")
                        {
                            chelsea += 3;
                        }
                        else if (arr[0] == "Southampton")
                        {
                            southampton += 3;
                        }
                    }

                        result= result+pari;
            
            } while (g != "End of the league.");

            result= (result-pari)*1.94f;
            Console.WriteLine("{0:F2}lv.",result);
            Console.WriteLine("Arsenal - {0} points.\nChelsea - {1} points.\nEverton - {2} points.\nLiverpool - {3} points.\nManchester City - {4} points.\nManchester United - {5} points.\nSouthampton - {6} points.\nTottenham - {7} points.",arsenal,chelsea,everton,liverpool,manchesterCity,manchesterUnited,southampton,tottenham);



        }
    }
}
