using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_05_22
{
    class DigitAvg
    {
        static void Main01(string[] args)
        {
             Console.WriteLine("Enter The String (Alphabet,Number&symbol");
             String str = Console.ReadLine();
            
             int count = 0, alpha = 0, symbol = 0, sum = 0;
             for (int i = 0; i < str.Length; i++)
             {
                 if (Char.IsLetter(str[i]))//if((str[i]>='a' &&str[i]<='z')||(str[i]>='A' && str[i]<='Z'))
                 {
                     alpha++;
                 }
                 else if (Char.IsDigit(str[i]))// if(str[i]>='0'&& str[i]<='9')
                 {
                     count++;
                     int x = (int)(Char.GetNumericValue(str[i]));
                     sum = sum + x;
                     // int x = int.Parse(str[i].ToString());
                     // sum = sum + x;
                 }
                 else
                 {
                     symbol++;
                 }
             }
             Console.WriteLine("Number of digits=" + count);
             Console.WriteLine("Number of Alphabets= " + alpha);
             Console.WriteLine("Number of Symbols= " + symbol);
             // Console.WriteLine("sum of digit= "+sum);
             // int avg = sum / count;
             // Console.WriteLine("avg= "+avg );
             Console.ReadLine();

            Console.WriteLine("Enter The String (Alphabet,Number&symbol");
            String str1 = Console.ReadLine();
           // Console.WriteLine(str1);
            int Count = 0, Alpha = 0, Symbol = 0, Sum = 0;
            for (int i = 0; i < str1.Length; i++)
            {
               
                if((str1[i]>='a' &&str1[i]<='z')||(str1[i]>='A' && str1[i]<='Z'))
                {
                    Alpha++;
                }
                if(str1[i]>='0'&& str1[i]<='9')
                {
                    Count++;
                    int x = int.Parse(str1[i].ToString());
                     Sum = Sum + x;
                }
                else
                {
                    Symbol++;
                }
            }
            Console.WriteLine("Number of digits=" + Count);
            Console.WriteLine("Number of Alphabets= " + Alpha);
            Console.WriteLine("Number of Symbols= " + Symbol);
            Console.WriteLine("sum of digit= "+ Sum);
            int avg = Sum / Count;
            Console.WriteLine("avg= "+avg );
            Console.ReadLine();
        }
    }
}

