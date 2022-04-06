using System;
using System.Collections.Generic;
using System.Linq;

namespace NonDivisibleSubset
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NonDivisibleSubset(3, new List<int>() { 1, 7, 2, 4 }));
            Console.WriteLine(NonDivisibleSubset(4, new List<int>() { 19, 10, 12, 10, 24, 25, 22 }));
            Console.WriteLine(NonDivisibleSubset(7, new List<int>() { 278, 576, 496, 727, 410, 124, 338, 149, 209, 702, 282, 718, 771, 575, 436 }));

        }

        /*
        * Complete the 'nonDivisibleSubset' function below.
        *
        * The function is expected to return an INTEGER.
        * The function accepts following parameters:
        *  1. INTEGER k
        *  2. INTEGER_ARRAY s
        */
        public static int NonDivisibleSubset(int k, List<int> s)
        {

            int[] restArr = new int[k];

            foreach (var item in s)
            {
                restArr[item % k]++;
            }

            int zeroRemainder = restArr[0];
            int maxNumberOfDivisibleSet = zeroRemainder > 0 ? 1 : 0;

            for (int i = 1; i <= (k / 2); i++)
            {
                if (i != k - i)
                    maxNumberOfDivisibleSet += Math.Max(restArr[i], restArr[k - i]);
                else
                    maxNumberOfDivisibleSet++;
            }

            return maxNumberOfDivisibleSet;
        }

    }
}
