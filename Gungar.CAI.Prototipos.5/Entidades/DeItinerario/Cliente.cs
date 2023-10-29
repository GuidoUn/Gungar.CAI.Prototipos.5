using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gungar.CAI.Prototipos._5.Entidades.DeItinerario
{
    public class Cliente
    {
        public string Nombre;
        public string Apellido;
        public string? Documento;
        public string? Email;
        public string? Telefono;

        public Cliente(string nombre, string apellido, string? documento, string? email, string? telefono)
        {
            Nombre = nombre;
            Apellido = apellido;
            Documento = documento;
            Email = email;
            Telefono = telefono;
        }
    }
}
