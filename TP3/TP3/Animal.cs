using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    public abstract class Animal  // Clase general animal, de la cual los animales especificos heredan.
    {
        // Los métodos saltar y correr se implementan en esta clase ya
        // que todos los animales lo implementan de la misma manera.

        public void Saltar()                
        {
            Console.WriteLine("Saltando");
        }

        public void Correr()
        {
            Console.WriteLine("Corriendo");
        }

        public abstract void HacerRuido();   // Método que implementará cada animal específico.

    }
}
