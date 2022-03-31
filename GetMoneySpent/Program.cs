using System;
using System.Linq;

namespace GetMoneySpent
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new[] { 5, 1, 1 };
            int[] b = new[] { 4 };
            Console.WriteLine(getMoneySpent(a, b, 5));
        }
        /*
     * Complete the getMoneySpent function below.
     */
        static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            int expectedResult = -1;

            for (int i = 0; i < keyboards.Length; i++)
            {
                for (int j = 0; j < drives.Length; j++)
                {
                    var soma = keyboards[i] + drives[j];

                    if (soma <= b && soma >= expectedResult)
                    {
                        expectedResult = soma;
                    }
                }
            }

            return expectedResult;
        }
    }
}
