using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace ClaseInterfaces.MisClases
{
   
    public class Trailer : Vehiculo
    {
        protected int velocidadMaxima = 100;

        protected int capacidadTanque = 200;

        protected int consumoPorKilometro = 15;



        private bool limpiaParabrisas = false;

        private bool lucesEncendidas = false;
        public Trailer(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
            tiposLicenciaAceptados = new List<string> { "A" };
        }

        public void encenderLuces()
        {
            lucesEncendidas = true;
            Console.WriteLine("Luces encendidas");
        }

        public void apagarLuces()
        {
            lucesEncendidas = false;
            Console.WriteLine("Luces apagadas");
        }

        public void encenderLimpiaParabrisas()
        {
            limpiaParabrisas = true;
            Console.WriteLine("Limpia parabrisas encendido");
        }

        public void apagarLimpiaParabrisas()
        {
            limpiaParabrisas = false;
            Console.WriteLine("Limpia parabrisas apagado");
        }


    }
}
