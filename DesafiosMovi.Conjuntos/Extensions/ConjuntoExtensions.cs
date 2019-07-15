using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DesafiosMovi.Conjuntos.Extensions
{
    public static class ConjuntoExtensions
    {
        /// <summary>
        /// Faz a união de dois arrays
        /// </summary>
        /// <param name="secondArray">Array a ser feito a união</param>
        /// <returns>Novo array contendo a união dos dois objetos</returns>
        public static T[] UnionWith<T>(this T[] array, T[] secondArray)
        {
            //Atribui todos os itens do array atual para o novo array
            T[] newArray = array;

            //Para todos os itens do segundo array, verifica se já está no novo array,
            //Caso não estiver, adiciona no novo array
            for (int i = 0; i < secondArray.Length; i++) 
            {
                if (!newArray.ContainsValue(secondArray[i])) {
                    newArray = newArray.AddItem(secondArray[i]);
                }
            }

            return newArray;
        }

        /// <summary>
        /// Faz a intersecção de dois arrays
        /// </summary>
        /// <param name="secondArray">Array a ser feito a intersecção</param>
        /// <returns>Novo array contendo a intersecção dos dois objetos</returns>
        public static T[] IntersectWith<T>(this T[] array, T[] secondArray)
        {
            T[] newArray = new T[0];

            //Para todos os itens do array atual, verifica se está no segundo,
            //Caso estiver, adiciona no novo array
            for (int i = 0; i < array.Length; i++)
            {
                if (secondArray.ContainsValue(array[i]))
                {
                    newArray = newArray.AddItem(array[i]);
                }
            }

            return newArray;
        }

        /// <summary>
        /// Verifica se o valor informado está contido no array
        /// </summary>
        /// <param name="valor">Valor a ser buscado</param>
        /// <returns>Um valor booleano indicando se consta (true) ou não (false)</returns>
        public static bool ContainsValue<T>(this T[] array, T valor)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(valor))
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Adiciona um item no array
        /// </summary>
        /// <param name="valor">Valor a ser adicionado</param>
        /// <returns>Novo array contendo o item</returns>
        public static T[] AddItem<T>(this T[] array, T valor)
        {
            T[] newArray = new T[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }

            newArray[newArray.Length - 1] = valor;

            return newArray;
        }
    }
}
