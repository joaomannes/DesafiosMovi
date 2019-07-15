using System;
using System.Collections.Generic;
using System.Text;

namespace DesafiosMovi.NumerosRomanos
{
    public class Romanos
    {
        public static Dictionary<int, string> Unidades { get; set; }
        public static Dictionary<int, string> Dezenas { get; set; }
        public static Dictionary<int, string> Centenas { get; set; }
        public static Dictionary<int, string> Milhares { get; set; }

        static Romanos()
        {
            Unidades = new Dictionary<int, string>();
            Unidades.Add(0, "");
            Unidades.Add(1, "I");
            Unidades.Add(2, "II");
            Unidades.Add(3, "III");
            Unidades.Add(4, "IV");
            Unidades.Add(5, "V");
            Unidades.Add(6, "VI");
            Unidades.Add(7, "VII");
            Unidades.Add(8, "VIII");
            Unidades.Add(9, "IX");

            Dezenas = new Dictionary<int, string>();
            Dezenas.Add(0, "");
            Dezenas.Add(10, "X");
            Dezenas.Add(20, "XX");
            Dezenas.Add(30, "XXX");
            Dezenas.Add(40, "XL");
            Dezenas.Add(50, "L");
            Dezenas.Add(60, "LX");
            Dezenas.Add(70, "LXX");
            Dezenas.Add(80, "LXXX");
            Dezenas.Add(90, "XC");

            Centenas = new Dictionary<int, string>();
            Centenas.Add(0, "");
            Centenas.Add(100, "C");
            Centenas.Add(200, "CC");
            Centenas.Add(300, "CCC");
            Centenas.Add(400, "CD");
            Centenas.Add(500, "D");
            Centenas.Add(600, "DC");
            Centenas.Add(700, "DCC");
            Centenas.Add(800, "DCCC");
            Centenas.Add(900, "CM");

            Milhares = new Dictionary<int, string>();
            Milhares.Add(1000, "M");
        }

        public static string ConverterParaRomano(int numero)
        {
            string numeroEmRomano = "";

            if (numero < 1 || numero > 1000)
                throw new InvalidNumberException($"O número informado ({numero}) está fora dos limites.");

            if (numero == 1000)
            {
                numeroEmRomano = Milhares[1000];
            }
            else
            {
                int centena = Convert.ToInt32(Math.Floor(numero / 100m));
                numero -= centena * 100;

                int dezena = Convert.ToInt32(Math.Floor(numero / 10m));
                numero -= dezena * 10;

                int unidade = numero;

                StringBuilder stringBuilder = new StringBuilder(numeroEmRomano);
                stringBuilder.Append(Centenas[centena*100]);
                stringBuilder.Append(Dezenas[dezena*10]);
                stringBuilder.Append(Unidades[unidade]);

                numeroEmRomano = stringBuilder.ToString();
            }
            

            
            return numeroEmRomano;
        }
    }
}
