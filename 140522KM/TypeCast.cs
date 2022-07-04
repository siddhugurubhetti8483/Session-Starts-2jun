using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_05_22
{
    class TypeCast
    {
        static void Main13(string[] args)
        {
            int x = 10;

            float y = x;
            Console.WriteLine(x + "  " + y);


            double a = 89.56;

            int b = (int)(a);
            Console.WriteLine(b);

        }
    }
}
