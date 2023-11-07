using Gungar.CAI.Prototipos._5.Almacenes;
using Gungar.CAI.Prototipos._5.Entidades.DeItinerario;
using Gungar.CAI.Prototipos._5.Entidades.DeItinerario.Reservas;
using Gungar.CAI.Prototipos._5.Entidades.Oferta;
using Gungar.CAI.Prototipos._5.Modulos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gungar.CAI.Prototipos._5.Forms.Productos.Hoteles
{
    public class HotelesFormModel
    {
        public Itinerario? Itinerario { get; set; } = null;
        public bool EsConsulta { get; } = false;
        public bool EsSoloIda { get; set; } = false;
        public bool FormValido { get; set; } = true;
        public DateTime HastaFechaSeleccionada { get; set; }
        public DateTime DesdeFechaSeleccionada { get; set; }

        public int AdultosEnBusqueda { get; set; }
        public int MenoresEnBusqueda { get; set; }
        public int InfantesEnBusqueda { get; set; }
        public char ClaseEnBusqueda { get; set; }
        public Hotel HotelSeleccionado { get; set; }

        public ReservaHotel HotelAgregadoSeleccionado { get; set; }

        public HotelesFormModel(Itinerario? itinerario)
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

        public List<Hotel> GetHotelesDisponibles(string destino, int cantidadAdultos, int cantidadMenores, int cantidadInfantes, string calificacion, DateTime? fechaDesde = null, DateTime? fechaHasta = null, decimal? precioMinimo = null, decimal? precioMaximo = null)
        {
            return VentasModulo.GetHotelesDisponibles(destino, cantidadAdultos, cantidadMenores, cantidadInfantes, calificacion, fechaDesde, fechaHasta, precioMinimo, precioMaximo);
        }
    }
}
