using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_05_22
{
    class StringMethod
    {
        static void Main10(string[] args)
        {
            String str = "India is country";
            int l = str.Length;
            Console.WriteLine("No of char from string=  " + l);

            Console.WriteLine(str);
            String st1 = str.Substring(6);

            Console.WriteLine("My substr is= " + st1);


            String st2 = str.Substring(3, 8);

            Console.WriteLine("My another sunstr= " + st2);

            Console.WriteLine("..... " + str.IndexOf('i'));


            Console.WriteLine("..... " + str.LastIndexOf('i'));



            Console.WriteLine("////////////////////////////////////////////");


            String str1 = " India is the best";

            String merge = str + str1;
            Console.WriteLine(merge);

            String joinString = string.Concat(str, ",", str1);
            Console.WriteLine("Concat String = " + joinString);

            string s = "Hello";
            string s1 = "hello";
            String s2 = new string("Hello");

            Console.WriteLine(s == s1);

            Console.WriteLine(s1 == s2);

            Console.WriteLine(s.Equals(s2));
            Console.WriteLine(s.Equals(s1));


            Console.WriteLine(s.CompareTo(s2));
            Console.WriteLine(s.CompareTo(s1));
            Console.WriteLine(s1.CompareTo(s2));
            //Interpolation

            String msg = "Welcome to India";

            String mymsg = $"Hello {msg}";
            Console.WriteLine(mymsg);

            char[] ch = msg.ToCharArray();
            Console.WriteLine(String.Join(" ", ch));

            Console.WriteLine("Upper case  = " + msg.ToUpper());
            Console.WriteLine(msg);
            String mylower = "HELLO .NET WORLD";
            String newLowerCase = mylower.ToLower();
            Console.WriteLine(newLowerCase);


            String[] mywords = str.Split(" ");

            foreach (String st in mywords)
            {
                Console.WriteLine(st);
            }








        }
    }
}
