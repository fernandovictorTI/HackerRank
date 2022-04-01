using System;

namespace CatAndMouse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(catAndMouse(2, 5, 4));
        }

        // Complete the catAndMouse function below.
        static string catAndMouse(int x, int y, int z)
        {
            int quantidadeVezesGatoA = Math.Abs(x - z);
            int quantidadeVezesGatoB = Math.Abs(y - z);

            if (quantidadeVezesGatoA == quantidadeVezesGatoB)
            {
                return "Mouse C";
            }
            else if (quantidadeVezesGatoA > quantidadeVezesGatoB)
            {
                return "Cat B";
            }
            else
            {
                return "Cat A";
            }
        }
    }
}
