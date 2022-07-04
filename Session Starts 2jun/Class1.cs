using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_Starts_2jun
{
    internal class Program
    {
        
        
            static void Main01(string[] args)
            {
                int sum = 0;
                int n = 0;
                int fact = 1;
                Console.WriteLine(sum);
                int odd = 1;
                for (int i = 1; i <= n; i++)
                {
                    fact = 1;
                    for (int j = 1; j <= odd; j++)
                    {
                        fact = fact * j;
                    }
                    sum = sum + fact;

                    odd = odd + 2;

                }
            }
            static void Main02(string[] args)
            {
                for (int r = 1; r <= 10; r++)
                {
                    for (int c = 1; c <= 10; c++)
                    {
                        if (r == 1 || r == 10 || c == 5)
                            Console.Write("I");
                        else
                            Console.Write(" ");
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
            static void Main03(string[] args)
            {
                for (int r = 1; r <= 10; r++)
                {
                    for (int c = 1; c <= 10; c++)
                    {
                        if (r == 1 || r == 5 || c == 1 || r == 10)
                            Console.Write("E");
                        else
                            Console.Write(" ");
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
            static void Main04(string[] args)
            {
                for (int r = 1; r <= 10; r++)
                {
                    for (int c = 1; c <= 10; c++)
                    {
                        if (r == 1 || c == 5)
                            Console.Write("T");
                        else
                            Console.Write(" ");
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
            static void Main05(string[] args)
            {
                for (int r = 1; r <= 10; r++)
                {
                    for (int c = 1; c <= 10; c++)
                    {
                        if (c == 1 || r == 1 || r == 5 || c == 10 & r <= 5)
                            Console.Write("P");
                        else
                            Console.Write(" ");
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
            static void Main06(string[] args)
            {
                for (int r = 1; r <= 10; r++)
                {
                    for (int c = 1; c <= 10; c++)
                    {
                        if (r == 1 || r == 10 || c == 1 || c == 10)
                            Console.Write("0");
                        else
                            Console.Write(" ");
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
            static void Main07(string[] args)
            {
                for (int r = 1; r <= 10; r++)
                {
                    for (int c = 1; c <= 10; c++)
                    {
                        if (r == 1 || r == 5 || c == 1)
                            Console.Write("F");
                        else
                            Console.Write(" ");
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
            static void Main08(string[] args)
            {
                for (int r = 1; r <= 10; r++)
                {
                    for (int c = 1; c <= 10; c++)
                    {
                        if (c == r || r + c == 11)
                            Console.Write("X");
                        else
                            Console.Write(" ");
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
            static void Main09(string[] args)
            {
                for (int r = 1; r <= 9; r++)
                {
                    for (int c = 1; c <= 10; c++)
                    {
                        Console.Write(r);
                    }
                    Console.WriteLine();
                }

                Console.ReadLine();
            }
            static void Main10(string[] args)
            {
                for (int r = 1; r <= 10; r++)
                {
                    for (int c = 1; c <= 10; c++)
                    {
                        Console.Write(c);
                    }
                    Console.WriteLine();
                }

                Console.ReadLine();
            }
       
    }
}
