using System;

namespace CountValleys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(countingValleys(8, "UDDDUDUU"));
        }

        /*
         * Complete the 'countingValleys' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER steps
         *  2. STRING path
         */

        public static int countingValleys(int steps, string path)
        {
            int elevation = 0;
            int valleyCount = 0;
            bool aboveSeaLevel = true;

            foreach (char c in path)
            {
                if (c == 'D')
                    elevation--;
                else
                    elevation++;

                if (elevation < 0 && aboveSeaLevel == true)
                {
                    valleyCount++;
                    aboveSeaLevel = false;
                }
                else if (elevation >= 0 && aboveSeaLevel == false)
                {
                    aboveSeaLevel = true;
                }
            }

            return valleyCount;
        }
    }
}
