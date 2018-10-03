using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ03
{
    class ControladorFachada
    {
        Hospital hospital = new Hospital();

        public string Orden()
        {
            if (hospital.Pacientes is ListaFIFO)
                return "Orden de llegada";
            else
                return "Triaje";
        }
        public AuxiliarPaciente[] ArregloPacientes()
        {
            AuxiliarPaciente[] arreglo = new AuxiliarPaciente[hospital.Pacientes.ListaPacientes.Count];
            Lista lista = hospital.Pacientes;
            int i = 0;
            foreach (Paciente p in lista.ListaPacientes)
            {
                arreglo[i].Nombre = p.Nombre;
                arreglo[i].NumeroDeUrgencia = p.NivelDeUrgencia;
                i += 1;
            }
            
            return arreglo;
        }

        public ResultadoAtencion AtenderPaciente()
        {
            if (hospital.Pacientes.ListaPacientes.Count != 0)
            {
                ResultadoAtencion rA = new ResultadoAtencion();
                rA.Resultado = true;
                rA.Nombre = hospital.Pacientes.ListaPacientes.First().Nombre;
                hospital.Pacientes.QuitarPaciente();
                return rA;
            }
            else
            {
                ResultadoAtencion rA = new ResultadoAtencion();
                rA.Resultado = false;
                return rA;
            }
        }

        public void AgregarPaciente(string pNombre, int pNiveldeUrgencia)
        {
            hospital.AgregarPaciente(pNombre, pNiveldeUrgencia);
        }

        public Lista ListaPacientes()
        {
            return hospital.Pacientes;
        }

        public void CambiarATriaje()
        {
            hospital.CambiarATriaje();
        }

        public void CambiarAFIFO()
        {
            hospital.CambiarAFIFO();
        }
    }
}
