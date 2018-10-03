using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ03
{
    struct ResultadoAtencion
    {
        private string iNombrePaciente;
        private bool iResultado;

        public bool Resultado
        {
            get { return this.iResultado; }
            set { this.iResultado = value; }
        }

        public string Nombre
        {
            get { return this.iNombrePaciente; }
            set { this.iNombrePaciente = value; }
        }
    }

}
