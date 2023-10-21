using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gungar.CAI.Prototipos._5.Entidades.DeItinerario
{
    public class Cliente
    {
        private static int ultimoId = 0;

        public int clienteId;
        public string nombre;
        public string apellido;
        public string? documento;
        public string? email;
        public string? telefono;

        public Cliente(string nombre, string apellido, string? documento, string? email, string? telefono)
        {
            clienteId = ultimoId + 1;
            ultimoId = clienteId;
            this.nombre = nombre;
            this.apellido = apellido;
            this.documento = documento;
            this.email = email;
            this.telefono = telefono;
        }
    }
}
