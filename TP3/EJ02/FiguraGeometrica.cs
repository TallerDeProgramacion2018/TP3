using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ02
{
    // Clase abstracta de la cual circulo y triángulo implementan   
    // los métodos CalcularArea y CalcularPerimetro.

    abstract class FiguraGeometrica
    {
        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();
    }
}
