using System;

namespace Array1
{
    class A
    {
        static void Main(string[] args)
        {
            /*string[] emp = new string[15] { "raj", "akash", "tej", "rani", "vishal", "sachine", "pooja", "aniket", "rahul", "ankit", "santosh", "sushant", "anish", "swati", "anjali" };
           
            foreach (string arremp1 in emp)
            {
                
                {
                    Console.WriteLine(arremp1);
                }
            }
            Console.WriteLine("-----------------------------------------------------------------");*/

            string[] Emp = { "Raj", "akash", "Tej", "Rani", "Vishal", "Sachine", "Pooja", "Aniket", "Rahul", "Ankit", "Santosh", "Sushant", "Anish", "Swati", "Anjali" };

            // Array.Sort(emp);
            for (int i = 0; i < Emp.Length - 10; i++)
            {


                Console.WriteLine("Data1 : " + Emp[i]);


            }
            Console.WriteLine();
            for (int i = 5; i < Emp.Length - 5; i++)
            {

                Console.WriteLine("Data2 : " + Emp[i]);


            }
            Console.WriteLine();
            for (int i = 10; i < Emp.Length; i++)
            {

                Console.WriteLine("Data3 : " + Emp[i]);


            }

        }
    }
     class B
     {
            static void Main(string[] args)
            {
                string[] Users = { "Sumit", "Ramesh", "Aditya", "Rohini", "Monika", "Sweta" };

                Console.WriteLine("List Display");
                for(int i = 0; i < Users.Length; i++)
                {
                    Console.WriteLine(Users[i]);
                }
                Array.Sort(Users);

                Console.WriteLine("Orderd List Display");
                for (int i = 0; i < Users.Length; i++)
                {
                    Console.WriteLine(Users[i]);
                }

                Array.Reverse(Users);
                Console.WriteLine("Desending Order List Display");
                for (int i = 0; i < Users.Length; i++)
                {
                    Console.WriteLine(Users[i]);
                }



            }
     }
    class c
    {
        static void Main(string[] args)
        {
           /* Console.WriteLine("Original array elements:");
            for (int i = 0; i < mixedArray.Length; i++)
            {
                Console.WriteLine(mixedArray[i]);
            }
            object[] result = test(mixedArray);
            Console.WriteLine("\nAfter removing duplicate elements from the said array:");
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }

        }
        public static object[] test(object[] mixedArray)
        {
            return mixedArray.Distinct().ToArray();*/
        }
    }


    class BB
    {
        static void Main(string[] args)
        {
            string[] Name = { "Rahul", "Mohit", "Naman", "Aditya", "Roshani", "Abhay" };
            int count = 0;

            for(int i = 0; i < Name.Length; i++)
            {
                /*for(int j = 0; j < Name[i].Length; j++)
                {
                    count++;
                   // Console.WriteLine(Name[i] + "   -   " + count);

                }*/
                // Console.WriteLine(Name[i] + "   -   " + count);
                count = count + Name[i].Length;
                Console.WriteLine(Name[i] +"(" + Name[i].Length +") = "+ count);
                //Console.WriteLine(count);
            }
        }
    }
    class bb
    {
        static void Main(string[] args)
        {
            int[] num = { 100, 105, 106, 103, 106, 105, 103, 108, 107, 103 };
            Array.Sort(num);

            for (int i = 0; i < num.Length; i++)
            {
                if(((i > 0) && (num[i] == num[i - 1])) || ((i < num.Length -1) && (num[i] == num[i + 1])))
                {

                }
                else
                {
                    Console.WriteLine(num[i]);
                }
            }

        }
    }
    class cc
    {
        static void Main(string[] args)
        {
            int[] num = { 100, 105, 106, 103, 106, 105, 103, 108, 107, 103 };
            Array.Sort(num);

            for (int i = 0; i < num.Length; i++)
            {
                if (((i > 0) && (num[i] == num[i - 1])) || ((i < num.Length - 1) && (num[i] == num[i + 1])))
                {
                    Console.WriteLine(num[i]);
                }
                else
                {
                   // Console.WriteLine(num[i]);
                }
            }

        }
    }













}
    
