﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gungar.CAI.Prototipos._5.Entidades.Itinerario
{
    public enum Estado
    {
        Presupuesto,
        Prereserva,
        Pagada,
        Confirmada,
        Cancelada
    }

    public class Itinerario
    {
        private static int ultimoId = 0;

        public int itinerarioId;
        public DateTime fechaCreacion;
        public Estado estado;
        public Cliente? cliente;
        public List<Pasajero> pasajeros = new List<Pasajero>();

        private void setearValoresIniciales()
        {
            itinerarioId = ultimoId + 1;
            ultimoId = itinerarioId;
            fechaCreacion = DateTime.Now;
            estado = Estado.Presupuesto;
        }

        public Itinerario()
        {
            setearValoresIniciales();
        }

        public Itinerario(Cliente cliente)
        {
            setearValoresIniciales();
            this.cliente = cliente;
        }

        public Itinerario(Cliente cliente, DateTime fechaCreacion)
        {
            setearValoresIniciales();
            this.cliente = cliente;
            this.fechaCreacion = fechaCreacion;
        }

        public void AsignarCliente(Cliente Cliente)
        {
            cliente = Cliente;
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
