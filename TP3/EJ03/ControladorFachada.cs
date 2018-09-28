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

        public AuxiliarPaciente[] ArregloPacientes()
        {
            AuxiliarPaciente[] arreglo = new AuxiliarPaciente[hospital.Lista.Count];
            Lista lista = hospital.Lista;
            AuxiliarPaciente auxiliar = new AuxiliarPaciente();

            for (int i = 0; i < arreglo.Length; i++)
            {
                Paciente primero = lista.First();
                lista.Remove(primero);
                auxiliar.Nombre = primero.Nombre;
                auxiliar.NumeroDeUrgencia = primero.NivelDeUrgencia;
                arreglo[i] = auxiliar;
            }

            return arreglo;
        }

        public bool AtenderPaciente()
        {
            if (hospital.Lista.Count != 0)
            {
                hospital.Lista.QuitarPaciente();
                return true;
            }
            else
                return false;
        }

        public void AgregarPaciente(string pNombre, int pNiveldeUrgencia)
        {
            hospital.AgregarPaciente(pNombre, pNiveldeUrgencia);
        }

        public Lista ListaPacientes()
        {
            return hospital.Lista;
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
