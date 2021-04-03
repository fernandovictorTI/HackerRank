using System;

namespace DayOfTheProgrammer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DayOfProgrammer(2017)); // Output 13.09.2017
            Console.WriteLine(DayOfProgrammer(2016)); // Output 12.09.2016
            Console.WriteLine(DayOfProgrammer(1800)); // Output 12.09.1800
            Console.WriteLine(DayOfProgrammer(1918)); //
        }

        public static string DayOfProgrammer(int year)
        {
            if (year < 1700 || year > 2700)
                throw new ArgumentException("Ano não permitido");

            int quantidadeDiasSemFevereiro = 215;
            bool eAnoBissextos = false;

            // CalendarioJuliano
            if (year < 1917)
                eAnoBissextos = year % 4 == 0;
            else // Calendario gregoriano
            {
                if (year % 400 == 0)
                    eAnoBissextos = true;
                else if (year % 4 == 0 && year % 100 != 0)
                    eAnoBissextos = true;
            }

            if (year == 1918)
            {
                var dia = eAnoBissextos ? quantidadeDiasSemFevereiro + (29 - 13) : quantidadeDiasSemFevereiro + (28 - 13);
                return $"{256 - dia}.09.{year}";
            }
            else
            {
                var dia = eAnoBissextos ? quantidadeDiasSemFevereiro + 29 : quantidadeDiasSemFevereiro + 28;

                return $"{256 - dia}.09.{year}";
            }
        }
    }
}
