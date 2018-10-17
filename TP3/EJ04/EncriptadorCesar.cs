using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ04
{
    public class EncriptadorCesar : Encriptador
    {
        // Definimos una cadena con los caracteres que usaremos para desencriptar.
        private string iAbc = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890_-+,#$%&/()=¿?¡!|,.;:{}[]";
        private int iDesplazamiento;

        public EncriptadorCesar(string pNombre, int pDesplazamiento) : base(pNombre)
        {
            iDesplazamiento = pDesplazamiento;
        }

        // Obtiene la posicion en la cadena iAbc de un caracter.
        public int ObtenerPosicionABC(char pCaracter)
        {
            for (int pos = 0; pos < iAbc.Length; pos++)
            {
                if (iAbc[pos] == pCaracter)
                    return pos;
            }
            return -1;
        }
        

        public override string Encriptar(string pCadena)
        {
            String cifrado = "";
            if (iDesplazamiento != 0 && iDesplazamiento < iAbc.Length)
            {
                // Recorre caracter a caracter el mensaje a cifrar
                for (int i = 0; i < pCadena.Length; i++)
                {
                    int posCaracter = ObtenerPosicionABC(pCadena[i]);
                    if (posCaracter != -1) //el caracter existe en la variable abc
                    {
                        int pos = posCaracter + iDesplazamiento;
                        while (pos >= iAbc.Length)
                        {
                            pos = pos - iAbc.Length;
                        }
                        // Concatena al mensaje cifrado
                        cifrado += iAbc[pos];
                    }
                    else // Si no existe el caracter no se cifra
                    {
                        cifrado += pCadena[i];
                    }
                }
            }
            return cifrado;
        }

        // Este método desencripta utilizando el método 
        // encriptar, pero invirtiendo el arreglo de caracteres.
        public override string Desencriptar(string pCadena)
        {
            char[] abc = iAbc.ToCharArray();
            Array.Reverse(abc);
            string abc2 = new string(abc);
            iAbc = abc2;

            string result = Encriptar(pCadena);

            abc = iAbc.ToCharArray();
            Array.Reverse(abc);
            abc2 = new string(abc);
            iAbc = abc2;
            return result;
        }
    }
}
