using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Veterinaria Veterinaria = new Veterinaria();

            Animal[] Animales = { new Perro(), new Gato(), new Oveja(), new Vaca() };

            Veterinaria.AceptarAnimales(Animales);
            Veterinaria.RuidosAnimales();
            Console.ReadKey();

        }
    }
}
