using System;
using System.Collections.Generic;
using System.Text;

namespace DesafiosMovi.TravessiaRio
{
    public class Personagem
    {
        public Personagem(string especie)
        {
            Especie = especie;
        }

        public string Especie { get; set; }

        public Personagem EhComidoPor { get; set; }

        public override string ToString()
        {
            return this.Especie;
        }
    }
}
