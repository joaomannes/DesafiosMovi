using System;
using System.Collections.Generic;
using System.Text;

namespace DesafiosMovi.TravessiaRio
{
    public class Rio
    {
        private Margem _atual;

        public Rio(Margem margemDireita, Margem margemEsquerda)
        {
            MargemDireita = margemDireita;
            MargemEsquerda = margemEsquerda;

            if (MargemDireita.Items == null)
                MargemDireita.Items = new List<Personagem>();
            if (MargemEsquerda.Items == null)
                MargemEsquerda.Items = new List<Personagem>();

            this.Atual = MargemEsquerda;
        }

        public Margem MargemDireita { get; set; }
        public Margem MargemEsquerda { get; set; }


        public Margem Atual
        {
            get => _atual;
            private set
            {
                _atual = value;
            }
        }

        public Margem Outra
        {
            get
            {
                if (_atual == MargemDireita)
                    return MargemEsquerda;
                else
                    return MargemDireita;
            }
        }

        public void TrocarMargemAtual()
        {
            if (Atual == MargemDireita)
                Atual = MargemEsquerda;
            else
                Atual = MargemDireita;
        }

    }
}
