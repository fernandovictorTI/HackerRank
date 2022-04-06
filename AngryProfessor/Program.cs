using System;
using System.Collections.Generic;
using System.Linq;

namespace AngryProfessor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(AngryProfessor(3, new List<int>() { -2, -1, 0, 1, 2 }));
        }

        /*
        * Complete the 'angryProfessor' function below.
        *
        * The function is expected to return a STRING.
        * The function accepts following parameters:
        *  1. INTEGER k
        *  2. INTEGER_ARRAY a
        */
        public static string AngryProfessor(int k, List<int> a)
        {
            var quantidadeChegouNoHorario = a.Count(c => c <= 0);
            return quantidadeChegouNoHorario >= k ? "NO" : "YES";
        }
    }
}
