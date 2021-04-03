using System;
using System.Collections.Generic;

namespace BonAppetit
{
    class Program
    {
        static void Main(string[] args)
        {
            FnBonAppetit(new List<int>() { 3, 10, 2, 9 }, 1, 7); // Output Bon Appetit
            FnBonAppetit(new List<int>() { 3, 10, 2, 9 }, 1, 12); // 5
        }

        public static void FnBonAppetit(List<int> bill, int k, int b)
        {
            var somaTotal = 0;

            for (int i = 0; i < bill.Count; i++)
            {
                if (i != k)
                    somaTotal += bill[i];
            }

            var result = somaTotal / 2;

            if (result == b)
                Console.WriteLine("Bon Appetit");
            else
            {
                Console.WriteLine(b - result);
            }
        }
    }
}
