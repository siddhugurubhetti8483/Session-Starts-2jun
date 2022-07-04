using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_pattern
{
    internal class Do_while
    {
        static void Main01(string[] args)
        {
            for (int i = 11; i<=10; i++)
                Console.WriteLine(i);



            int j = 11;
            while(j<=10)
            {
                Console.WriteLine(j);
                j++;
            }

            int k = 11;
            do
            {

                Console.WriteLine(k);
                k++;
            } while (k <= 10);
        }
        static void Main02(string[] args)
        {
            string choice;

            do
            {
                Console.WriteLine("Enter the 2 numbers");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int sum = a + b;
                Console.WriteLine("sum=" + sum);
                Console.WriteLine("Do u want to perform addition once more yes/no");
                choice = Console.ReadLine().ToLower();
            } while (choice == "yes");
        }
    }
}
