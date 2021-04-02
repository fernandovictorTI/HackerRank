using System;
using System.Collections.Generic;
using System.Linq;

namespace BetweenTwoSets
{
    class Program
    {
        static void Main(string[] args)
        {
            GetTotalX(new List<int> { 2, 4 }, new List<int> { 16, 32, 96 });
        }

        public static int GetTotalX(List<int> a, List<int> b)
        {
            var totalXs = 0;
            var maximumA = a.Max();
            var minimumB = b.Min();
            var counter = 1;
            var multipleOfMaxA = maximumA;

            while (multipleOfMaxA <= minimumB)
            {
                var factorOfAll = true;

                foreach (var item in a)
                {
                    if (multipleOfMaxA % item != 0)
                        factorOfAll = false;
                }

                if (factorOfAll)
                {
                    foreach (var item in b)
                    {
                        if (item % multipleOfMaxA != 0)
                        {
                            factorOfAll = false;
                            break;
                        }
                    }
                }

                if (factorOfAll)
                    totalXs++;

                counter++;
                multipleOfMaxA = maximumA * counter;
            }

            return totalXs;
        }
    }
}
