using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    class Oveja : Animal
    {
        public Oveja()
        {

        }

        public override void HacerRuido()
        {
            Console.WriteLine("beeee");
        }
    }
}
