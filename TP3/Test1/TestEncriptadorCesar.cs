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
            // Método de la prueba unitaria para probar el funcionamiento del encriptador.
        {
            string palabra = "hola";
            string palabraesperada = "jqnc";
            int desplazamiento = 2;

            EncriptadorCesar cesar = new EncriptadorCesar("Cesar", desplazamiento);
            string resultado = cesar.Encriptar(palabra);

            Assert.AreEqual(palabraesperada, resultado);
        }

        [TestMethod]
        public void TestDesencriptarCesar()
        {
            string palabra = "jqnc";
            string palabraesperada = "hola";
            int desplazamiento = 2;

            EncriptadorCesar cesar = new EncriptadorCesar("Cesar", desplazamiento);
            string resultado = cesar.Desencriptar(palabra);

            Assert.AreEqual(palabraesperada, resultado);
        }
    }
}
