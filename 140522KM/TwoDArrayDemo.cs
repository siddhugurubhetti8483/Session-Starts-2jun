using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_05_22
{
    class TwoDArrayDemo
    {

        static void Main12(string[] args)
        {
            //  int[][] a = new int[2][2];
            int[,] a = new int[2, 2];//.net 

            /* a[0, 0] = 12;
             a[0, 1] = 34;
             a[1, 0] = 67;
             a[1, 1] = 45;*/

            Console.WriteLine("Enter Array Elements");


            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("..........................");

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + "  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("......................");

            foreach (int i in a)
            {
                Console.Write(i + "  ");
            }
            Console.WriteLine();

            Console.WriteLine("........................");
            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= a.GetUpperBound(1); j++)
                {
                    Console.Write(a[i, j] + "  ");
                }
                Console.WriteLine();
            }
            //   int[,] arr = new int[,] { { 6, 7 }, { 4, 9 } };
        }
    }
}
