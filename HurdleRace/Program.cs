using System;
using System.Collections.Generic;
using System.Linq;

namespace HurdleRace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(HurdleRaceEasy(4, new List<int>() { 1, 6, 3, 5, 2 }));
            Console.WriteLine(HurdleRaceEasy(5, new List<int>() { 2, 5, 4, 5, 2 }));
        }

        /*
    * Complete the 'hurdleRace' function below.
    *
    * The function is expected to return an INTEGER.
    * The function accepts following parameters:
    *  1. INTEGER k
    *  2. INTEGER_ARRAY height
    */

        public static int HurdleRace(int k, List<int> height)
        {
            int maior = 0;

            for (int i = 0; i < height.Count(); i++)
            {
                if (height[i] > maior)
                    maior = height[i];
            }

            if (k > maior) return 0;

            return maior - k;
        }

        /*
        * Complete the 'hurdleRace' function below.
        *
        * The function is expected to return an INTEGER.
        * The function accepts following parameters:
        *  1. INTEGER k
        *  2. INTEGER_ARRAY height
        */
        public static int HurdleRaceEasy(int k, List<int> height)
        {
            int maior = height.Max();

            if (k > maior) return 0;

            return maior - k;
        }
    }
}
