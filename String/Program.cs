using System;

namespace stringprogram
{
    class String_Reverse
    {
        static void Main(string[] args)
        {
            string str = "India is my country";

            string rev = "";
            for(int i = str.Length - 1; i >= 0; i--)
            {
                rev = rev + str[i];
            }
            Console.WriteLine(rev);

            Console.WriteLine("......................................................");
            Console.WriteLine("Second Meyhod\n");

            char[] ch = str.ToCharArray();
            string revers = "";
            for(int i = ch.Length-1; i >= 0; i--)
            {
                revers = revers + ch[i];
            }
            Console.WriteLine(revers);

        }
    }
    class word
    {
        static void Main(string[] args)
        {
            string str = "I love India";
            string[] s = str.Split(" ");

            string word = "";
            for(int i = s.Length-1; i>= 0; i--)
            {
                word += s[i] + " ";
            }
            Console.WriteLine(word);
        }
    }
    class sum_Of_Digits  //Redimade function 
    {
        public int SumOfDigit(string str)
        {
            int sum = 0;
            for (int i = 0; i <= str.Length-1; i++)
            {
                if (Char.IsDigit(str[i]))
                {
                    
                    int x = (int)(Char.GetNumericValue(str[i]));
                    sum = sum + x;
                }
            }

            return sum;
        }
        static void Main(string[] args)
        {
            sum_Of_Digits d = new sum_Of_Digits();
            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();
            int ans = d.SumOfDigit(s);
            Console.WriteLine(ans);
        }
    }
    class sumdigits
    {
        public int SumOfDigit(string str)
        {
            int sum = 0;
            for (int i = 0; i <= str.Length-1; i++)
            {
                if (str[i]>='0' && str[i]<='9')
                {

                    Console.WriteLine(str[i]);
                    sum = sum + str[i];
                }
            }

            return sum;
        }
        static void Main(string[] args)
        {
            sumdigits d = new sumdigits();
            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();
            int ans = d.SumOfDigit(s);
            Console.WriteLine(ans);
        }
    }
    class word_reverse
    {
        static void Main(string[] args)
        {
            string str = "India is my Country";
            string[] s = str.Split(" ");

            string revers = "";
            for(int i = 0; i <= s.Length-1; i++)
            {
                string word = s[i];
                string wordrevers = "";
                
                for(int j = word.Length-1; j >= 0; j--)
                {
                    wordrevers = wordrevers + word[j];
                    
                }
                revers = revers + wordrevers + " ";
                
            }
            Console.WriteLine(revers);
        }
    }
    class Togglecase
    {
        public string MakeToggle(string str)
        {
            string tcase = "";
            for (int i = 0; i < str.Length; i++) 
            {

                if (str[i] >= 'A' && str[i] <= 'Z') 
                {
                    tcase = tcase + ((char)(str[i] + 32));
                }
                else if (str[i] >= 'a' && str[i] <= 'z')
                {
                    tcase = tcase + ((char)(str[i] - 32));
                }
                else
                {
                    tcase = tcase + str[i];
                }
            }

            return tcase;
        }
        static void Main(string[] args)
        {
            Togglecase t = new Togglecase();
            Console.WriteLine("Enter the String");
            string s = Console.ReadLine();
            string toggle = t.MakeToggle(s);
            Console.WriteLine(toggle);
        }

       
    }
    class Toggle // Redimade function
    {
        public string toggle(string str)
        {
            string tcase = "";
            for (int i = 0; i <= str.Length; i++) 
            {
                if (Char.IsUpper(str[i]))
                {
                    tcase = tcase + Char.ToLower(str[i]);
                }
                else if (Char.IsLower(str[i]))
                {
                    tcase = tcase + Char.ToUpper(str[i]);
                }
                else
                {
                    tcase = tcase + str[i];
                }
            }
            return tcase;

        }

        static void Main(string[] args)
        {

            Toggle t = new Toggle();
            Console.WriteLine("Enter the String");
            string s = Console.ReadLine();
            string toggle = t.toggle(s);
            
        }
    }
    class reverse_without_firstandlast
    {
        static void Main(string[] args)
        {
            string a = "India is may country";
            string[] b = a.Split();
            string word = "";
            string rev = "";

            for(int i = 0; i < b.Length; i++)
            {
                word = b[i];
                string revword = "";

                if (i > 0 && i < b.Length - 1)
                {
                    for(int j = word.Length-1; j >= 0; j--)
                    {
                        revword += word [j];
                    }
                    rev += revword + " ";
                }
                else
                {
                    rev += b[i] + " ";
                }
            }
            Console.WriteLine(rev);
        }
    }
    class Patternstring
    {
        static void Main(string[] args)
        {
            string a = "I Like indian culture";
            string[] b = a.Split();
            string word = "";
            for(int i = 0; i < b.Length; i++)
            {
                word += b[i] + " ";
                Console.WriteLine(word +" ");
            }
        }
    }
    class Avg_digit
    {
        static void Main(string[] args)
        {
            string a = "sidmh13";
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] >= '0' && a[i] <= '9')
                {
                    sum += (int)char.GetNumericValue(a[i]);
                }
            }
            Console.WriteLine(sum);
        }
    }
    class frequency
    {
        static void Main(string[] args)
        {
            string str = "My Program"; //
            char[] ch = str.ToCharArray();

            for (int i = 0; i < ch.Length; i++)
            {
                int count = 1;
                bool isvisited = false;
                for ( int k = i - 1; k >= 0; k--)
                {
                    if (ch[k] == ch[i])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if (isvisited == false)
                {
                    for (int j = i + 1; j < ch.Length; j++)
                    {
                        if (ch[i] == ch[j])
                        {
                            count++;
                        }

                    }
                    Console.WriteLine(ch[i] + " " + count);

                }
            }
        }
        static void Main01()
        {
            string str = "My Program";
            char[] ch = str.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                int count = 1;
                bool isvisited = false;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (ch[k] == ch[i])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if (isvisited == false)
                {
                   
                    Console.WriteLine("..............Duplicate....................");

                    //Duplicate
                    for (int j = i + 1; j < ch.Length; j++)
                    {
                        if (ch[i] == ch[j])
                        {
                            count++;
                        }

                    }
                    if (count > 1)
                    {
                        Console.WriteLine(ch[i] + " " + count);

                    }

                    Console.WriteLine("......................Uniq element............");

                    for (int j = i + 1; j < ch.Length; j++)
                    {
                        if (ch[i] == ch[j])
                        {
                            count++;
                        }

                    }
                    if (count == 1)
                    {
                        Console.WriteLine(ch[i] + " " + count);

                    }
                }
            }
        }
    }
    class frequ_word
    {
        public static int CountWordFrequncy(string sentence, string word)
        {
            int count = 0;
            /*for(int i =0; i < sentence.Length; i++)
            {
                i += word.Length;
                count++;
            }*/
            int i = 0;
            while (i < sentence.Length)
            {
                i += word.Length;
                count++;
            }  
            return count;
        }
        public static void Main()
        {
            string sentence;

            Console.Write("Enter the Sentence: ");
            sentence = Console.ReadLine();

            Console.WriteLine(CountWordFrequncy(sentence, "the"));
        }
        
    }
    
    class palindrome
    {
        
        static void Main(string[] args)
        {
            //Print all palindrome numbers from 100 to 500


            for (int i = 1; i <= 100; i++)
            {
                int n = i;
                int rev = 0;

                while (n > 0)
                {
                    int last = n % 10;
                    rev = rev * 10 + last;
                    n = n / 10;
                }
                if (rev == i)
                    Console.WriteLine("Palindrome: " + i);
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
            if (str == rev)
            {
                Console.WriteLine("Its Palindrome");
            }
            else
            {
                Console.WriteLine("Its Not Palindrome");
            }
        }
    }
    class Duplicateword
    {
        public static void Main()
        {
            Console.WriteLine("Enter the sentence");
            //String str = Console.ReadLine();
            string str = "India is my country,The Taj Mahal is famous in india";
            int count;
            str = str.ToLower();
 
            string[] words = str.Split(' ');

            Console.WriteLine("Duplicate words is : ");
            for (int i = 0; i < words.Length; i++)
            {
                //count = 1;
                for (int j = i + 1; j < words.Length; j++)
                {
                    if (words[i]==(words[j]))
                    {
                        //count++;
                        words[j] = "0";
                    }
                }
               
            }
            
        }
    }
 }

