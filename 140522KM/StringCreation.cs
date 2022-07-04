using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_05_22
{
    class StringCreation
    {
        static void Main09(string[] args)
        {
            string s = "Hello C#";//using keyword
            String str = "Welcome C#";//using System.String

            String s2 = new string("My c#");//using new 


            char[] ch = { 'I', 'n', 'd', 'i', 'a' };

            String s3 = new string(ch);
            Console.WriteLine(s3);
        }


    }
}
