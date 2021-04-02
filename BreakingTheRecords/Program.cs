using System;

namespace BreakingTheRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            BreakingRecords(new int[] { 10, 5, 20, 20, 4, 5, 2, 25, 1 });
            BreakingRecords(new int[] { 0, 9, 3, 10, 2, 20 });
        }

        public static int[] BreakingRecords(int[] scores)
        {
            var max = -1;
            var min = -1;
            var countBestRecord = 0;
            var coutnWorstRecord = 0;

            foreach (int score in scores)
            {
                if (max == -1 && min == -1) { max = score; min = score; continue; }

                if (score > max) { max = score; countBestRecord++; }

                if (score < min) { min = score; coutnWorstRecord++; }
            }

            return new int[] { coutnWorstRecord, countBestRecord };
        }
    }
}
