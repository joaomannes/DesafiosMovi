using DesafiosMovi.NumerosRomanos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesafiosMovi.Tests
{
    [TestClass]
    public class NumerosRomanosTest
    {
        [TestMethod]
        public void Escrever100emRomanos()
        {
            Assert.AreEqual("C", Romanos.ConverterParaRomano(100));
        }

        [TestMethod]
        public void Escrever1000emRomanos()
        {
            Assert.AreEqual("M", Romanos.ConverterParaRomano(1000));
        }

        [TestMethod]
        public void Escrever456emRomanos()
        {
            Assert.AreEqual("CDLVI", Romanos.ConverterParaRomano(456));
        }

        [TestMethod]
        public void Escrever895emRomanos()
        {
            Assert.AreEqual("DCCCXCV", Romanos.ConverterParaRomano(895));
        }

        [TestMethod]
        public void Escrever411emRomanos()
        {
            Assert.AreEqual("CDXI", Romanos.ConverterParaRomano(411));
        }

        [TestMethod]
        public void Escrever389emRomanos()
        {
            Assert.AreEqual("CCCLXXXIX", Romanos.ConverterParaRomano(389));
        }

        [TestMethod]
        public void Escrever888emRomanos()
        {
            Assert.AreEqual("DCCCLXXXVIII", Romanos.ConverterParaRomano(888));
        }
    }
}
