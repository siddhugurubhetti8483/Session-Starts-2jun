using System;

namespace AA
{
    class Get_num_sum
    {
        static void Main(string[] args)
        {
            //12345
            int n = 534;

            int sum = 0;
            while (n > 0)
            {
                int last = n % 10;
                sum = sum + last; //4
                n = n / 10;
            }
            Console.WriteLine(sum);

        }

    }
    class sum_odd_even
    {
        static void Main(string[] args)
        {
            //12345


            int n = 534, sum = 0, even = 0, odd = 0;

            while (n > 0)
            {
                int last = n % 10;
                if (last % 2 == 0)
                {
                    even = even + 1;
                }
                else
                {
                    odd = odd + 1;
                }
                sum = sum + last; //4
                n = n / 10;
            }
            Console.WriteLine(sum);
            Console.WriteLine(odd);
            Console.WriteLine(even);
            Console.ReadLine();
        }
        
    }
    class neon
    {
        static void Main04(string[] args)
        {
            int squ, num1, num2;

            int sum = 0, last = 0;
            int num = int.Parse(Console.ReadLine());
            squ = num * num;
            //num1 = squ % 10;
            //num2 = squ / 10;
            //if(num1 + num2 == 0)
            while (squ > 0)
            {
                last = squ % 10;

                sum = sum + last;
                squ = squ / 10;
            }
            if (last == num)
            {
                Console.WriteLine("neon num");
            }
            else
            {
                Console.WriteLine("Not neon num");
            }
            Console.ReadLine();
        }
        
    }
    class Palindome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter No");
            int n = Convert.ToInt32(Console.ReadLine());//1254
            int temp = n;//1254
            int rev = 0;
            while (n > 0)//1254>0
            {
                int l = n % 10;  //4
                rev = rev * 10 + l;//4521
                n = n / 10;//125

            }
            if (rev == temp)
                Console.WriteLine("Palindome");
            else
            {
                Console.WriteLine("Not Palindrome");
            }
            Console.ReadLine();
        }
    }
}