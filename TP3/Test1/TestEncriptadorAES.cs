using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EJ04;

namespace Test1
{
    [TestClass]
    public class TestEncriptadorAES
    {
        [TestMethod]
        public void TestEncriptarAES()
        {
            EncriptadorAES encriptador = new EncriptadorAES("AES");
            string cadena = "hola";
            string esperado = "hola";

            string resultado1 = encriptador.Encriptar(cadena);
            string resultado2 = encriptador.Desencriptar(resultado1);

            Assert.AreEqual(esperado, resultado2);
        }
    }
}
