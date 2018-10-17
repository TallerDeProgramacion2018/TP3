using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ04
{
    class EncriptadoReverso : Encriptador
    {
        // Este encriptador invierte la cadena proporcionada.

        public EncriptadoReverso(string pNombre) : base(pNombre) { }

        public override string Encriptar(string pCadena)
        {
            char[] cadena = pCadena.ToCharArray();
            Array.Reverse(cadena);
            string cadenaEncriptada = new string(cadena);
            return cadenaEncriptada;
        }

        public override string Desencriptar(string pCadena)
        {
            char[] cadenaEncriptada = pCadena.ToCharArray();
            Array.Reverse(cadenaEncriptada);
            string cadena = new string (cadenaEncriptada);
            string cadenaDesencriptada = new string(cadenaEncriptada);
            return cadenaDesencriptada;
        }
    }
}
