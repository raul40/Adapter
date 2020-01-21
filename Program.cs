using Adaptar.Adapter;
using Adaptar.Externos;
using Adaptar.Externos.Interfaces;
using Adaptar.Locales.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IDatosExternos datosExternos = new DatosExternos();
            IDatos Datos = new AdapterDatos(datosExternos);
            var iTotal = Datos.ObtenerDatos();
            Console.WriteLine(iTotal);
            Console.ReadLine();
        }
    }
}
