using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_Starts_2jun
{
    internal class Class2
    {
        static void Main01(string[] args)
        {
            //WAP to print even number from 121 to 229 using for loop

            //for (int i = 121; i <= 229; i++)
            for (int j = 120; j < 229; j = j + 2)
            {
                // if(i%2==0)
                //Console.WriteLine(i);
                Console.WriteLine(j);
            }
            Console.ReadLine();
        }
        static void Main001()////// output 122 to 228 pahije 122 to 230 yetoy////////////////////////////////////////////
        {
            int j = 120;
            while (j < 229)
            {
                Console.WriteLine(j);
                j = j + 2;

            }

            Console.ReadLine();
        }
        static void Main02(string[] args)
        //WAP to print odd numbers from 521 to 229 using while loop
        {
            int i = 521;
            while (i > 229)
            {

                if (i % 2 != 0)
                    Console.WriteLine(i);
                i--;
            }
            Console.ReadLine();
        }
        static void Main03()
        //WAP to show the use of break statement
        {
            int j;
            for (int i = 2; i <= 10; i++)
            {
                Console.WriteLine(j = i * i);

                break;

            }
            Console.ReadLine();
        }
        static void Main04()
        //Write a program to find GCD and LCM of given number
        {
            int num1 = 12, num2 = 18;
            int gcd = 0;

            int i = 1;
            while (i <= num1)
            {
                if (num1 % i == 0 && num2 % i == 0)
                {
                    gcd = i;

                }
                //Console.WriteLine(gcd);
                i++;
            }
            Console.WriteLine(gcd);
            Console.ReadLine();
        }
        static void Main004()
        {
            int a = 12, b = 18;
            int gcd = 0;

            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0 && b % i == 0)
                    gcd = i;

            }
            Console.WriteLine(gcd);
            Console.ReadLine();
        }
        static void Main05()
        //Write a program to print all alphabets from a to z using for loop
        {
            for (char c = 'a'; c <= 'z'; c++)
            {
                Console.Write(" " + c);
            }
            Console.ReadLine();
        }
        static void Main06()
        // Write a program to find sum of all even numbers between 1 to n.
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(" Even No  : {0} ", i);
                    sum = sum + i;
                }
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
        static void Main006()
        {
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            int sum = 0;
            while (i <= n)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"Even No : " + i);
                    sum = sum + i;

                }
                i++;

            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
        static void Main07()
        // Write a program to find sum of all odd numbers between 1 to n.
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("ood No : {0}", i);
                    sum = sum + i;
                }

            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
        static void Main007()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int i = 1;

            while (i <= n)
            {

                Console.WriteLine(i);
                sum = sum + i;
                i = i + 2;

            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
        static void Main()
        //Write a program to count number of digits in any number
        {
            int n = 20;
            int i = 1;
            int c = 0;
            while (i <= 20)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    c++;
                }
                i++;

            }
            Console.WriteLine("Total count no is " + c);
            Console.ReadLine();
        }
        static void Main09()
        //Write a program to calculate product of digits of any number
        {
            int i = 245;
            int mul = 1;

            while (i > 0)
            {
                int last = i % 10;
                mul = mul * last;
                i = i / 10;
            }
            Console.WriteLine(mul);
            Console.ReadLine();
        }
        static void Main10(string[] args)
        {
            //Write a program to find frequency of each digit in a given integer.
            Console.WriteLine("Enter the number 10 digits");
            long num = long.Parse(Console.ReadLine());

            long temp = num;
            for (int i = 0; i < num; i++)
            {
                int c = 0;

                while (num > 0)
                {
                    long last = num % 10;
                    if (last == i)
                        c++;

                    num = num / 10;
                }
                num = temp;
                if (c > 0)
                    Console.WriteLine("freq of " + i + " = " + c);

            }
            Console.ReadLine();
        }
        static void Main11(string[] args)
        {
            //Find all prime number between 400 to 300;
            for (int i = 400; i >= 300; i--)
            {
                if (i % 2 != 0)
                    Console.WriteLine("The Prime No is : " + i);
            }
            Console.ReadLine();
        }
        static void Main12(string[] args)
        {
            //WAP to print table of given no
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", n, i, n * i);
            }
            Console.ReadLine();

        }
        static void Main13(string[] args)
        {
            // WAP to print squares from 1 to20

            int j;
            for (int i = 1; i <= 20; i++)
                Console.WriteLine(j = i * i);
            Console.ReadLine();

        }
        static void Main013(string[] args)
        {
            int j;
            int i = 1;
            while (i <= 20)
            {
                j = i * i;
                {
                    Console.WriteLine(j);
                    i++;
                }
            }
            Console.ReadLine();
        }
        static void Main14(string[] args)
        {
            //WAP to accept base and index from user and calculates power

            int Base = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            int index = 1;

            for (int i = 1; i <= power; i++)
            {
                //Console.WriteLine(i);
                index = index * Base;
            }
            Console.WriteLine("base {0} ,power {1} ,is {2} ", Base, power, index);
            Console.ReadLine();
        }
        static void Main15(string[] args)
        {
            //1!+2!+3!.........+n! find s
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
                sum = sum + fact;
            }
            Console.WriteLine(sum);
            Console.ReadLine();

        }
        static void Main015(string[] args)
        {
            //1!+3!+5!+7!+.........n!
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int fact = 1;
            Console.WriteLine(sum);
            int odd = 1;

            for (int i = 1; i <= n;
                i++)
            {
                fact = 1;
                for (int j = 1; j <= odd; j++)
                {
                    fact = fact * j;
                }

                sum = sum + fact;

                odd = odd + 2;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
        static void Main16(string[] args)
        {
            //WAP to check given no is Krishnamurthy or not
        }
        static void Main19(string[] args)
        {
            //Harshad niven number
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int a = n;
            while (n > 0)
            {
                int last = n % 10;
                sum = sum + last;
                n = n / 10;
            }

            if (a % sum == 0)
                Console.WriteLine("Harshad niven number");
            else
                Console.WriteLine("Not harshad niven number");
            Console.ReadLine();
        }
        static void Main18(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int square = (n * n);
            bool condition = true; //n = 25  square = 625  25 = 625 last 2 digit same then is automorphic

            while (n > 0)
            {
                if (n % 10 != square % 10)
                {
                    condition = false;
                    break;
                }
                n = n / 10;
                square = square / 10;
            }
            if (condition == true)
                Console.WriteLine("Automorphic");
            else
                Console.WriteLine("Not automorphic");
            Console.ReadLine();

        }
    }
}
