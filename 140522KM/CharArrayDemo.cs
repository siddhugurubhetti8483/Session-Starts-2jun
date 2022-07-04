using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_05_22
{
    class CharArrayDemo
    {
        static void Main01(string[] args)
        {
            char[] ch = { 'e', 'A', 'T', 'U', 'f' };

            foreach (char c in ch)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("//////////////////////////");
            Array.ForEach(ch, Console.WriteLine);

            Console.WriteLine("//////////////////////////////////");
            Console.WriteLine(String.Join(",", ch));
            Console.ReadLine();



        }
    }
}
