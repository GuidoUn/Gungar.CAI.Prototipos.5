using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gungar.CAI.Prototipos._5
{
    public class Pasajero
    {

        public string Nombre;
        public string Apellido;
        public string Documento;
        public string Telefono;
        public string Email;
        public string FechaNacimiento;

        public Pasajero(string Nombre, string Apellido, string Documento, string Telefono, string Email, string FechaNacimiento)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Documento = Documento;
            this.Telefono = Telefono;
            this.Email = Email;
            this.FechaNacimiento = FechaNacimiento;
        }

    }
}
