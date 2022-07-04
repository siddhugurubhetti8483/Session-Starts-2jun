using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewApp.ArrayDemos
{
    class ArrayCreation
    {

        static void Main02(string[] args)
        {
            int[] marks = { 34, 12, 67, 3, 4 };

            int[] a = new int[4];
            /*    a[0] = 33;
                a[1] = 2;
                a[2] = 89;
                a[3] = 14;*/

            Console.WriteLine("Enter Array Elements");

            for (int i = 0; i < a.Length; i++)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                a[i] = x;
                // Console.Write(a[i] + "  ");
            }
            Console.WriteLine("...........");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + "  ");
            }
            Console.WriteLine();
            Console.WriteLine("/////////////////////////");

            foreach (int x in a)
            {
                Console.Write(x + "   ");
            }

            Console.ReadLine();
        }

    }
    
}
