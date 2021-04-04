using System;

namespace DrawingBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PageCount(5, 3)); // Output 1
            Console.WriteLine(PageCount(6, 2)); // Output 1
            Console.WriteLine(PageCount(5, 4)); // Output 0
            Console.WriteLine(PageCount(6, 5)); // Output 1
        }

        public static int PageCount(int n, int p)
        {
            int quantidadeTotalDeGirosDaPaginaAPartidaDaFrente = n / 2;
            int quantidadeVezesGiraAPartidaDaFrente = p / 2;
            int quantidadeVezesGiraAPartidaDeTras = quantidadeTotalDeGirosDaPaginaAPartidaDaFrente - quantidadeVezesGiraAPartidaDaFrente;

            return quantidadeVezesGiraAPartidaDaFrente < quantidadeVezesGiraAPartidaDeTras
                    ? quantidadeVezesGiraAPartidaDaFrente
                    : quantidadeVezesGiraAPartidaDeTras;
        }
    }
}
