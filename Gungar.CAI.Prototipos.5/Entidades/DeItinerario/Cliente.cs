using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gungar.CAI.Prototipos._5.Entidades.DeItinerario
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string? Documento { get; set; }
        public string? Email { get; set; }
        public string? Telefono { get; set; }

        public Cliente(string nombre, string apellido, string? documento, string? email, string? telefono)
        {
            Nombre = nombre;
            Apellido = apellido;
            Documento = documento;
            Email = email;
            Telefono = telefono;
        }

        public string GetNombreYApellido()
        {
            return $"{Nombre} {Apellido}";
        }
    }
}
