using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random random = new Random();
            bool f = false;
            for (int i = 0; i < 10; i++)
            {
                array[i] = random.Next(0, 10);
                Console.Write("{0} ", array[i]);
            }
            foreach (int a in array) 
            { 
                if (a == 0)
                {
                    Console.WriteLine("Элемент найден");
                    f = true;
                    break;
                }
            }
            if(!f)
                Console.WriteLine("Элемент не найден");
            Console.ReadKey();
        }
    }
}
