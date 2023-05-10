using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива:");
            int N = Convert.ToInt32(Console.ReadLine());
            int n = N; //Кол строк
            int m = N;//Кол столбцов
            int[,] t = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    t[i, j]=(i + j) % 2 == 0 ? 1 : 0;
                    Console.Write("{0,4}", t[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
