using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gungar.CAI.Prototipos._5.Entidades.DeItinerario
{
    public class Pasajero
    {
        public string Nombre;
        public string Apellido;
        public string Documento;
        public string Telefono;
        public string Email;
        public string FechaNacimiento;

        public Pasajero(string nombre, string apellido, string documento, string telefono, string email, string fechaNacimiento)
        {
            Nombre = nombre;
            Apellido = apellido;
            Documento = documento;
            Telefono = telefono;
            Email = email;
            FechaNacimiento = fechaNacimiento;
        }
    }
}
