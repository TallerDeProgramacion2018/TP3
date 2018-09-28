using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ03
{
    class Program
    {
        static ControladorFachada Controlador = new ControladorFachada();

        static void VentanaPrincipal()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("    Hospital");
            Console.WriteLine();
            Console.WriteLine("1- Atender Paciente");
            Console.WriteLine("2- Agregar Paciente");
            Console.WriteLine("3- Listado de Pacientes");
            Console.WriteLine("4- Cambiar Ordenamiento de Pacientes");
            Console.WriteLine("0- Salir");

            var entrada = Console.ReadKey();
            switch (entrada.Key)
            {
                case ConsoleKey.D1:
                    {
                        Console.Clear();
                        if (Controlador.AtenderPaciente())
                        {
                            Console.WriteLine("Paciente atendido con éxito.");
                            Console.Write("Presione cualquier tecla para continuar...");
                        }
                        Console.ReadKey();
                        VentanaPrincipal();
                        break;
                    }

                case ConsoleKey.D2:
                    {
                        Console.Clear();
                        Console.Write("Ingrese Nombre del Paciente: ");
                        string nombre = Console.ReadLine();
                        Console.WriteLine();

                        Console.WriteLine("Ingrese Nivel de Urgencia del Paciente: ");
                        string nivel = Console.ReadLine();
                        int nivelConvertido = Convert.ToInt16(nivel);

                        Controlador.AgregarPaciente(nombre, nivelConvertido);
                        break;
                    }

                case ConsoleKey.D3:
                    {
                        Console.Clear();
                        Console.WriteLine("Nº Urgencia        Nombre");
                        AuxiliarPaciente[] arreglo = Controlador.ArregloPacientes();

                        for (int i = 0; i < arreglo.Length; i++)
                        {
                            Console.WriteLine($"{arreglo[i].Nombre}        {arreglo[i].NumeroDeUrgencia}");
                        }

                        break;
                    }

                case ConsoleKey.D4:
                    {
                        Console.Clear();
                        Console.Write("Ingrese Nombre del Paciente: ");
                        string nombre = Console.ReadLine();
                        Console.WriteLine();

                        Console.WriteLine("Ingrese Nivel de Urgencia del Paciente: ");
                        string nivel = Console.ReadLine();
                        int nivelConvertido = Convert.ToInt16(nivel);

                        Controlador.AgregarPaciente(nombre, nivelConvertido);
                        break;
                    }

                case ConsoleKey.D0:
                    {
                        break;
                    }
            }
        }


        static void Main(string[] args)
        {
            VentanaPrincipal();
        }
    }
}

