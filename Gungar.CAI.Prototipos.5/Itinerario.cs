using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gungar.CAI.Prototipos._5
{
    public enum Estado
    {
        Presupuesto,
        Prereserva,
        Reserva
    }

    public class Itinerario
    {
        public int itinerarioId;
        public string? nombreCliente;
        public DateTime fechaCreacion;
        public Estado estado;

        public Itinerario(int itinerarioId, string? nombreCliente, DateTime fechaCreacion)
        {
            this.itinerarioId = itinerarioId;
            this.nombreCliente = nombreCliente;
            this.fechaCreacion = fechaCreacion;
            this.estado = Estado.Presupuesto;
        }
    }


}
