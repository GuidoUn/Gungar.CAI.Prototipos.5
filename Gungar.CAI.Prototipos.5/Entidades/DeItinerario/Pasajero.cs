using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gungar.CAI.Prototipos._5.Entidades.DeItinerario
{
    public class Pasajero
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Documento { get; set; }
        
        public DateTime FechaNacimiento { get; set; }

        public Pasajero(string nombre, string apellido, string documento, DateTime fechaNacimiento)
        {
            Nombre = nombre;
            Apellido = apellido;
            Documento = documento;
            FechaNacimiento = fechaNacimiento;
        }
    }
}
