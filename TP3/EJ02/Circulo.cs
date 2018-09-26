﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ02
{
    class Circulo : FiguraGeometrica
    {
        private double iRadio;
        private Punto iCentro;

        public Circulo(Punto pCentro, double pRadio)
        {
            this.iRadio = pRadio;
            this.iCentro = pCentro;
        }

        public Circulo(double pX, double pY, double pRadio)
        {
            this.iCentro.X = pX;
            this.iCentro.Y = pY;
            this.iRadio = pRadio;
        }

        public Punto Centro
        {
            get { return this.iCentro; }
            set { this.iCentro = value; }
        }

        public double Radio
        {
            get { return this.iRadio; }
            set { this.iRadio = value; }
        }

        public override double CalcularArea()
        {
           return (Math.PI * Math.Pow(this.iRadio, 2)); 
        }

        public override double CalcularPerimetro()
        {
            return Math.PI * 2 * this.iRadio; 
        }
    }
}
