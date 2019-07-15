using System;
using System.Collections.Generic;

namespace DesafiosMovi.TravessiaRio
{
    class Program
    {
        public static Rio rio;
        static void Main(string[] args)
        {
            Personagem leao = new Personagem("Leão");
            Personagem cabra = new Personagem("Cabra");
            Personagem feno = new Personagem("Feno");

            cabra.EhComidoPor = leao;
            feno.EhComidoPor = cabra;

            Margem margemDireita = new Margem("Direita");
            Margem margemEsquerda = new Margem("Esquerda");
            List<Personagem> personagens = new List<Personagem>
            {
                leao,
                cabra,
                feno
            };
            margemEsquerda.Items = personagens;

            rio = new Rio(margemDireita, margemEsquerda);

            while (rio.MargemDireita.Items.Count < 3)
            {
                Personagem selecionado = null;

                while (selecionado == null && (rio.Atual.Items.Count > 1 || rio.Atual == rio.MargemEsquerda))
                {
                    selecionado = rio.Atual.Items[new Random().Next(0, rio.Atual.Items.Count - 1)];

                    List<Personagem> restante = rio.Atual.Items.FindAll(p => p != selecionado);

                    if (restante.Count > 1)
                    {
                        if (restante[0].EhComidoPor == restante[1] || restante[1].EhComidoPor == restante[0])
                        {
                            selecionado = null;
                        }
                    }
                    else
                    {
                        if (restante.Count > 0)
                        {
                            if (restante[0].EhComidoPor != selecionado && selecionado.EhComidoPor != restante[0] && rio.Atual == rio.MargemDireita)
                            {
                                selecionado = null;
                                break;
                            }
                        }
                    }
                    
                }

                Mover(selecionado);
            }

            Console.ReadKey();
        }

        static void Mover(Personagem p)
        {
            if (p != null)
            {
                rio.Atual.Items.Remove(p);
                rio.TrocarMargemAtual();
                rio.Atual.Items.Add(p);
                Console.WriteLine($"Camponês e {p} para margem {rio.Atual}");
            }
            else
            {
                rio.TrocarMargemAtual();
                Console.WriteLine($"Camponês para margem {rio.Atual}");
            }
            
        }
    }
}
