using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ03
{
    class Hospital
    {
        private Lista iLista = new ListaFIFO();

        public Lista Lista
        {
            get { return iLista; }
            set { iLista = value; }
        }

        public void AgregarPaciente(string pNombre , int pNiveldeUrgencia)
        {
            Paciente paciente = new Paciente(pNombre);
            paciente.HoraLlegada = DateTime.Now;
            paciente.NivelDeUrgencia = pNiveldeUrgencia;
            iLista.AgregarPaciente(paciente);
            iLista.OrdenarLista();
        }

        public void CambiarATriaje()
        {
            Lista nuevaLista = new ListaTriaje();
            nuevaLista = iLista;
            nuevaLista.OrdenarLista();
            Lista = nuevaLista;
        }

        public void CambiarAFIFO()
        {
            Lista nuevaLista = new ListaFIFO();
            nuevaLista = iLista;
            nuevaLista.OrdenarLista();
            Lista = nuevaLista;
        }
    }
}
