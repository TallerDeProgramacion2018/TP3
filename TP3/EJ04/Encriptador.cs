using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ04
{
    public abstract class Encriptador: IEncriptador
    {
        private string iNombre;

        public Encriptador(string pNombre)
        {
            iNombre = pNombre;
        }

        public string Nombre
        {
            get { return iNombre ; }
        }

        public abstract string Encriptar(string pCadena);

        public abstract string Desencriptar(string pCadena);
    }
}
