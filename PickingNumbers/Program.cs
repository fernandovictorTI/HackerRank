using System;
using System.Collections.Generic;
using System.Linq;

namespace PickingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(pickingNumbers(new List<int>() { 4, 6, 5, 3, 3, 1 }));
        }

        /*
     * Complete the 'pickingNumbers' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

        public static int pickingNumbers(List<int> a)
        {
            a.Sort();
            int lastVal = a[0];
            int totalLen = 1;
            int tempLen = 1;
            for (int i = 1; i < a.Count(); i++)
            {
                if (a[i] - lastVal <= 1)
                {
                    tempLen++;
                    if (tempLen > totalLen)
                    {
                        totalLen = tempLen;
                    }
                }
                else
                {
                    tempLen = 1;
                    lastVal = a[i];
                }

            }
            return totalLen;
        }
    }
}
