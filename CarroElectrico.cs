using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseInterfaces.MisClases
{
    internal class CarroElectrico : Vehiculo
    {
        protected new int VelocidadMaxima = 150;

        protected int ConsumoBateria = 5;

        protected int CapacidadBateria = 100;

        private int cargaBateria;
        public CarroElectrico(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
            cargaBateria = 50;
        }

        public override void acelerar(int cuanto)
        {
            base.acelerar(cuanto);
            cargaBateria--;
        }


        public int NivelBateria() { return cargaBateria; }
        public void cargarBateria()
        {
            cargaBateria++;
        }


    }
}
