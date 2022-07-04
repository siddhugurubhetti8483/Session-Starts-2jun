using System;

namespace Loop
{
    class Patterns
    {
        /*     *****
         *     *****
         *     *****
         *     *****
         *     *****   */
        static void Main(string[] args)
        {
            for(int r = 1; r <= 5; r++) //r=1//2                         
            {
                for (int c = 1; c <= 5; c++)//c=1
                {
                    Console.Write("*");// Console.Write(r);         //cw(c)
                }
                Console.WriteLine();//11111//22222//33333          //12345//

            }

        }

    }
    class p2
    {
        /*    *****
         *    ****
         *    ***
         *    **
         *    *        */
        static void Main(string[] args)
        {
            for(int r = 1; r <= 5; r++)
            {
                for(int c = r; c <= 5; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
    class p3
    {
        /*    *
         *    **
         *    ***
         *    ****
         *    *****   */
        static void Main(string[] args)
        {
            for(int r = 1; r <= 5; r++)
            {
                for(int c = 1; c <= r; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
    class p4
    {
        /*     *
         *     **
         *     ***
         *     ****
         *     *****
         *     ****
         *     ***
         *     **
         *     *     */
        static void Main(string[] args)
        {
            for(int r = 1; r <= 5; r++)
            {
                for(int c = 1; c <= r; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for(int r = 1; r <= 4; r++)
            {
                for(int c = r; c <= 4; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
    class p5
    {
        /*    *****
         *    ****
         *    ***
         *    **
         *    *
         *    **
         *    ***
         *    ****
         *    *****      */
        static void Main(string[] args)
        {
            for (int r = 1; r <= 5; r++)
            {
                for (int c = r; c <= 5; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int r = 2; r <= 5; r++)
            {
                for (int c = 1; c <= r; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
    class p6
    {
        /*        *
         *       **
         *      ***
         *     ****
         *    *****      */
        static void Main(string[] args)
        {
            for (int r = 1; r <= 5; r++)
            {
                for (int sp = r; sp <= 4; sp++)
                {
                    Console.Write(" ");
                }
                for( int c = 1; c <= r; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
    class p7
    {
        /*     *****
         *      ****
         *       ***
         *        **
         *         *       */
        static void Main(string[] args)
        {
            for (int r = 1; r <= 5; r++)
            {
                for (int sp = 2; sp <= r; sp++)
                {
                    Console.Write(" ");
                }
                for (int c = r ; c <=5 ; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
    class p8
    {
        /*       *
         *      **
         *     ***
         *    ****
         *   *****
         *    ****
         *     ***
         *      **
         *       *   */
        static void Main(string[] args)
        {
            for (int r = 1; r <= 5; r++)
            {
                for (int sp = r; sp <= 4; sp++)
                {
                    Console.Write(" ");
                }
                for (int c = 1; c <= r; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int r = 1; r <= 5; r++)
            {
                for (int sp = 1; sp <= r; sp++)
                {
                    Console.Write(" ");
                }
                for (int c = r; c <= 4; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                
            }
        }
    }
    class p9
    {
        /*       *
         *      * *
         *     * * *
         *    * * * *
         *   * * * * *   */  
        static void Main(string[] args)
        {
            for(int r = 1; r <= 5; r++)
            {
                for(int sp = r; sp <= 4; sp++)
                {
                    Console.Write(" ");
                }
                for(int c = 1; c <=r; c++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
    class p10
    {    /*          *
          *         ***
          *        *****
          *       *******
          *      *********  */
        static void Main(string[] args)
        {
            for(int r = 1; r <= 5; r++)
            {
                
                

                
            }
        }
    }
    class p11
    {
        static void Main(string[] args)//1/12/123/1231234/12345
        {
            for(int r = 1; r <= 5; r++)
            {
                for (int c = 1; c <= r; c++)
                {
                    Console.Write(r);
                }
                Console.WriteLine();
            }
        }
    }

}