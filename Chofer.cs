using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClaseInterfaces.Interfaces;

namespace ClaseInterfaces.MisClases
{
    public class Chofer : IPiloto
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string TipoLicencia { get; set; }

        public Chofer(string name, int LaEdad, string LicenciaT)
        {
            Nombre = name;
            Edad = LaEdad;
            TipoLicencia = LicenciaT;

            if (Edad < 16 && TipoLicencia == "M")
            {
                Console.WriteLine("No se puede asignar la licencia M a menores de 16 años");
                TipoLicencia = "A";
            }
            if (Edad <21 && TipoLicencia == "B")
            {
                Console.WriteLine("No se puede asignar la licencia B a menores de 21 años");
                TipoLicencia = "A";
            }
            if (Edad < 23 && TipoLicencia == "A")
            {
                Console.WriteLine("No se puede asignar la licencia A a menores de 23 años");
                TipoLicencia = "B";
            }
        }

        public void mostrarInformacion()
        {
            Console.WriteLine("El piloto es {0}", Nombre);
            Console.WriteLine("Licencia tipo: {0}", TipoLicencia);
        }
    }
}