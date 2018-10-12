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
            Console.WriteLine($"    Hospital                                         Orden de atención: {Controlador.Orden()}");
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
                        ResultadoAtencion Atencion = Controlador.AtenderPaciente();
                        if (Atencion.Resultado)
                        {
                            Console.WriteLine($"El Paciente {Atencion.Nombre} fue atendido con éxito.");
                            Console.WriteLine();
                            Console.Write("Presione cualquier tecla para continuar...");
                        }
                        else
                            Console.WriteLine("No hay pacientes para atender.");

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
                        VentanaPrincipal();
                        break;
                    }

                case ConsoleKey.D3:
                    {
                        Console.Clear();
                        Console.WriteLine("Nº Urgencia         Nombre");
                        Console.WriteLine("------------------------------------");
                        AuxiliarPaciente[] arreglo = Controlador.ArregloPacientes();

                        for (int i = 0; i < arreglo.Length; i++)
                        {
                            Console.WriteLine($"{arreglo[i].NumeroDeUrgencia:00}                  {arreglo[i].Nombre}");
                            Console.WriteLine("------------------------------------");
                        }
                        Console.ReadKey();
                        VentanaPrincipal();
                        break;
                    }

                case ConsoleKey.D4:
                    {
                        Console.Clear();
                        Console.Write("Ingrese Ordenamiento deseado:");
                        Console.WriteLine();
                        Console.WriteLine("1- Orden de llegada");
                        Console.WriteLine("2- Orden de Triaje");

                        var entrada2 = Console.ReadKey();
                        switch (entrada2.Key)
                        {

                            case ConsoleKey.D1:
                                {
                                    Console.Clear();
                                    Controlador.CambiarAFIFO();
                                    Console.WriteLine("El ordenamiento se cambió por orden de llegada.");
                                    Console.WriteLine();
                                    Console.WriteLine("Presione cualquier tecla para continuar...");
                                    Console.ReadKey();
                                    break;
                                }

                            case ConsoleKey.D2:
                                {
                                    Console.Clear();
                                    Controlador.CambiarATriaje();
                                    Console.WriteLine("El ordenamiento se cambió por orden Triaje.");
                                    Console.WriteLine();
                                    Console.WriteLine("Presione cualquier tecla para continuar...");
                                    Console.ReadKey();
                                    break;
                                }
                        }
                        VentanaPrincipal();

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

