using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ04
{
    class Program
    {
        static ControladorFachada Controlador = new ControladorFachada();

        static void VentanaPrincipal()
        {
            Console.Clear();
            Console.WriteLine("1 - Encriptar cadena");
            Console.WriteLine("2 - Desencriptar cadena");
            Console.WriteLine("0 - Salir");

            var entrada = Console.ReadKey();
            switch (entrada.Key)
            {
                case ConsoleKey.D1:
                    {
                        VentanaEncriptar();
                        break;
                    }

                case ConsoleKey.D2:
                    {
                        VentanaDesencriptar();
                        break;
                    }
            }
        }

        static void VentanaEncriptar()
        {
            Console.Clear();
            Console.Write("Ingrese la palabra que desea encriptar: ");
            string cadena = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Seleccione el encriptador que desea utilizar");
            Console.WriteLine("1 - Encriptador Cesar");
            Console.WriteLine("2 - Encriptador AES");
            Console.WriteLine("3 - Encriptador Null");
            Console.WriteLine("4 - Encriptador Reverso");
            Console.WriteLine();
            Console.WriteLine("0 - Volver a menu principal");

            var entrada = Console.ReadKey();
            switch (entrada.Key)
            {
                case ConsoleKey.D1:
                    {
                        Console.Clear();
                        Console.WriteLine($"La palabra encriptada es: {Controlador.Encriptar(cadena, "Cesar")}");
                        Console.ReadKey();
                        VentanaPrincipal();
                        break;
                    }

                case ConsoleKey.D2:
                    {
                        Console.Clear();
                        Console.WriteLine($"La palabra encriptada es: {Controlador.Encriptar(cadena, "AES")}");
                        Console.ReadKey();
                        VentanaPrincipal();
                        break;
                    }

                case ConsoleKey.D3:
                    {
                        Console.Clear();
                        Console.WriteLine($"La palabra encriptada es: {Controlador.Encriptar(cadena, "Null")}");
                        Console.ReadKey();
                        VentanaPrincipal();
                        break;
                    }

                case ConsoleKey.D4:
                    {
                        Console.Clear();
                        Console.WriteLine($"La palabra encriptada es: {Controlador.Encriptar(cadena, "Reverso")}");
                        Console.ReadKey();
                        VentanaPrincipal();
                        break;
                    }

                case ConsoleKey.D0:
                    {
                        VentanaPrincipal();
                        break;
                    }
            }
        }

        static void VentanaDesencriptar()
        {
            Console.Clear();
            Console.Write("Ingrese la palabra que desea desencriptar: ");
            string cadena = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Seleccione el encriptador que desea utilizar");
            Console.WriteLine("1 - Encriptador Cesar");
            Console.WriteLine("2 - Eencriptador AES");
            Console.WriteLine("3 - Encriptador Null");
            Console.WriteLine("4 - Encriptador Reverso");

            Console.WriteLine();
            Console.WriteLine("0 - Volve a ventana principal");

            var entrada = Console.ReadKey();
            switch (entrada.Key)
            {
                case ConsoleKey.D1:
                    {
                        Console.Clear();
                        Console.WriteLine($"La palabra desencriptada es: {Controlador.Desencriptar(cadena, "Cesar")}");
                        Console.ReadKey();
                        VentanaPrincipal();
                        break;
                    }

                case ConsoleKey.D2:
                    {
                        Console.Clear();
                        Console.WriteLine($"La palabra desencriptada es: {Controlador.Desencriptar(cadena, "AES")}");
                        Console.ReadKey();
                        VentanaPrincipal();
                        break;
                    }

                case ConsoleKey.D3:
                    {
                        Console.Clear();
                        Console.WriteLine($"La palabra desencriptada es: {Controlador.Desencriptar(cadena, "Null")}");
                        Console.ReadKey();
                        VentanaPrincipal();
                        break;
                    }

                case ConsoleKey.D4:
                    {
                        Console.Clear();
                        Console.WriteLine($"La palabra desencriptada es: {Controlador.Desencriptar(cadena, "Reverso")}");
                        Console.ReadKey();
                        VentanaPrincipal();
                        break;
                    }

                case ConsoleKey.D0:
                    {
                        VentanaPrincipal();
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
