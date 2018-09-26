using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    class Veterinaria
    {
        private Animal[] iAnimales;

        public Veterinaria()
        {

        }

        public void AceptarAnimales( Animal[] pAnimales)
        {
            this.iAnimales = pAnimales;
        }

        public void RuidosAnimales()
        {
            for (int i = 0; i < iAnimales.Length; i++)
            {
                iAnimales[i].HacerRuido();
            }
        }
    }


}
