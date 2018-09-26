﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ02
{
    class Triangulo : FiguraGeometrica
    {
        private Punto iPunto1;
        private Punto iPunto2;
        private Punto iPunto3;

        public Triangulo(Punto pPunto1, Punto pPunto2, Punto pPunto3)
        {
            this.iPunto1 = pPunto1;
            this.iPunto2 = pPunto2;
            this.iPunto3 = pPunto3;
        }

        public Punto Punto1
        {
            get { return this.iPunto1; }
            set { this.iPunto1 = value; }
        }

        public Punto Punto2
        {
            get { return this.iPunto2; }
            set { this.iPunto2 = value; }
        }

        public Punto Punto3
        {
            get { return this.iPunto3; }
            set { this.iPunto3 = value; }
        }

        //Este método calcula el perímetro de un triángulo sumando las distancias entre ellos.
        public override double CalcularPerimetro()
        {
            return (iPunto1.CalcularDistanciaDesde(iPunto2) + iPunto1.CalcularDistanciaDesde(iPunto3) + iPunto2.CalcularDistanciaDesde(iPunto3));
        }

        //Este método calcula el área utilizando la formula de Herón.
        public override double CalcularArea()
        {
            double semip = this.CalcularPerimetro() / 2;
            return Math.Sqrt(semip * (semip - iPunto1.CalcularDistanciaDesde(iPunto2)) * (semip - iPunto1.CalcularDistanciaDesde(iPunto3)) * (semip - iPunto2.CalcularDistanciaDesde(iPunto3)));
        }
    }
}
