using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива:");
            int N = Convert.ToInt32(Console.ReadLine());
            int n = N; //Кол строк
            int m = N;//Кол столбцов
            int [] arraysumn =new int[N];
            int [] arraysumm =new int[N];
            int sumn=0, summ=0;
            int sumd1= 0; 
            int sumd2= 0;
            int x = 0;
            int y = 0;
            Console.WriteLine("Заполните матрицу ");
            int[,] array = new int[n, m] ;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Введите следующую строку ");
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0,4}", array[i, j]);
                }
                Console.WriteLine();
            }

            //Сумма cтрок 
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arraysumn[i] += array[i, j];
                }
                if (arraysumn[i] == arraysumn[i - y])
                {
                    sumn = arraysumn[i];
                    y += 1;
                }
                else
                {
                    break;
                }
            }
            
            //Сумма столбцов 
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {   
                    arraysumm[i] += array[j, i];
                }
                if (arraysumm[i] == arraysumm[i-x])
                {
                    summ= arraysumm[i];
                    x += 1;
                }
                else
                {
                    break;
                }
            }
            //Сумма первой диагонали
            for (int i = 0; i < n; i++)
            {
                int j = i;
                sumd1 += array[i, j];
            }
            //Сумма второй диагонали
            int N1 = N - 1;
            for (int i = N-1; i >= 0; i--)
            {
                int j = i;
                sumd2 += array[i, j];
            }
            //Проверка
            if (summ==sumn)
            {
                if(sumd2==sumd1&& sumn== sumd1)
                {
                    Console.WriteLine("Матрица является магической");
                }
            }
            else
            {
                Console.WriteLine("Матрица не является магической");
            }
            Console.ReadKey(); 
        }
    }
}
