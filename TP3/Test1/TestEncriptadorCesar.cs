using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EJ04;

namespace TestEncriptador
{
    [TestClass]
    public class EncriptadorCesarTest
    {
        [TestMethod]
        public void TestEncriptarCesar()
        {
            string palabra = "hola tu";
            string palabraesperada = "jqnc vw";
            int desplazamiento = 2;

            EncriptadorCesar cesar = new EncriptadorCesar("Cesar", desplazamiento);
            string resultado = cesar.Encriptar(palabra);

            Assert.AreEqual(palabraesperada, resultado);
        }

        [TestMethod]
        public void TestDesencriptarCesar()
        {
            string palabra = "lspe";
            string palabraesperada = "hola";
            int desplazamiento = 4;

            EncriptadorCesar cesar = new EncriptadorCesar("Cesar", desplazamiento);
            string resultado = cesar.Desencriptar(palabra);

            Assert.AreEqual(palabraesperada, resultado);
        }
    }
}
