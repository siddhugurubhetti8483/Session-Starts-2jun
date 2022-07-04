using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_pattern
{
    internal class Class5
    {

        static void Main01(string[] args)
        /*
         * 
         **
         ***
         ****
         *****
         */

        {
            for (int r = 1; r <= 5; r++)
            {
                for (int c = 1; c <= r; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        static void Main02(string[] args)
        /*
         *****
         ****
         ***
         **
         *
         */
        {
            for (int r = 5; r >= 1; r--)
            {
                for (int c = 1; c <= r; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            Console.WriteLine("---Second Way---");
      
            for(int r = 1; r <= 5; r++)
            {
                for(int c = r; c <=5; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        static void Main03(string[] args)
        {
            /*
            1
            12
            123
            1234
            12345
            */
            for (int r = 1; r <= 5; r++)
            {
                for (int c = 5; c >= r; c--)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        static void Main04(string[] args)
        {
            /*
            6
            67
            678
            6789
            */
            for (int r = 6; r <= 9; r++)
            {
                for (int c = 6; c <= r; c++)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        static void Main05(string[] args)
        /* 1
           21
           321
           4321
           54321  */
        {
            for (int r = 1; r <= 5; r++)
            {
                for (int c = r; c >= 1; c--)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        static void Main06(string[] args)
        /*  54321
         *  4321
         *  321
         *  21
         *  1   */
        {
            
            for (int r = 5; r >= 1; r--)
            {
                for (int c = r; c >= 1; c--)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            Console.WriteLine("-------------");
            /*  54321
             *  5432
             *  543
             *  54
             *  5    */

            for(int r = 1; r <=5; r++)
            {
                for(int c = 5; c>=r; c--)
                {
                    Console.Write(c);
                    
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        static void Main07(string[] args)
        {
            /*  12345
             *  2345
             *  345
             *  45
             *  5    */
            for (int r = 1; r <= 5; r++)
            {
                for (int c = r; c <= 5; c++)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        static void Main08(string[] args)
        {
            /* for (char r = 'A'; r <= 'E'; r++)
             {
                 for (char c = r; c <= 'E'; c++)
                 {
                     Console.Write(c);
                 }
                 Console.WriteLine();
             }*/

            for (char r = 'D'; r <= 'A'; r--)
            {
                for (char c = r; c >= 'A'; c--)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
