using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_05_22
{
    class StringRevers
    {

        static void Main11(string[] args)
        {
            String str = "India is my country";
            String revers = " ";
            /*   for(int i=0;i<str.Length;i++)
               {
                   revers = str[i] + revers;
               }
               Console.WriteLine(revers);*/

            for (int i = str.Length - 1; i >= 0; i--)
            {
                revers = revers + str[i];
            }

            Console.WriteLine(revers);

        }
    }
}
