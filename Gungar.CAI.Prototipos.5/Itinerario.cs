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
        Reserva,
        Cancelado
    }

    public class Itinerario
    {
        private static int ultimoId = 0;

        public int itinerarioId;
        public DateTime fechaCreacion;
        public Estado estado;
        public Cliente cliente;
        public List<Pasajero> pasajeros;

        public Itinerario(Cliente cliente)
        {
            this.itinerarioId = ultimoId + 1;
            ultimoId = this.itinerarioId;
            this.cliente = cliente;
            this.fechaCreacion = DateTime.Now;
            this.estado = Estado.Presupuesto;
            this.pasajeros = new List<Pasajero>();
        }
        public Itinerario()
        {
            this.itinerarioId = ultimoId + 1;
            ultimoId = this.itinerarioId;
            this.fechaCreacion = DateTime.Now;
            this.estado = Estado.Presupuesto;
            this.pasajeros = new List<Pasajero>();
        }
        public Itinerario(Cliente cliente, DateTime fechaCreacion)
        {
            this.itinerarioId = ultimoId + 1;
            ultimoId = this.itinerarioId;
            this.cliente = cliente;
            this.fechaCreacion = fechaCreacion;
            this.estado = Estado.Presupuesto;
            this.pasajeros = new List<Pasajero>();
        }

        public void AsignarCliente(Cliente Cliente)
        {
            this.cliente = Cliente;
        }
        public void AgregarPasajero(Pasajero pasajero)
        {
            pasajeros.Add(pasajero);
        }

        public void EliminarPasajero(Pasajero pasajero)
        {
            pasajeros.Remove(pasajero);
        }
    }


}
