using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseInterfaces.MisClases
{
    class Autobus : Vehiculo
    {
        private bool PuertasAbiertas = false;
        public Autobus(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
            tiposLicenciaAceptados = new List<string> { "C" };
        }


        public void abrirpuertas()
        {
            PuertasAbiertas = true;
            Console.WriteLine("Puertas abiertas");
        }
    }
}


