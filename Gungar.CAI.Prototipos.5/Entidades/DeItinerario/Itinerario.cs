using Gungar.CAI.Prototipos._5.Almacenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Gungar.CAI.Prototipos._5.Entidades.DeItinerario.Reservas;
using Gungar.CAI.Prototipos._5.Modulos;
using Gungar.CAI.Prototipos._5.Entidades.Oferta;

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
        public string? tipoDeConfirmacion { get; set; } // Reserva o Pre-reserva // TODO: Podría ser de tipo Estado?
        public DateTime FechaCreacion { get; set; }
        public Estado Estado { get; set; }
        public Cliente? Cliente { get; set; }
        //public List<Pasajero> Pasajeros { get; set; } = new List<Pasajero>(); // No se está usando, habría que usarla?
        public DateTime? FechaPrereserva { get; set; }
        public List<Hotel> Hoteles { get; set; } = new List<Hotel>();
        public List<ReservaHotel> HotelesSeleccionados { get; set; } = new List<ReservaHotel>();
        public List<ReservaVuelo> VuelosAgregados { get; set; } = new List<ReservaVuelo>();
        public bool ItinerarioPagado { get; set; } = false;

        public Itinerario()
        {
            ItinerarioId = VentasModulo.ObtenerNuevoIdItinerario();
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
            DisponibilidadModulo.bloquearDisponibilidad(this);
        }

        private void LiberarDisponibilidadProductos()
        {
            DisponibilidadModulo.liberarDisponibilidad(this);
        }

        //public void AgregarHotel(Hotel hotel) // TODO: Esto se necesita?
        //{
        //    Hoteles.Add(hotel);
        //}

        public void AgregarReservaHotel(ReservaHotel hotel)
        {
            HotelesSeleccionados.Add(hotel);
        }
        public void QuitarReservaHotel(ReservaHotel reservaHotel)
        {
            HotelesSeleccionados.Remove(reservaHotel);
        }
        public void AgregarReservaVuelo(ReservaVuelo reserva)
        {
            if (!VuelosAgregados.Exists(vuelo => vuelo.Vuelo.CodigoOferta == reserva.Vuelo.CodigoOferta))
            {
                VuelosAgregados.Add(reserva);
            }
        }

        public void QuitarReservaVuelo(ReservaVuelo reserva)
        {
            VuelosAgregados.Remove(reserva);
        }

        public float CalcularPrecioTotal()
        {
            float precioTotal = 0;
            VuelosAgregados.ForEach(reserva =>
            {
                precioTotal += reserva.PrecioTotal;
            });
            HotelesSeleccionados.ForEach(reserva =>
            {
                precioTotal += reserva.PrecioTotal;
            });
            return precioTotal;
        }
    }
}
