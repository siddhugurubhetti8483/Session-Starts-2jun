using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayy
{
    internal class Two_D_arraycs
    {
        static void Main(string[] args)
        {
            int[,] a = new int[2, 2];
            Console.WriteLine("Enter array element");
            for (int r = 0; r <= a.GetUpperBound(0); r++)
            {
                for (int c = 0; c <= a.GetUpperBound(1); c++)
                {
                    a[r, c] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("................................");
            Console.WriteLine();
            for (int r = 0; r <= a.GetUpperBound(0); r++)
            {
                for (int c = 0; c <= a.GetUpperBound(1); c++)
                {
                    Console.Write(a[r, c] + " ");

                }
                Console.WriteLine();

            }
        }
    }
    class RowSum
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2, 3 }, { 6, 5, 2 }, { 7, 5, 1 } };
            for (int r = 0; r < a.GetLength(0); r++)
            {
                int sum = 0;
                for (int c = 0; c < a.GetLength(1); c++)
                {
                    sum = sum + a[r, c];
                    Console.Write(a[r, c] + " ");
                }
                Console.WriteLine("  sum=" + sum);
                Console.WriteLine();
            }
        }
    }
    class colSum
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2, 3 }, { 6, 5, 2 }, { 7, 5, 1 } };
            for (int r = 0; r < a.GetLength(0); r++)
            {
                int sum = 0;
                for (int c = 0; c < a.GetLength(1); c++)
                {
                    sum = sum + a[c, r];
                    Console.Write(a[c, r] + " ");
                }
                Console.WriteLine("  sum=" + sum);
                Console.WriteLine();
            }
        }
    }
    class TwoDPatternArray
    {
        static void Main(string[] args)
        {
            //int[,] a = new int[4, 4];
            int[,] a = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 0, 1, 2 }, { 2, 3, 6, 5 } };
            //Console.WriteLine("Enter array");
            for(int r = 0; r < a.GetLength(0); r++)
            {
                for(int c = 0; c < a.GetLength(1); c++)
                {
                   // a[r, c] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("..................................");
            for(int r = 0; r < a.GetLength(0); r++)
            {
                for(int c = 0; c < a.GetLength(1); c++)
                {
                    Console.Write(a[r, c]+" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("..................................");
            Console.WriteLine();

            for(int r = 0; r <= a.GetUpperBound(0); r++)
            {
                for(int c = 0; c <= a.GetUpperBound(1); c++)
                {
                    if(r==0||c==0||r==a.GetUpperBound(0)||c==a.GetUpperBound(1))
                    {
                        Console.Write(a[r,c]);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("..................................");
            Console.WriteLine();

            for (int r = 0; r <= a.GetUpperBound(0); r++)
            {
                for (int c = 0; c <= a.GetUpperBound(1); c++)
                {
                    if (c == 0 || c == a.GetUpperBound(1) || r==c )
                    {
                        Console.Write(a[r, c]);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
    class add_two_matrices
    {
        static void Main(string[] args)
        {
            //int rw = 0;
            //int cl = 0;

            int[,] a = new int[2, 2];
            int[,] b = new int[2, 2];
            int[,] c = new int[2, 2];
            //Console.WriteLine("Enter the element of a: ");
            //int num = int.Parse(Console.ReadLine());
            for (int rw = 0; rw < a.GetUpperBound(0); rw++)
            {
                for (int cl = 0; cl < a.GetUpperBound(1); cl++)
                {
                    Console.Write("element - [{0},{1}] : ", rw, cl);
                    a[rw, cl] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter the element of b: ");
            for (int rw = 0; rw < b.GetUpperBound(0); rw++)
            {

                for (int cl = 0; cl < b.GetUpperBound(1); cl++)
                {
                    Console.Write("element - [{0},{1}] : ", rw, cl);

                    b[rw, cl] = int.Parse(Console.ReadLine());
                }
            }

            for (int rw = 0; rw < c.GetUpperBound(0); rw++)
            {
                for (int cl = 0; cl < c.GetUpperBound(1); cl++)
                {
                    Console.Write("element - [{0},{1}] : ", rw, cl);

                    c[rw, cl] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\n a: ");
            for (int rw = 0; rw < a.GetUpperBound(0); rw++)
            {
                for (int cl = 0; cl < a.GetUpperBound(1); cl++)
                {
                    Console.Write(a[rw,cl] );
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n b: ");
            for (int rw = 0; rw < b.GetUpperBound(0); rw++)
            {
                for (int cl = 0; cl < b.GetUpperBound(1); cl++)
                {
                    Console.Write(b[rw, cl] );
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nAddition of matrisec a and matrices b:");
            for (int rw = 0; rw < c.GetUpperBound(0); rw++)
            {
                for (int cl = 0; cl < c.GetUpperBound(1); cl++)
                {
                    Console.WriteLine(c[rw, cl] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
