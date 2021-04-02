using System;

namespace NumberLineJumps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kangaroo(43, 2, 70, 2));
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x1">Posição inicial do Kangaroo 1</param>
        /// <param name="v1">Distância de salto para canguru 1</param>
        /// <param name="x2">Pposição inicial do Kangaroo 2</param>
        /// <param name="v2">Distância de salto para canguru 2</param>
        public static string Kangaroo(int x1, int v1, int x2, int v2)
        {
            var positionKangaroo1 = x1;
            var positionKangaroo2 = x2;

            while (true)
            {
                if (positionKangaroo2 > positionKangaroo1 && (v2 > v1 || v1 == v2))
                    return "NO";

                if (positionKangaroo1 > positionKangaroo2 && (v1 > v2 || v1 == v2))
                    return "NO";

                positionKangaroo1 = positionKangaroo1 + v1;
                positionKangaroo2 = positionKangaroo2 + v2;

                if (positionKangaroo1 == positionKangaroo2)
                    return "YES";
            }
        }
    }
}
