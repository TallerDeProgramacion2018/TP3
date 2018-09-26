using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ03
{
    class ListaFIFO: Lista
    {
        public override void AgregarPaciente(Paciente pPaciente)
        {
            iPacientes.Add(pPaciente);
        }

        public override void QuitarPaciente(Paciente pPaciente)
        {
            iPacientes.Remove(pPaciente);
        }

        public override void OrdenarLista()
        {
            iPacientes = iPacientes.OrderBy(p => p.NivelDeUrgencia).ToList();
        }

        public override void ObtenerSiguientePaciente()
        {

        }
    }
}
