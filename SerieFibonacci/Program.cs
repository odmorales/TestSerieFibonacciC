using SerieService;
using System;

namespace SerieFibonacci // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Serie serieService = new Serie();
            serieService.GetSerie(10);
        }
    }
}