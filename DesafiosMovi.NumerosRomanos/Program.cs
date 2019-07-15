using System;

namespace DesafiosMovi.NumerosRomanos
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcaoContinuar;
            do
            {
                Console.Clear();
                PrintHeader();
                try
                {
                    Console.WriteLine("Digite um número entre 1 e 1000:");
                    int numeroDigitado = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(Romanos.ConverterParaRomano(numeroDigitado));
                }
                catch (InvalidNumberException ex)
                {
                    Console.WriteLine($"Erro convertendo para romano: {ex.Message}");
                }
                catch
                {
                    throw;
                }

                Console.WriteLine("Deseja continuar? (S/N - Padrão N)");
                opcaoContinuar = Console.ReadLine();
            } while (opcaoContinuar.ToUpper() == "S");
        }

        private static void PrintHeader()
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("Números romanos");
            Console.WriteLine("==========================================");
        }
    }
}
