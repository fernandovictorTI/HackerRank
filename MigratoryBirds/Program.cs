using System;
using System.Collections.Generic;
using System.Linq;

namespace MigratoryBirds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FnMigratoryBirds(new List<int>() { 1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4 })); // Output 3
            Console.WriteLine(FnMigratoryBirds(new List<int>() { 1, 4, 4, 4, 5, 3 })); // Output 4
        }

        public static int FnMigratoryBirds(List<int> arr)
        {
            var groupd = arr.GroupBy(c=> c);
            var indiceMaior = groupd
                                .Where(c=> c.Count() == groupd.Max(d=> d.Count()))
                                .OrderBy(c=> c.Key)
                                .Select(c=> c.Key)
                                .FirstOrDefault();                      

            return indiceMaior;
        }
    }
}
