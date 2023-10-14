using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gungar.CAI.Prototipos._5
{
    public class Cliente
    {
        private static int ultimoId = 0;

        public int clienteId;
        public string nombre;
        public string apellido;
        public string? documento;

        public Cliente(string nombre, string apellido)
        {
            this.clienteId = ultimoId + 1;
            ultimoId = this.clienteId;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public Cliente(string nombre, string apellido, string documento)
        {
            this.clienteId = ultimoId + 1;
            ultimoId = this.clienteId;
            this.nombre = nombre;
            this.apellido = apellido;
            this.documento = documento;
        }
    }
}
