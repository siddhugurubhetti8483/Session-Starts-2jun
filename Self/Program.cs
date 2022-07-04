using System;

namespace Program
{
    class swap
    {
        static void Main(string[] args)
        {
            int num = 6;
            int num1 = 5;
            int tem;

            tem = num;
            num = num1;
            num1 = tem;

            Console.WriteLine(" input is \n num = 6 \n num1 = 5 \n After swap output ");
            Console.WriteLine(" num : "+ num);
            Console.WriteLine(" num1 : "+ num1);

        }
    }
    class a
    {
        static void Main(string[] args)
        {
            int num = 2, num1 = 3, num2 = 6;

            Console.WriteLine(num*num1*num2);
        }
    }
    class aa
    {
        static void Main(string[] args)
        {
            int num = 10, num1 = 2;

            Console.WriteLine("{0} + {1} = {2}", num, num1, num + num1);
            Console.WriteLine("{0} - {1} = {2}", num, num1, num - num1);
            Console.WriteLine("{0} * {1} = {2}", num, num1, num * num1);
            Console.WriteLine("{0} / {1} = {2}", num, num1, num / num1);
            Console.WriteLine("{0} % {1} = {2}", num, num1, num % num1);

        }
    }
    class Reverse_String
    {
        static void Main(string[] args)
        {
            string str = "India is my country";
            string rev = "";

            for(int i = str.Length-1; i >= 0; i--)
            {
                rev = rev + str[i];
                
            }
            Console.WriteLine(rev);
        }
    }
    class Palindrome
    {
        static void Main(string[] args)
        {
            int num = 15951;
            int temp = num;
            int rev = 0;

            while (num > 0)
            {
                int last = num % 10;
                rev = rev * 10 + last;
                num = num / 10;

            }
            if (temp == rev)
            {
                Console.WriteLine("{0} Its Palindrome", temp);
            }
            else
            {
                Console.WriteLine("{0} Not Palindrome", temp);
            }
        }
    }
    class Reverse_String_Polindrome_are_not
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            string rev = "";
            str = str.ToUpper();

            for(int i = str.Length-1; i >= 0; i--)
            {
                rev = rev + str[i];
            }
            if(str == rev)
            {
                Console.WriteLine("Palindome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }

        }
    }
    class Swap
    {
        static void Main(string[] args)
        {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("Before swapping\n a = {0},\n b = {1}",a,b);

            {   // Second way 
                Console.WriteLine("Before swapping\n a = {0},\n b = {1}", b, a);
            }


            /*a = a * b; 
              b = a / b;
              a = a / b;*/

            //a=5 , b = 10
            a = a + b;  //15
            b = a - b;  //5
            a = a - b;  //10



                Console.WriteLine("After swapping\n a = {0},\n b = {1}", a, b);

          
        }
       
    }
    class addition_of_array
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 5, 6, 8, 0 };
            int sum = 0;

            for(int i = 0; i < num.Length; i++)
            {
                sum += num[i];
            }
            Console.WriteLine("The sum of element {0} ", sum);

            Console.WriteLine("2 2 2 2 2 2 2 2 2 2 2 2 2 2 2 2 2 2 2nd Way ");

            int[] numm = new int[5] { 1, 2, 5, 9, 8 };
            int summ = 0;

            for (int i = 0; i < num.Length; i++)
            {
                summ += num[i];
            }
            Console.WriteLine("The sum of element {0} ", summ);

        }
    }
}

