using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ03
{
    struct AuxiliarPaciente
    {
        private string iNombre;
        private int iNumeroDeUrgencia;

        public string Nombre
        {
            get { return iNombre; }
            set { iNombre = value; }
        }

        public int NumeroDeUrgencia
        {
            get { return iNumeroDeUrgencia; }
            set { iNumeroDeUrgencia = value; }
        }
    }
}
