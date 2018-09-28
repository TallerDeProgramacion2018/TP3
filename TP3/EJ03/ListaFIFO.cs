﻿using System;
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
            this.Add(pPaciente);
        }

        public override void QuitarPaciente()
        {
            this.Remove(this.First());
        }

        public override void OrdenarLista()
        {
            this.OrderBy(p => p.HoraLlegada).ToList();
        }

        public override Paciente ObtenerSiguientePaciente()
        {
            Paciente paciente = this.First();
            this.Remove(paciente);
            return paciente;
        }
    }
}
