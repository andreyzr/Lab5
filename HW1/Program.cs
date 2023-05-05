using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[7] ;
            double result = 0;
            for (int i = 0; i < 7; i++)
            {
                array[i] = Convert.ToDouble(Console.ReadLine());

            }
            foreach (double i in array)
            {
                result += i;
            }

            Console.WriteLine("{0:f2}",result/7);
            Console.ReadKey();
        }
    }
    
}
