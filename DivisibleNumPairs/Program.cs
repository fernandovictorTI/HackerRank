using System;

namespace DivisibleNumPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DivisibleSumPairs(6, 3, new int[] { 1, 3, 2, 6, 1, 2 })); // Output 5
        }

        public static int DivisibleSumPairs(int n, int k, int[] ar)
        {
            var contador = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n - 1; j++)
                {
                    if ((ar[i] + ar[j + 1]) % k == 0)
                        contador++;
                }
            }

            return contador;
        }
    }
}
