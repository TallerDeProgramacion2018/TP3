using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ03
{
    class Hospital
    {
        protected Lista iLista = new ListaFIFO();

        public Lista Pacientes
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
            int cant = Pacientes.ListaPacientes.Count;
            if (cant > 0)
            {
                for (int i = 0; i < cant; i++)
                {
                    Paciente aux = Pacientes.ListaPacientes.First();
                    Pacientes.ListaPacientes.Remove(aux);
                    nuevaLista.ListaPacientes.Add(aux);
                }
                nuevaLista.OrdenarLista();
            }
            Pacientes = nuevaLista;
        }

        public void CambiarAFIFO()
        {
            Lista nuevaLista = new ListaFIFO();
            int cant = Pacientes.ListaPacientes.Count;
            if (cant > 0)
            {
                for (int i = 0; i < cant; i++)
                {
                    Paciente aux = Pacientes.ListaPacientes.First();
                    Pacientes.ListaPacientes.Remove(aux);
                    nuevaLista.ListaPacientes.Add(aux);
                }
                nuevaLista.OrdenarLista();
            }
            Pacientes = nuevaLista;
        }

        /*public void CambiarATriaje()
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
        }*/
    }
}
