using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ03
{
    class ListaTriaje : Lista
    {
        public override void AgregarPaciente(Paciente pPaciente)
        {
            this.iListaPacientes.Add(pPaciente);
        }

        public override void QuitarPaciente()
        {
            this.iListaPacientes.Remove(this.iListaPacientes.First());
        }

        public override void OrdenarLista()
        {
           var lista = this.iListaPacientes.OrderBy(p => p.NivelDeUrgencia).ThenBy(p => p.HoraLlegada).ToList();
           this.iListaPacientes = lista;
        }

        public override Paciente ObtenerSiguientePaciente()
        {
            Paciente paciente = this.iListaPacientes.First();
            this.iListaPacientes.Remove(paciente);
            return paciente;
        }
    }
}
