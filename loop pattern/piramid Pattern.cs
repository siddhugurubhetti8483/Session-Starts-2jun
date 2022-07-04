using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_pattern
{
    internal class piramid_Pattern
    {


        static void Main01(string[] args)
        /*        *
         *       ***
         *      *****
         *     *******
         *    *********    */
        {
            for (int r = 1; r <= 5; r++)
            {
                for (int c = r; c <= 4; c++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= r; k++)
                {
                    Console.Write("*");
                }
                for (int l = 2; l <= r; l++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        static void Main02(string[] args)
            /*   *********
             *    *******
             *     *****
             *      ***
             *       *     */
        {
            for (int r = 1; r <= 5; r++)
            {
                for (int c = 2; c <= r; c++)
                {
                    Console.Write(" ");
                }
                for(int k = r; k <= 5; k++)
                {
                    Console.Write("*");
                }
                for (int l = r; l <= 4; l++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

    }
}

