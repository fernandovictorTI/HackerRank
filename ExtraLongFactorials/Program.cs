using System;
using System.Numerics;

namespace ExtraLongFactorials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            extraLongFactorials(25);
        }

        /*
     * Complete the 'extraLongFactorials' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

        public static void extraLongFactorials(int n)
        {
            BigInteger resuldado = n;
            for (int i = n - 1; i > 0; i--)
            {
                resuldado = resuldado * i;
            }

            Console.WriteLine(resuldado);
        }
    }
}
