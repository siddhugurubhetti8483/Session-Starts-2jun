using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_05_22
{
    class Searching
    {

        static void Main06(string[] args)
        {

            int[] a = { 5, 8, 3, 9, 2 };

            Console.WriteLine("enter element for serching");

            int num = Convert.ToInt32(Console.ReadLine());
            bool isPresent = false;
            for (int i = 0; i < a.Length; i++)
            {
                if (num == a[i])
                {

                    isPresent = true;
                    break;

                }
            }
            if (isPresent == true)
            {
                Console.WriteLine("Number is Present");
            }
            else
            {
                Console.WriteLine("Number is Not Present");

            }


        }


    }
}
