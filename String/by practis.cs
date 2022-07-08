using System;
namespace Tog
{
    class TCase
    {
        public string Togglee(string str)
        {
            string tcase = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'A' && str[i] <= 'Z')
                {
                    tcase += ((char)(str[i] + 32));
                }
                else if (str[i] >= 'a' && str[i] <= 'z')
                {
                    tcase += ((char)(str[i] - 32));
                }
                else
                {
                    tcase+= str[i];
                }
            }
            return tcase;
        }
        static void Main(string[] args)
        {
            TCase t = new TCase();
            //Console.WriteLine("Enter the string");
            string s = "Hi I am Siddhu";//Console.ReadLine();
            string togg = t.Togglee(s);
            Console.WriteLine(togg);

        }
    }
    class tg1
    {
        public string ttog (string str)
        {
            string tg = "";
            for(int i =0; i < str.Length; i++)
            {
                if (str[i] >= 'A' && str[i] <= 'Z')
                {
                    tg += ((char)(str[i] + 32));
                }
                else if (str[i] >= 'a' && str[i] <= 'z')
                {
                    tg += ((char)(str[i] - 32));
                }
                else
                {
                    tg += str[i];
                }
            }

            return tg;
        }
        static void Main(string[] args)
        {
            tg1 T = new tg1();
            Console.WriteLine("enter");
            string s = Console.ReadLine();
            string tg = T.ttog(s);
            Console.WriteLine(tg);
            tg1 TC = new tg1();
            Console.WriteLine("Enter again");
            string str = Console.ReadLine();
            string ttg = TC.tOOGLE(str);
            Console.WriteLine(ttg);

        }
        public string tOOGLE (string str)
        {
            string rt = "";
            for(int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                {
                    rt += str[i];
                }
                else if (char.IsLower(str[i]))
                {
                    rt += str[i];
                }
                else
                {
                    rt += str[i];
                }
            }
            return rt;
        }
    }
}

