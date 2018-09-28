using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ03
{
    class ListaTriaje : Lista
    {
       /* private Lista iPacientes;

        public Lista Lista
        {
            get { return iPacientes; }
            set { iPacientes = value; }
        }
        */
        public override void AgregarPaciente(Paciente pPaciente)
        {
            this.Add(pPaciente);
        }

        public override void QuitarPaciente()
        {
            this.Remove(this.First());
        }

        public override void OrdenarLista()
        {
           this.OrderBy(p => p.NivelDeUrgencia).ThenBy(p => p.HoraLlegada).ToList();
        }

        public override Paciente ObtenerSiguientePaciente()
        {
            Paciente paciente = this.First();
            this.Remove(paciente);
            return paciente;
        }
    }
}
