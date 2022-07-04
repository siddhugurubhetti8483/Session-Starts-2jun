using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_05_22
{
    class Sorting
    {

        static void Main07(string[] args)
        {
            int[] a = new int[5];

            Console.WriteLine("Enter Array Elements");

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(String.Join(" ", a));

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            Console.WriteLine("//////////////////////////////");
            Console.WriteLine(String.Join(" ", a));

        }
    }
}
