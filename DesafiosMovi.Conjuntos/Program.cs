using DesafiosMovi.Conjuntos.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesafiosMovi.Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintHeader();

            try
            {
                Console.WriteLine("Digite a primeira sequência de valores (separado por vírgula): ");
                string[] sequencia1 = Console.ReadLine().Split(',');
                Console.WriteLine("Digite a segunda sequência de valores (separado por vírgula): ");
                string[] sequencia2 = Console.ReadLine().Split(',');

                string[] resultadoUniao = sequencia1.UnionWith(sequencia2);
                resultadoUniao = resultadoUniao.OrderBy(p => p).ToArray();

                string[] resultadoInterseccao = sequencia1.IntersectWith(sequencia2);
                resultadoInterseccao = resultadoInterseccao.OrderBy(p => p).ToArray();

                Console.WriteLine($"Intersecção: {string.Join(",", resultadoInterseccao)}");
                Console.WriteLine($"União: {string.Join(",", resultadoUniao)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro processando conjuntos. Erro: {ex.Message}");
            }
        }

        private static void PrintHeader()
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("Números romanos");
            Console.WriteLine("==========================================");
        }
    }
}
