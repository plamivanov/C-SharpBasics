using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04MatrixOfPaledromes
{
    class Matrix
    {
        static void Main(string[] args)
        {
            Console.Write("enter rows and columns on the same line separated by space: ");
            string[] input = Console.ReadLine().Split();
            int rows = int.Parse(input[0]);
            int col = int.Parse(input[1]);
            string[,] array = new string[rows, col];
            char[] areve = { 'a', 'a', 'a' };
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {

                    char b = 'a';
                    b += (char)i;
                    char c = 'a';
                    c += (char)j;
                    c += (char)i;
                    areve[0] = b;
                    areve[1] = c;
                    areve[2] = b;
                    string huligan = new string(areve);
                    array[i, j] = huligan;
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();

            }
        }
    }
}
