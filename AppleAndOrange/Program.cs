
using System;
using System.Linq;

namespace AppleAndOrange
{
    class Program
    {
        static void Main(string[] args)
        {
            CountApplesAndOranges(7, 10, 4, 12, new int[3] { 2, 3, -4 }, new int[3] { 3, -2, -4 });
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="s">ponto inicial da localização da casa de Sam.</param>
        /// <param name="t">localização final da localização da casa de Sam</param>
        /// <param name="a">localização da macieira.</param>
        /// <param name="b">localização da laranjeira</param>
        /// <param name="apples">distâncias em que cada maçã cai da árvore</param>
        /// <param name="oranges">distâncias em que cada laranja cai da árvore</param>
        public static void CountApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            var resultApples = apples.Select(applePosition => applePosition + a);
            var resultOranges = oranges.Select(orangePosition => orangePosition + b);

            var countApples = resultApples.Count(c => c >= s && c <= t);
            var countOranges = resultOranges.Count(c => c >= s && c <= t);

            Console.WriteLine(countApples);
            Console.WriteLine(countOranges);
        }
    }
}
