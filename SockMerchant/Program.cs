using System;
using System.Collections.Generic;
using System.Linq;

namespace SockMerchant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FnSockMerchant(9, new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 })); // Output 3
        }

        public static int FnSockMerchant(int n, int[] ar)
        {
            // Modo Easy
            // var contador = ar
            //                 .ToList()
            //                 .GroupBy(c => c)
            //                 .Where(c => c.Count() > 1)
            //                 .Sum(c => c.Count() / 2);

            var contador = 0;
            var pares = new List<int>();

            for (int i = 0; i < n; i++)
            {
                if (pares.Contains(ar[i]))
                {
                    contador++;
                    pares.Remove(ar[i]);
                }
                else
                {
                    pares.Add(ar[i]);
                }
            }

            return contador;
        }
    }
}
