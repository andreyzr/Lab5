using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[15];
            Random random = new Random();
            for (int i = 0; i < 15; i++)
            {
                array[i] = random.Next(0, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            int min = array[0];
            int max = array[0];
            foreach (int a in array)
            {
                if (a < min)
                    min = a;

            }            
            foreach (int a in array)
            {
                if (a > max)
                    max = a;

            }
            Console.WriteLine("Сумма максимального и минимального элементов равно {0}",max+min);
            Console.ReadKey();
        }
    }
}
