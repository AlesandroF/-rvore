using System;
using System.Collections.Generic;
using System.Linq;

namespace Arvore
{
    public static class ArvoreExtension
    {
        public static void ConstruirEImprimirArvore(this int[] arvore)
        {
            var arvoreList = arvore.ToList();

            (int raiz, int indexRaiz) = ObterRaizEIndexRaiz(arvoreList);
            var galhosEsquerda = ObterGalhosEsquerdos(arvoreList, indexRaiz);
            var galhosDireita = ObterGalhosDireitos(arvoreList, indexRaiz);

            Console.WriteLine("\nRaiz: " + raiz);
            Console.WriteLine("Galhos da esquerda -> " + string.Join(",", galhosEsquerda.Select(x => x).OrderByDescending(e => e)));
            Console.WriteLine("Galhos da direita -> " + string.Join(",", galhosDireita.Select(x => x).OrderByDescending(e => e)));
        }

        private static List<int> ObterGalhosEsquerdos(List<int> arvoreList, int indexRaiz)
        {
            List<int> galhosEsquerda = new List<int>();
            for (int i = 0; i < indexRaiz; i++)
            {
                galhosEsquerda.Add(arvoreList[i]);
            }

            return galhosEsquerda;
        } 
        
        private static List<int> ObterGalhosDireitos(List<int> arvoreList, int indexRaiz)
        {
            List<int> galhosDireita = new List<int>();
            for (int i = indexRaiz + 1; i < arvoreList.Count; i++)
            {
                galhosDireita.Add(arvoreList[i]);
            }

            return galhosDireita;
        }

        private static (int raiz, int indexRaiz) ObterRaizEIndexRaiz(List<int> arvoreList)
        {
            var raizIndex = arvoreList.IndexOf(arvoreList.Max());
            var raiz = arvoreList[raizIndex];

            return (raiz, raizIndex);
        }
    }
}