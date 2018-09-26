using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ03
{
    abstract class Lista: List<Paciente>
    {
        public List<Paciente> iPacientes;

        public abstract void AgregarPaciente(Paciente pPaciente);

        public abstract void QuitarPaciente(Paciente pPaciente);

        public abstract void OrdenarLista();

        public abstract void ObtenerSiguientePaciente();
    }
}
