using System;

namespace UtopianTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(UtopianTree(5));
        }

        /*
        * Complete the 'utopianTree' function below.
        *
        * The function is expected to return an INTEGER.
        * The function accepts INTEGER n as parameter.
        */
        public static int UtopianTree(int n)
        {
            if (n == 0) return 1;
            if (n == 1) return 2;

            int upT = 2;

            for (int i = 2; i <= n; i++)
            {
                if (i % 2 == 0)
                    upT += 1;
                else
                {
                    upT *= 2;
                }
            }

            return upT;
        }
    }
}
