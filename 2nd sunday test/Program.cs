using System;

namespace Test_2
{
    class spy
    {
        /*1.	Write a program to check given number is spy number or not
         *      e.g 123 if sum of digit is equals to product of digit the number 
         *      is spy number i.e 123=1+2+3=6 and 1*2*3=6 so the number is spy number 
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to check number is spy are not");
            int n = int.Parse(Console.ReadLine());
            int num, sum = 0, mul = 1;

            while (n > 0)
            {
                num = n % 10;

                //sum = sum + num;
                sum += num;

                //mul = mul * num;
                mul *= num;

                n = n / 10;

            }
            if (sum == mul)
            {
                Console.WriteLine("The number is spy");
            }
            else
            {
                Console.WriteLine("The number is not spy ");
            }
        }
    }
    //---------------------------------------------------------------------------------------------------------
    class factors
    {
        /*2.	Write a program to print all factors of given numbers.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number"); //9
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {

                    Console.Write(i + " ");
                }
            }


        }
    }
    //---------------------------------------------------------------------------------------------------------
    class even_oddsquare
    {
        /*3. WAP to print number from 1 to 50 if number is even then print as it is 
          and number is odd then print its square. */
        static void Main(string[] args)
        {
            int n = 0, p = 0;
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {

                    Console.WriteLine("The even num " + i);
                }
                else
                {
                    p = i;
                    n = i * i;
                    Console.WriteLine("The " + p + " is odd num squ. is " + n);
                }
            }
        }
    }
    //---------------------------------------------------------------------------------------------------------
    class Harshad
    {
        /*4.A number is said to be the Harshad number if it is divisible by the sum of its digit.
        For example, if number is 156, then sum of its digit will be 1 + 5 + 6 = . Since156 is divisible by 12.
        So, 156 is a Harshad number.
        Some of the other examples of Harshad number are 8, 54, 120, etc.
        To find whether the given number is a Harshad number or not,
        calculate the sum of the digit of the number then, check whether the given number is 
        divisible by the sum of its digit. If yes, then given number is a Harshad number. */

        static void Main(string[] args)
        {
            int sum = 0;
            int n = int.Parse(Console.ReadLine());
            int copy = n;
            while (n > 0)
            {
                int last = n % 10;

                sum += last;

                n = n / 10;
            }

            if (copy % sum == 0)
            {
                Console.WriteLine("it is Harshad num");
            }
            else
            {
                Console.WriteLine("Not harashad number");
            }
        }


    }
    //---------------------------------------------------------------------------------------------------------
    class factor1 // checkkkkkkkkkkkk
    {
        /*5.Write a program to print number from 1 to 100 such that when a number is factor
            of 3 and 5 both print  “RedBlue”  and if given number is factor of only 3 the
            print “red” and if given number is factor of only 5 then “blue” otherwise the number itself.*/
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)//1 2
            {
                for (int l = 1; l <= i; l++) //1<=2
                {
                    if (i % l == 0)//2%1
                    {
                        if (3 == l && 5 == l)
                        {
                            Console.WriteLine("Redblue" + l);
                        }
                        else if (3 == l)
                        {
                            Console.WriteLine("Red" + l);
                        }
                        else if (5 == l)
                        {
                            Console.WriteLine("blue" + l);
                        }
                    }
                    else
                    {
                        Console.WriteLine(l);
                    }
                }
            }
        }

    }
    class Amicable
    {
        static void Main(string[] args)
        {
            int a = 220, b = 284, sum = 0, sum1 = 0 ;

            for(int i = 1; i <= a/2; i++)
            {
                if(a % i ==0)
                {
                    sum += i;
                }
            }
            for(int i = 1; i <= b/2; i++)
            {
                if(b % i == 0)
                {
                    sum1 += i;
                }
            }
            if(sum == 0 && sum1 ==0)
                Console.WriteLine("Amicable No");
            else
                Console.WriteLine("Not Amicable No");

        }
    }
    //---------------------------------------------------------------------------------------------------------
    class piramid1
    {
        /*      1
         *     222
              33333
             4444444*/
        static void Main(string[] args)
        {
            for (int r = 1; r <= 4; r++) //1
            {
                for (int sp = r; sp <= 4; sp++)
                {
                    Console.Write(" ");
                }
                for (int c = 1; c <= r; c++) // 1
                {
                    Console.Write(r); // 1 //12
                }
                for (int c = 2; c <= r; c++)
                {
                    Console.Write(r);
                }
                Console.WriteLine();
            }

        }
    }
    //---------------------------------------------------------------------------------------------------------
    class piramid2
    {
        /*    *****
              ****
              ***
              **
              *     */
        static void Main(string[] args)
        {
            for (int r = 1; r <= 5; r++)
            {
                for (int c = r; c <= 5; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
    //---------------------------------------------------------------------------------------------------------
    class piramid3
    {
        /* 12345
           1234
           123
           12
           1
           12
           123
           1234    */

        static void Main(string[] args)
        {
            for (int r = 1; r <= 5; r++)
            {
                for (int c = r; c <= 5; c++)
                {
                    Console.Write(c);
                }

                Console.WriteLine();
            }
            for (int r = 1; r <= 4; r++)
            {
                for (int c = 1; c <= r; c++)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
        }
    }









    //---------------------------------------------------------------------------------------------------------
    class time
    {
        int hour;
        int min;
        int sec;

        public void accept()
        {
            hour = int.Parse(Console.ReadLine());
            min = int.Parse(Console.ReadLine());
            sec = int.Parse(Console.ReadLine());

        }
        public void display()
        {
            Console.WriteLine("The time in hour " + hour);
            Console.WriteLine("The time in min " + min);
            Console.WriteLine("The time in sec " + sec);
        }

    }
    class main
    {
        static void Main()
        {
            time ob = new time();
            ob.accept();
            ob.display();



        }
    }
    //---------------------------------------------------------------------------------------------------------
    class Rectangle
    {
        int lenght;
        int breadth;
       

    
       public void inpute()
        {
            Console.WriteLine("Enter the lenght and breadth :");
            lenght = int.Parse(Console.ReadLine());
            breadth = int.Parse(Console.ReadLine());

        }
        public int calculaterarea()
        {
            int area = lenght * breadth;

            return area;
        }
        public int calculateperimeter()
        {
            int perimeter = 2 * (lenght + breadth);

            return perimeter;
        }
     
    }
    class Reactanglemain
    {
        static void Main(string[] args)
        {
            Rectangle m = new Rectangle();
            m.inpute();

            int a = m.calculaterarea();
            Console.WriteLine("The area of rectangle : "+a);

            int p = m.calculateperimeter();
            Console.WriteLine("The perimeter of rectangle : "+p);

        }
       

    }
    //---------------------------------------------------------------------------------------------------------
    class calculater  //checkkkkkkkkkkkkkkkkkkkk
    {
        int a, b;
       
        public void accept()
        {
            Console.WriteLine("Enter the value of a and b :");
             a = int.Parse(Console.ReadLine());

             b = int.Parse(Console.ReadLine());
        }
        public void add()
        {
             int sum = a + b;
            Console.WriteLine("The sum od "+sum);
        }
        public void sub()
        {
            int c = b - a;
            Console.WriteLine(c);

        }
        public void mul()
        {
            int c = a * b;
            Console.WriteLine(c);

        }
       public void div()
        {
            int c = a / b;
            Console.WriteLine(c);

        }
    }
    class mainn
    {
        static void Main(string[] args)
        {
            calculater ob = new calculater();
            ob.accept();
            ob.add();
            ob.sub();
            ob.mul();
            ob.div();
        }
    }

}

