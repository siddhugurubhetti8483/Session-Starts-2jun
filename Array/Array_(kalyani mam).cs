using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayy
{
    internal class Array__kalyani_mam_
    {
        static void Main(string[] args)
        {
            //first way of value assigning
            // declaration / value asidning 

            int[] arr = { 5, 6, 3, 8 };

          

            //second way of value assigning
            //declaration / value asidning means initialising at the same time

            int[] arr2 = new int[5] { 7, 34, 1, 9, 8 };



            //Third way 
            //Store the element by user

            int[] a = new int[4];
            a[0] = 4;
            a[1] = 8;
            a[2] = 5;
            a[3] = 9;

            Console.WriteLine("Enter the four element");
            for (int i = 0; i < a.Length; i++)
            {
                int x = int.Parse(Console.ReadLine());
                a[i] = x;
            }
            Console.WriteLine("-------------------------------------");
            for(int i = 0; i < a.Length; i++)
            {
                Console.Write("Third way "+a[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------");

            //

            foreach(int p in a)
            {
                Console.Write("Forth way "+p+" ");
            }
            Console.WriteLine();
            Console.WriteLine("......................................");


            // Fifth way


            Console.WriteLine("fifth way "+String.Join(" ",a));



        }
    }

    class even_element
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 8, 5, 4, 9, 10, 16 };

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    Console.WriteLine(a[i]);
                    
                }
               
            }
            Console.WriteLine();


            Console.WriteLine("Second way");

            foreach (int p in a)
            {
                if(p % 2 == 0)
                {
                    Console.WriteLine(p);
                }
            }

        }
    }
    class Sum_of_even_element
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] a = { 1, 8, 5, 4, 9, 10, 16 };

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    Console.WriteLine(a[i]);
                    sum = sum + a[i];
                }
            }
            Console.Write("Sum of even element :" + sum);
        }
    }
    class Sum_of_array_element
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] n = { 1, 5, 9, 3, 7, 6 };

            for(int i = 0; i < n.Length; i++)
            {
                sum = sum + n[i];
            }
            Console.WriteLine(sum);
            
        }
    }
    class Reverse_char
    {
        //Display Array in Reverce
        static void Main(string[] args)
        {
            char[] ch = new char[5];
            Console.WriteLine("enter char");
            for (int i = 0; i < ch.Length; i++)
            {
                ch[i] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("...............................");

            // (String.Join(" ",ch)) means 5 charecter joint in one line  => o/p   (g j i l k)

            Console.WriteLine(String.Join(" ",ch));

            Console.WriteLine("|||||||||||||||||||||||||||||||||||||||");
            for (int i = ch.Length - 1; i >= 0; i--)
            {
                Console.Write(ch[i]+" ");
            }

        }
    }
    class Reaverse_string
    {
        static void Main(string[] args)
        {
            string[] str = new string[4];
            Console.WriteLine("Enter the string name");

            for(int i = 0; i < str.Length; i++)
            {
                str[i] = Console.ReadLine();
            }

            Console.WriteLine(" Reverse string ");

            for(int i = str.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(str[i]);
            }
        }
    }
    class MaxElement
    {
        static void Main(string[] args)
        {
            int[] a = new int[8];
            Console.WriteLine("Enter the element");
            int max = a[0];

            for(int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            Console.WriteLine("Max Element{0} : ",max);

            Console.WriteLine("=================================================");

            int[] b = { 1, 2, 5, 9, 10, 58, 62, 41, 5, 80, 55 };
            int maxx = b[0];

            for (int i = 0; i < b.Length; i++)
            {
                
                if (b[i] > maxx)
                {
                    maxx = b[i];
                }
            }
            Console.WriteLine("Max Element : {0}", maxx);
        }
    }
    class MaxElement_char_Type
    {
        static void Main(string[] args)
        {
            char[] ch = new char[6];
            Console.WriteLine("Enter the char element");
            char max = ch[0];

            for(int i = 0; i < ch.Length; i++)
            {
                ch[i] = Convert.ToChar(Console.ReadLine());
                if (ch[i] > max)
                {
                    max = ch[i];
                }
            }

            Console.WriteLine("Max Char : {0}",max);
        }
    }
    class MinElement_char_and_int
    {
        static void Main(string[] args)
        {
            char[] ch = {'y', 'e', 'f', 'i', 'z', 'b', 'a' };
            char min = ch[0];

            for(int i = 0; i < ch.Length; i++)
            {
                if (ch[i] < min)
                {
                    min = ch[i];
                }
            }
            Console.WriteLine("Minimum char : {0}\n",min);


            Console.WriteLine("----------min number----------\n");

            int[] a = {5, 6, 7, 3, 88, 44, 0, 9 };
            int minn = a[0];

            for(int i = 0; i < a.Length; i++)
            {
                if(minn > a[i])
                {
                    minn = a[i];
                }
            }
            Console.WriteLine("Minimum number : {0}",minn);

        }
    }
    class Arryareverce
    {
        static void Main(string[] args)
        {
            Console.WriteLine("reversr Int type Array \n");

            int[] a = {5, 6, 7, 8, 9 };
            Console.WriteLine(String.Join(" ",a));
            int j = a.Length - 1;
            for(int i = 0; i < a.Length/2; i++)
            {
                int temp = a[i];
                a[i] = a[j];
                a[j] = temp;
                j--;
            }
            Console.WriteLine("----------------------------------------------------");

            Console.WriteLine(String.Join(" ", a));

            Console.WriteLine("reverse Charector type array\n");

            char[] ch = { 'a', 'b', 'c', 'd', 'e', 'f', 'g' };
            Console.WriteLine(String.Join(" ", ch));

            int k = ch.Length - 1; 
            
            for(int i = 0; i < ch.Length/2; i++)
            {
                char temp = ch[i];
                ch[i] = ch[k];
                ch[k] = temp;
                k--;
            }
            Console.WriteLine(String.Join(" ",ch));

            

        }
    }
    class alternate_array
    {
        static void Main(string[] args)
        {
            Console.WriteLine("reversr Int type Array \n");

            int[] a = {1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            Console.WriteLine(String.Join(" ", a));
            int j = a.Length - 1;
            for (int i = 0; i < a.Length / 2; i=i+2)
            {
                int temp = a[i];
                a[i] = a[j];
                a[j] = temp;
                j = j - 2;
            }
            Console.WriteLine("----------------------------------------------------");

            Console.WriteLine(String.Join(" ", a));
        }
    }
}
