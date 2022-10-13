using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mass_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = ((i % 2 != 0) && (j % 2 == 0) || (i % 2 == 0) && (j % 2 != 0)) ? 0 : 1;// если четная строка и нечетный столбец, то в ячейке будет 0,
                                                                                                         // а если нечетная строка и четный столбец, то будет 1

                    Console.Write( " {0}", array[i,j]);                 
                }
                Console.WriteLine();

            }
         
            Console.ReadKey();

        }
    }
}
