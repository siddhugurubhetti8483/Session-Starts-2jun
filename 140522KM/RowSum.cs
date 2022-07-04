using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_05_22
{
    class RowSum
    {

        static void Main05(string[] args)
        {
            int[,] a = new int[,] { { 1, 2, 3,7 },
                                    { 4, 5, 6 ,4},
                                    { 7, 8, 9 ,8},
                                    { 5, 9, 2, 1} };


            /* for(int i=0;i<a.GetLength(0);i++)
             {
                 int sum = 0;
                 for(int j=0;j<a.GetLength(1);j++)
                 {
                     sum = sum + a[i, j];
                 }

                 Console.Write("sum=  "+sum);
                 Console.WriteLine();
             }*/


            /* for(int i=0;i<a.GetLength(0);i++)
             {

                 int max = a[i, 0];
                 for(int j=0;j<a.GetLength(1);j++)
                 {
                     if(max<a[i,j])
                     {
                         max = a[i, j];
                     }

                 }

                 Console.WriteLine("  max =="+max);
             }*/

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i == 0 || j == 0 || i == a.GetUpperBound(0) || j == a.GetUpperBound(1))
                    {
                        Console.Write(a[i, j] + " ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();

            }



        }
    }
}

