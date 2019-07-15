using System;
using System.Collections.Generic;
using System.Text;

namespace DesafiosMovi.TravessiaRio
{
    public class Margem
    {
        public Margem(string lado)
        {
            Lado = lado;
        }

        public List<Personagem> Items { get; set; }
        public string Lado { get; set; }

        public override string ToString()
        {
            return this.Lado;
        }

    }
}
