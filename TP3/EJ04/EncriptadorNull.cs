﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ04
{
    class EncriptadorNull: Encriptador
    {

        public EncriptadorNull(string pNombre) : base(pNombre) { }

        public override string Encriptar(string pCadena)
        {
            return pCadena;
        }

        public override string Desencriptar(string pCadena)
        {
            return pCadena;
        }

    }
}
