using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_pattern
{
    internal class Class6
    
    /*      A
            AB
            ABC
            ABCD
            ABCDE
            ABCDEF
            ABCDE
            BCDE
            CDE
            DE
            E
     */
    {
        static void Main01(string[] args)
        {
            for (char c = 'A'; c <= 'F'; c++)
            {
                for (char c2 = 'A'; c2 <= c; c2++)
                {
                    Console.Write(c2);
                }
                Console.WriteLine();
            }
            for (char c = 'A'; c <= 'F'; c++)
            {
                for (char c3 = c; c3 <= 'E'; c3++)
                {
                    Console.Write(c3);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        static void Main02(string[] args)
            /*       1
             *      12
             *     123
             *    1234
             *   12345
             * 
             */
        {
            for (int r = 1; r <= 5; r++)
            {
                for (int sp = r; sp <= 4; sp++)
                {
                    Console.Write(" ");
                }
                for (int c = 1; c <= r; c++)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        static void Main03(string[] args)
        {
           /*  *
               ***
               *****
               *******
               ********* */
           for(int r = 1; r <=5; r++)
           {
                for(int c = 1; c < 2*r; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
           }
            Console.ReadLine();
        }
        static void Main04(string[] args)
        {
            for(int r = 1; r <=5; r++)
            {
                for (int sp = 1; sp <= 5-r; sp++)
                {
                    Console.Write(" ");
                }
                for( int c = 1; c < 2*r; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        static void Main05(string[] args)
            /*                1
             *               121
             *              12321
             *             1234321
             *            123454321
             */
        {
            for (int r = 1; r <= 5; r++)
            {
                for (int sp = 1; sp <= 5 - r; sp++)
                {
                    Console.Write(" ");
                }
                for (int c = 1; c <= r; c++)
                {
                    Console.Write(c);
                }
                for (int l = r-1; l >= 1; l--)
                //for( int l = 0; l >= r; l-- )
                {
                    Console.Write(l);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
