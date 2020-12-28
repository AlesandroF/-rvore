using System;

namespace Arvore
{
    public static class Program
    {
        public static void Main()
        {
            int[] arvoreCenario1 = { 3, 2, 1, 6, 0, 5 };
            int[] arvoreCenario2 = { 7, 5, 13, 9, 1, 6, 4 };

            arvoreCenario1.ConstruirEImprimirArvore();
            arvoreCenario2.ConstruirEImprimirArvore();

            Console.ReadKey();
        }
    }
}