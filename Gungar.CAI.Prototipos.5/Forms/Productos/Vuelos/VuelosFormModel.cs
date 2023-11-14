using Gungar.CAI.Prototipos._5.Entidades.DeItinerario;
using Gungar.CAI.Prototipos._5.Entidades.DeItinerario.Reservas;
using Gungar.CAI.Prototipos._5.Entidades.Oferta;
using Gungar.CAI.Prototipos._5.Modulos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gungar.CAI.Prototipos._5.Forms.Productos.Vuelos
{
    public class VuelosFormModel
    {
        public Itinerario? Itinerario { get; set; } = null;
        public bool EsConsulta { get; } = false;
        public bool EsSoloIda { get; set; } = false;
        public bool FormValido { get; set; } = true;

        public DateTime? FechaIdaSeleccionada { get; set; } = null;
        public DateTime? FechaVueltaSeleccionada { get; set; } = null;

        public int AdultosEnBusqueda { get; set; }
        public int MenoresEnBusqueda { get; set; }
        public int InfantesEnBusqueda { get; set; }
        public char ClaseEnBusqueda { get; set; }

        public VuelosFormModel(Itinerario? itinerario)
        {
            if (itinerario == null)
            {
                EsConsulta = true;
            }
            else
            {
                Itinerario = itinerario;
            }
        }

        public List<OfertaVuelo> GetVuelosDisponibles(string origen, string destino, int cantAdulto, int cantMenor, int cantInfante, char clase, DateTime? fechaDesde, DateTime? fechaHasta, int precioMin, int precioMax)
        {

            return VentasModulo.GetVuelosDisponibles(origen, destino, cantAdulto, cantMenor, cantInfante, clase, fechaDesde == null ? DateTime.Now.Date : fechaDesde, fechaHasta, precioMin, precioMax, Itinerario);
        }

        public List<ReservaVuelo> GetVuelosAgregados()
        {
            return Itinerario?.VuelosAgregados ?? new();
        }

        public void agregarVuelo(OfertaVuelo vuelo, char clase, int cantidadAdultos, int cantidadMenores, int cantidadInfantes)
        {
            ReservaVuelo nuevaReserva = new(vuelo, clase, cantidadAdultos, cantidadMenores, cantidadInfantes);
            Itinerario?.AgregarReservaVuelo(nuevaReserva);
        }

        public void quitarVuelo(ReservaVuelo vuelo)
        {
            Itinerario?.QuitarReservaVuelo(vuelo);
        }

        public bool FechasValidas(DateTime fechaAIngresar,DateTime fechaAComparar)
        {
            return fechaAIngresar >= fechaAComparar;
        }
    }
}
