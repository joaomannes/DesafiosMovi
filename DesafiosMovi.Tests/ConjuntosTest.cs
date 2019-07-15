using DesafiosMovi.Conjuntos.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace DesafiosMovi.Tests
{
    [TestClass]
    public class ConjuntosTest
    {
        [TestMethod]
        public void InterseccaoEntreConjuntos()
        {
            int[] lista1 = new int[]
            {
                1, 2, 6, 7
            };
            int[] lista2 = new int[]
            {
                1, 3 , 8
            };

            var listaInterseccao = lista1.IntersectWith(lista2);

            listaInterseccao = listaInterseccao.OrderBy(p => p).ToArray();

            Assert.AreEqual("1", string.Join(',', listaInterseccao));
        }
        [TestMethod]
        public void UniaoEntreConjuntos()
        {
            int[] lista1 = new int[]
            {
                1, 2, 6, 7
            };
            int[] lista2 = new int[]
            {
                1, 3 , 8
            };

            var listaUniao = lista1.UnionWith(lista2);

            listaUniao = listaUniao.OrderBy(p => p).ToArray();

            Assert.AreEqual("1,2,3,6,7,8", string.Join(',', listaUniao));
        }
        [TestMethod]
        public void InterseccaoEntreConjuntos2()
        {
            int[] lista1 = new int[]
            {
                1, 2, 6, 7
            };
            int[] lista2 = new int[]
            {
                1, 3 , 8, 6
            };

            var listaInterseccao = lista1.IntersectWith(lista2);

            listaInterseccao = listaInterseccao.OrderBy(p => p).ToArray();

            Assert.AreEqual("1,6", string.Join(',', listaInterseccao));
        }
    }
}
