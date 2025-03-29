using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseInterfaces.MisClases
{
    public class Moto : Vehiculo
    {
        protected int velocidadMaxima = 150;

        protected int capacidadTanque = 80;

        protected int consumoPorKilometro = 5;

        public Moto(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
            tiposLicenciaAceptados = new List<string> { "M" };
        }


    }
}
