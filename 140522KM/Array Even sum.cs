using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_05_22
{
    class Array_Even_sum
    {
        static void Main01(string[] args)
        {
            Console.WriteLine("enter Array Size");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[size];
            int sum = 0;
            Console.WriteLine("Enter Array Elements");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("////////////////////////////");

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    sum = sum + a[i];
                }
            }
            Console.WriteLine("Sum of Even=  " + sum);
            Console.ReadLine();
        }
    }
}
