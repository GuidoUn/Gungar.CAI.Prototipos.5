﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gungar.CAI.Prototipos._5.Entidades.DeItinerario
{
    public enum Estado
    {
        Presupuesto = 0,
        Prereserva = 1,
        Pagada = 2,
        Confirmada = 3,
        Cancelada = 4
    }

    public class Itinerario
    {
        public int itinerarioId;
        public DateTime fechaCreacion;
        public Estado estado;
        public Cliente? cliente;
        public List<Pasajero> pasajeros = new List<Pasajero>();
        public DateTime? fechaPrereserva;
        public List<Hotel> hoteles = new List<Hotel>();
        public List<ReservaHotel> hotelesSeleccionados= new List<ReservaHotel>();
        private void setearValoresIniciales()
        {
            itinerarioId = AlmacenItinerarios.obtenerNuevoId();
            fechaCreacion = DateTime.Now;
            estado = Estado.Presupuesto;
        }

        public Itinerario()
        {
            setearValoresIniciales();
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

        public void GenerarPrereserva()
        {
            estado = Estado.Prereserva;
            fechaPrereserva = DateTime.Now;
        }

        public void AgregarHotel(Hotel hotel)
        {
            hoteles.Add(hotel);
        }

        public void AgregarReservaHotel(ReservaHotel hotel)
        {
            hotelesSeleccionados.Add(hotel);
        }
    }
}
