using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    class Perro : Animal  
    {
        public Perro()
        {

        }

        public override void HacerRuido()
        {
            Console.WriteLine("guau");
        }
    }
}
