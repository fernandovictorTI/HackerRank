using System;
using System.Collections.Generic;
using System.Linq;

namespace ClimbingLeaderboard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var a = new List<int>() { 100, 90, 90, 80, 75, 60 };
            var b = new List<int>() { 50, 65, 77, 90, 102 };

            Console.WriteLine(climbingLeaderboard(a, b));
        }

        public static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
        {
            var retorno = new List<int>();
            var rankedAux = ranked;

            foreach (var a in player)
            {
                rankedAux.Add(a);

                var index = (rankedAux
                    .Distinct()
                    .OrderByDescending(c => c)
                    .ToList()
                    .IndexOf(a) + 1);

                rankedAux = ranked;

                retorno.Add(index);
            }


            return retorno;
        }
    }
}
