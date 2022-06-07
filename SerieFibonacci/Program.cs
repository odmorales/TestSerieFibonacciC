using SerieService;
using System;

namespace SerieFibonacci // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Serie serieService = new Serie();
            int[] serie = serieService.GetSerie(0);

            Console.WriteLine(serie[0]);
        }
    }
}