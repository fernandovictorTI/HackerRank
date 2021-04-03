using System;
using System.Collections.Generic;
using System.Linq;

namespace TheBirthdayBar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Birthday(new List<int> { 1, 2, 1, 3, 2 }, 3, 2)); // Output 2
            Console.WriteLine(Birthday(new List<int> { 1, 1, 1, 1, 1, 1 }, 3, 2)); // Output 0
            Console.WriteLine(Birthday(new List<int> { 4 }, 4, 1)); // Output 1 V
            Console.WriteLine(Birthday(new List<int> { 2, 5, 1, 3, 4, 4, 3, 5, 1, 1, 2, 1, 4, 1, 3, 3, 4, 2, 1 }, 18, 7));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s">os números em cada um dos quadrados de chocolate</param>
        /// <param name="d">dia do nascimento de Ron</param>
        /// <param name="m">mês de nascimento de Ron</param>
        /// <returns></returns>
        public static int Birthday(List<int> s, int d, int m)
        {
            int totalVezes = 0;

            if (m == 1) { return s.Count(c => c == d); }

            if (s.Count >= m)
            {
                var somaArray = 0;

                for (int i = 0; i < m; i++)
                    somaArray += s[i];

                if (somaArray == d)
                    totalVezes++;

                for (int i = 0; i < s.Count - m; i++)
                {
                    somaArray = somaArray - s[i] + s[i + m];

                    if (somaArray == d)
                        totalVezes++;
                }
            }

            return totalVezes;
        }
    }
}
