using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_05_22
{
    class UniqueElements
    {

        static void Main14(string[] args)
        {
            int[] a = { 7, 8, 4, 7, 6, 6, 2, 1, 6, 4, 6 };

            for (int i = 0; i < a.Length; i++)
            {
                int count = 1;

                bool isvisited = false;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (a[i] == a[k])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if (isvisited == false)
                {

                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] == a[j])
                        {
                            count++;
                        }
                    }
                    // if(count==1)//uniqueElements
                    //if(count>1)//duplicate elements
                    //frequency of each element
                    {
                        Console.WriteLine(a[i] + " " + count);
                    }
                }

            }
        }

    }
}
