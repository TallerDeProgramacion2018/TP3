using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ04
{
    public class EncriptadorCesar : Encriptador
    {
        private string iAbc = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890_-+,#$%&/()=¿?¡!|,.;:{}[]";
        private int iDesplazamiento;

        public EncriptadorCesar(string pNombre, int pDesplazamiento) : base(pNombre)
        {
            iDesplazamiento = pDesplazamiento;
        }

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
                //recorre caracter a caracter el mensaje a cifrar
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
                        //concatena al mensaje cifrado
                        cifrado += iAbc[pos];
                    }
                    else//si no existe el caracter no se cifra
                    {
                        cifrado += pCadena[i];
                    }
                }
            }
            return cifrado;
        }

        public override string Desencriptar(string pCadena)
        {
            iDesplazamiento *= -1;
            string result = Encriptar(pCadena);
            iDesplazamiento *= -1;
            return result;
        }
    }
}
