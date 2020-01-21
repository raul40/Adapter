using Adaptar.Externos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaptar.Externos
{
    public class DatosExternos : IDatosExternos
    {
        public string ObtenerTotal()
        {
            string cValor = "10.45";
            return cValor;
        }
    }
}
