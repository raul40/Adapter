using Adaptar.Externos.Interfaces;
using Adaptar.Locales.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaptar.Adapter
{
    public class AdapterDatos : IDatos
    {
        private readonly IDatosExternos DatosExternos;

        public AdapterDatos(IDatosExternos _DatosExternos)
        {
            this.DatosExternos = _DatosExternos;
        }

        public decimal ObtenerDatos()
        {
            string cDato = this.DatosExternos.ObtenerTotal();
            decimal cDatoConvertido = 0.0M;

            decimal.TryParse(cDato, out cDatoConvertido);

            return cDatoConvertido;
        }
    }
}
