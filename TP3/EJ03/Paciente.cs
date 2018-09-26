using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ03
{
    class Paciente
    {
        private int iNivelDeUrgencia;
        private string iNombre;
        private DateTime iHoraLlegada;

        public Paciente()
        {

        }

        public int NivelDeUrgencia
        {
            get { return iNivelDeUrgencia; }
            set { iNivelDeUrgencia = value; }
        }

        public string Nombre
        {
            get { return iNombre; }
            set { iNombre = value; }
        }

        public DateTime HoraLlegada
        {
            get { return iHoraLlegada; }
            set { iHoraLlegada = value; }
        }
    }
}
