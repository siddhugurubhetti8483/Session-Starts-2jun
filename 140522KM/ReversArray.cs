using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_05_22
{
    class ReversArray
    {

        static void Main04(string[] args)
        {

            int[] a = { 11, 22, 33, 44, 55 };

            Console.WriteLine(String.Join(" ", a));
            Console.WriteLine(".........................");
            for (int i = a.Length - 1; i >= 0; i--)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine("....................");
            Console.WriteLine(String.Join(" ", a));
            int j = a.Length - 1;

            for (int i = 0; i < a.Length / 2; i++)
            {
                int temp = a[i];
                a[i] = a[j];
                a[j] = temp;
                j--;
            }
            Console.WriteLine("/////////////////////////////");


            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + "     ");
            }

        }
    }
}
