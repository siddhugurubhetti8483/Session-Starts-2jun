using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_05_22
{

    class ConverCase
    {
        static void Main01(string[] args)
        {
            String str = "India Is My Country";
            //----------------------      FIRST METHOD         ----------------
            /* string s = str.ToLower();
             Console.WriteLine(s);

             string s1 = str.ToUpper();
             Console.WriteLine(s1);*/

            //----------------------      SECOND METHOD        -----------------

            String lower = " ";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'A' && str[i] <= 'Z')
                {
                    lower = lower + (char)(str[i] + 32);
                }
                else
                {
                    lower = lower + str[i];
                }
            }
            Console.WriteLine(lower);

            String Upper = " ";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'a' && str[i] <= 'z')
                {
                    Upper = Upper + (char)(str[i] - 32);
                }
                else
                {
                    Upper = Upper + str[i];
                }
            }
            Console.WriteLine(Upper);
            Console.ReadLine();

        }


    }
}
