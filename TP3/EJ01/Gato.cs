using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    class Gato : Animal
    {
        public Gato()
        {

        }

        public override void HacerRuido()
        {
            Console.WriteLine("miau");
        }
    }
}
