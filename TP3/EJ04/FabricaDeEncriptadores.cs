using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ04
{
    public class FabricaDeEncriptadores                                     //SINGLETON
    {
        private static FabricaDeEncriptadores instance = null;
        private Dictionary<string, IEncriptador> iEncriptadores = new Dictionary<string, IEncriptador>();

        protected FabricaDeEncriptadores()
        {
            //Dictionary<string, IEncriptador> iEncriptadores = new Dictionary<string, IEncriptador>();
            iEncriptadores.Add("Cesar", new EncriptadorCesar("Cesar", 8));
            iEncriptadores.Add("AES", new EncriptadorAES("AES"));
            iEncriptadores.Add("Null", new EncriptadorNull("Null"));
        }

        public static FabricaDeEncriptadores Instance       // El método que devuelve el objeto si existe, y si no, lo crea.
        {
            get
            {
                if (instance == null)
                    instance = new FabricaDeEncriptadores();
                return instance;
            }
        }

        public IEncriptador GetEncriptador(string pNombre)
        {
            return iEncriptadores[pNombre];
        }

    }
}
