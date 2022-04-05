using System;
using System.Collections.Generic;

namespace DesignerPdfViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(DesignerPdfViewer(new List<int>() { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 }, "abc"));
        }

        /*
     * Complete the 'designerPdfViewer' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY h
     *  2. STRING word
     */

        public static int DesignerPdfViewer(List<int> h, string word)
        {
            var chaveValor = new Dictionary<char, int>();
            var maior = 0;
            var inicial = 'a';

            for (int i = 0; i < 26; i++)
            {
                chaveValor.Add(inicial++, h[i]);
            }

            foreach (var letra in word)
            {
                if (chaveValor.ContainsKey(letra))
                {
                    var letraChaveValor = chaveValor[letra];

                    if (letraChaveValor > maior)
                        maior = letraChaveValor;
                }
            }

            return maior * word.Length;
        }
    }
}
