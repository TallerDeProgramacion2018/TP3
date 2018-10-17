using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ04
{
    class ControladorFachada
    {


        public string Encriptar (string pPalabra, string pNombre)
        {
            FabricaDeEncriptadores fabrica = FabricaDeEncriptadores.Instance;
            IEncriptador encriptador = fabrica.GetEncriptador(pNombre);
            return (encriptador.Encriptar(pPalabra));
        }

        public string Desencriptar (string pPalabraEncriptada, string pNombre)
        {
            FabricaDeEncriptadores fabrica = FabricaDeEncriptadores.Instance;
            IEncriptador encriptador = fabrica.GetEncriptador(pNombre);
            return (encriptador.Desencriptar(pPalabraEncriptada));
        }
    }
}
