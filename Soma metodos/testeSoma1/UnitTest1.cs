using NUnit.Framework;
using Soma.modelo;

namespace testeSoma1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Controle controle = new Controle();
            Assert.AreEqual(controle.Calcular("5", "4"), "");
            Assert.AreEqual(controle.resultado, "9");
            Assert.AreEqual(controle.Calcular("5,5", "4"), "");
            Assert.AreEqual(controle.resultado, "9,5");
            Assert.AreEqual(controle.Calcular("5.5", "4"), "");
            Assert.AreEqual(controle.resultado, "9,5");
            Assert.AreEqual(controle.Calcular("5.5", "4a"), "Erro de conversão");
        }
    }
}