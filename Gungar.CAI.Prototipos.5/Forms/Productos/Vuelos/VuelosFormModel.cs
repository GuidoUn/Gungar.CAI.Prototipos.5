using Gungar.CAI.Prototipos._5.Entidades.DeItinerario;
using Gungar.CAI.Prototipos._5.Entidades.DeItinerario.Reservas;
using Gungar.CAI.Prototipos._5.Entidades.Oferta;
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
            return AlmacenVuelos.GetVuelos(origen, destino, cantAdulto, cantMenor, cantInfante, clase, fechaDesde, fechaHasta, precioMin, precioMax);
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
    }
}
