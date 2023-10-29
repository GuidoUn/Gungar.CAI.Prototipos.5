using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Gungar.CAI.Prototipos._5.Entidades.DeItinerario
{
    public enum Estado
    {
        Presupuesto = 0,    // Inicial
        Prereserva = 1,     // Dura 48hs
        Reserva = 2,        // Pagó
        Confirmada = 3,     // Se confirmó con los proveedores
        Cancelada = 4       // RIP
    }

    public class Itinerario
    {
        public int ItinerarioId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public Estado Estado { get; set; }
        public Cliente? Cliente { get; set; }
        public List<Pasajero> Pasajeros { get; set; } = new List<Pasajero>();
        public DateTime? FechaPrereserva { get; set; }
        public List<Hotel> Hoteles { get; set; } = new List<Hotel>();
        public List<ReservaHotel> HotelesSeleccionados { get; set; } = new List<ReservaHotel>();
        public List<ReservaVuelo> VuelosAgregados { get; set; } = new List<ReservaVuelo>();
        public bool ItinerarioPagado { get; set; } = false;

        public Itinerario()
        {
            ItinerarioId = AlmacenItinerarios.ObtenerNuevoId();
            FechaCreacion = DateTime.Now;
            Estado = Estado.Presupuesto;
        }

        public void AsignarCliente(Cliente cliente)
        {
            Cliente = cliente;
        }

        public void GenerarPrereserva()
        {
            Estado = Estado.Prereserva;
            FechaPrereserva = DateTime.Now;
            BloquearDisponibilidadProductos();
        }

        public void GenerarReserva()
        {
            Estado = Estado.Reserva;
            BloquearDisponibilidadProductos();
        }

        public void EvaluarVencimientoPrereserva()
        {
            if (Estado == Estado.Prereserva && ItinerarioPagado == false)
            {
                TimeSpan diferenciaDeHoras = DateTime.Now.Subtract(FechaPrereserva ?? DateTime.Now);
                if (diferenciaDeHoras.TotalDays > 2)
                {
                    CancelarItinerario();
                }
            }
        }

        public void CancelarItinerario()
        {
            Estado = Estado.Cancelada;
            LiberarDisponibilidadProductos();
        }

        private void BloquearDisponibilidadProductos()
        {
            Hoteles.ForEach(hotel => HotelesModel.ModificarDisponibilidadHotel(hotel, false));
            // TODO: Bloquear vuelos
        }

        private void LiberarDisponibilidadProductos()
        {
            Hoteles.ForEach(hotel => HotelesModel.ModificarDisponibilidadHotel(hotel, true));
            // TODO: Liberar vuelos
        }

        public void AgregarHotel(Hotel hotel) // TODO: Esto se necesita?
        {
            Hoteles.Add(hotel);
        }

        public void AgregarReservaHotel(ReservaHotel hotel)
        {
            HotelesSeleccionados.Add(hotel);
        }
    }
}
