using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewApp.ArrayDemos
{
    class ArrayEvenOdd
    {
        static void Main01(string[] args)
        {
            int[] a = { 6, 7, 3, 4, 1, 2, 5, 9 };

            Console.WriteLine("The even number");
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    Console.WriteLine(a[i]);
                }
            }
            Console.WriteLine("The odd number");

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                { 

                    Console.WriteLine(a[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
