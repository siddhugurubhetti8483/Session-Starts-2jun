using System;

namespace IMP
{
    class Fibanacci_Series
    {
        static void Main(string[] args)
        {
         /*   It is series of Numbers that start feom 0 and 1.Next Number
              in series is the Sum of Last Two Numbers
              0+1 = 1     1+1=2     1+2=3     2+3=5    3+5=8    5+8=13     8+13=21
              0,1,1,2,3,5,8,13,21,34,55,89        */
            int a = 0;
            int b = 1;

            for (int i = 0; i < 10; i++)
            {
                int c = a + b;
                Console.WriteLine(c);

                a = b;
                b = c;
            }
        }
    }
    class prime_Number
    {
        static void Main(string[] args)
        {
            /*A prime number is a whole number greater than 1 whose only factors are 1 and itself.
              A factor is a whole number that can be divided evenly into another number.
              The first few prime numbers are 2, 3, 5, 7, 11, 13, 17, 19, 23 and 29.*/

            for (int i = 0; i <= 5; i++)
            {
                if(i%2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
    class Palindrome
    {
        static void Main(string[] args)
        {
            //Print all palindrome numbers from 100 to 500
          

            for(int i = 100; i <= 500; i++)
            {
                int n = i;
                int rev = 0; 

                while(n > 0)
                {
                    int last = n % 10;
                    rev = rev * 10 + last;
                    n = n / 10;
                }
                if(rev == i)
                    Console.WriteLine("Palindrome: "+i);
            }
            
        }
    }
    class Palindrome_number
    {
        static void Main(string[] args)
        {
            /* If a number remains same, even if we reverse its digits then the number is known as palindrome number.
               For example 12321 is a palindrome number because it remains same if we reverse its digits.*/

            Console.WriteLine("Enter the Number");
            int a = int.Parse(Console.ReadLine());
            int temp = a;
            int rev = 0;

            while(a > 0)
            {
                int last = a % 10;
                rev = rev * 10 + last;
                a = a / 10;
            }
            if (temp == rev)
            {
                Console.WriteLine("Its Palindrome");
            }
            else
            {
                Console.WriteLine("Its Not Palindrome");
            }
        }
    }
    class Palindrome_string
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string name");//Nitin
            string str = Console.ReadLine();
            str = str.ToUpper();
            string rev = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev = rev + str[i];
            }
            if(str == rev)
            {
                Console.WriteLine("Its Palindrome");
            }
            else
            {
                Console.WriteLine("Its Not Palindrome");
            }


        }
    }
    class Reverse_string_or_Num
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name");
            string str = Console.ReadLine();
            string rev = "";
            str = str.ToLower();

            for (int i = 0; i < str.Length; i++)
            {
                rev = str[i] + rev;
            }
            Console.WriteLine(rev);
            Console.WriteLine("==============================================");

            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev = rev + str[i];

            }
            Console.WriteLine(rev);

            //Reverse Number

            Console.WriteLine("Enter the number");
            int a = int.Parse(Console.ReadLine());
            int revv = 0;
            
            while(a>0)
            {
                int last = a % 10;
                revv = revv * 10 + last;
                a = a / 10;
            }

            Console.WriteLine(revv);
        }
    }
    class Factorial
    {
        static void Main(string[] args)
        {
            /*Factorial of a whole number 'n' is defined as the product of that number with every whole number till 1.
              For example, the factorial of 4 is 4×3×2×1, which is equal to 24. It is represented using the symbol '!' So,
              24 is the value of 4!*/

            Console.WriteLine("Enter the number");
            int Num = int.Parse(Console.ReadLine());
            int fact = 1;

            for(int i = 1; i <= Num; i++)
            {
                fact *= i;
            }
            Console.WriteLine("Factorial of : {0}, is {1} ",Num,fact);
        }
    }
    class factorial
    {
        static void Main(string[] args)
        {
            //Find fist 5 factorial and sum of finding factorial 1! + 2! + 3! + 4! + 5! + . . . . . . . . n!
            // 1!=1*1=1, 2!=1*2=2, 3!=1*2*3=6, 4!=1*2*3*4=24, 5!=1*2*3*4*5=120

            int fact = 1, num = 5, sum = 0;
            int  j, i;

            for (i = 1; i <= 5; i++)
            {
                for (j = i; j <= i; j++)
                {
                    fact *= j;
                    sum += fact;
                }
                Console.WriteLine("The factore of {0} is {1}",i,fact);
                
            }
            Console.WriteLine("The sum of finding factorial {0} ", sum);


        }
    }
    class factors
    {
        static void Main(string[] args)
        {
            // find the factors of given number  //12 = 1, 2, 3, 4, 6, 12
            Console.WriteLine("Enter the number");
            //int num = int.Parse(Console.ReadLine());
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("The factors of {0} is",num);

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                   
                    Console.Write(" {0},",i);
                }
                
            }

        }
    }
    class Aemstrong
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number is armstrong or not");
            int num = int.Parse(Console.ReadLine());
            int c = 0; // count the nuber of digits
            int temp = num;

            while(num > 0)
            {
                c++;
                num = num / 10;
            }
            num = temp;
            int sum = 0;
            while (num > 0)
            {
                int last = num % 10;
                int p = (int)Math.Pow(last, c);//math.pow(last ch pow c)//1632=2^4=16 // 3^4=81 // 6^4=1296 //1^4=1
                sum = sum + p; // 0+(16+36+1296+1)
                num = num / 10;
            }
            if(sum == temp)
                Console.WriteLine("Armstrong number");
            else
                Console.WriteLine("Not Armstrong number");
        }
    }
    class sum_of_digits
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the more than two digits");
            int num = int.Parse(Console.ReadLine());

            int last = 0;
            int sum = 0;

            while(num < 0)
            {
                last = num % 10;
                sum = sum + last;
                
            }
            Console.WriteLine(sum);


        }
    }
}