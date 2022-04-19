using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoSmartCloud
{
    public class Cliente
    {   
        public string Nombre { get; set; }
        public string IdentificacionTributaria { get; set; }
        public int TipoServicio { get; set; }
        /*
         * 0. Premium
         * 1. Golden
         * 2. Bronce
         */
        public int TipoCliente { get; set; }
        /*
         * 1. Nacional
         * 2. Extranjero
         */

    }
}
