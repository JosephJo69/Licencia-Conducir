using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseInterfaces.MisClases
{
    public class Vehiculo
    {
        public string Color { get; set; }
        public string Modelo { get; }
        public int Year { get; }

        private int velocidad = 0;

        protected List<string> tiposLicenciaAceptados = new List<string> { "A", "B", "C" };

        protected int VelocidadMaxima = 200;

        protected int CapacidadTanque = 100;

        protected int ConsumoPorKilometro = 10;


        private Chofer piloto = null;
        private int estadoVehiculo = 0; //0= apagado, 1 = encendido, 2 = en movimiento

        public string asignarPiloto(Chofer elPiloto)
        { 
        if (elPiloto == null)
            {
                return "No se puede asignar un piloto nulo";
            }
        if (!tiposLicenciaAceptados.Contains(elPiloto.TipoLicencia))
            {
                return "El piloto no tiene el tipo de licencia adecuado para ese ehiculo";
            }
        if (piloto != null)
            {
                return "El vehiculo ya tiene un piloto asignado";
            }
            piloto = elPiloto;
            return "Piloto asignado";
        }


        public Vehiculo(int anio, string elColor, string elModelo)
        {
            Color = elColor;
            Modelo = elModelo;
            Year = anio;
            
        }

        public void InformacionVehiculo()
        {
            Console.WriteLine("Color {0}:", Color);
            Console.WriteLine("Modelo {0}:", Modelo);
            Console.WriteLine("Año {0}", Year);
            Console.WriteLine("La velocidad actual es {0} KMS / Hora", velocidad);
            Console.WriteLine("La velocidad maxima es {0} KMS / Hora", VelocidadMaxima);
            if (estadoVehiculo == 1)
            {
                Console.WriteLine("El vehiculo está encendido");
            }
            else
            {
                Console.WriteLine("El vehiculo está apagado");
            }
            if (piloto != null)
            {
                Console.WriteLine("El piloto es {0}", piloto.Nombre);
            }
        }
        public string Encender()
        {
            if (piloto == null)
            {
                return "No puedes encender el carro sin piloto";
            }
            if (estadoVehiculo == 0)
            {
                estadoVehiculo = 1;
                return "Carro encendido";
            }
            return "El carro ya esta encendido";
        }

        public string Apagar ()
        {
            if (estadoVehiculo == 0)
            {
                return "El carro ya esta apagado";
            }
            if (velocidad > 1)
            {
                return "No puedes apagar el carro mientras esta en movimiento";
            }
            estadoVehiculo = 0;
            return "Carro apagado";
        }

        public virtual void acelerar(int cuanto)
        {
            if (estadoVehiculo == 1)
            {
                velocidad += cuanto;
                if (velocidad > VelocidadMaxima)
                {
                    velocidad = VelocidadMaxima;
                    Console.WriteLine("Has alcanzado la velocidad maxima. Vas a {0} KMS / Hora");
                }
                Console.WriteLine("vas a {0} KMS / Hora", velocidad);
            }
            else
            {
                Console.WriteLine("no se puede acelerar con el carro apagado");
            }
        }
        public virtual void frenar(int cuanto)
        {
            if (estadoVehiculo == 1)
            {
                velocidad -= cuanto;
                if (velocidad < 0)
                {
                    velocidad = 0;
                    Console.WriteLine("Has detenido el carro");
                }
                Console.WriteLine("vas a {0} KMS / Hora", velocidad);
            }
            else
            {
                Console.WriteLine("no se puede frenar con el carro apagado");
            }
        }

    }
}
