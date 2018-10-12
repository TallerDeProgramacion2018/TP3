using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ03
{
    abstract class Lista    // Clase general de la cual cada tipo de lista implementa sus metodos.
    {
        protected List<Paciente> iListaPacientes = new List<Paciente>();

        public List<Paciente> ListaPacientes
        {
            get {return this.iListaPacientes; }
            set {this.iListaPacientes= value; }
        }

        public abstract void AgregarPaciente(Paciente pPaciente);

        public abstract void QuitarPaciente();

        public abstract void OrdenarLista();

        public abstract Paciente ObtenerSiguientePaciente();
    }
}
