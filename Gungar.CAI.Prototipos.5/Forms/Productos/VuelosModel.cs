using Gungar.CAI.Prototipos._5.Entidades.DeItinerario;
using Gungar.CAI.Prototipos._5.Entidades.Oferta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gungar.CAI.Prototipos._5.Forms.Productos
{
    public class VuelosModel
    {
        public Itinerario? Itinerario { get; set; } = null;
        public bool EsConsulta { get; } = false;
        public bool EsSoloIda { get; set; } = false;
        public bool FormValido { get; set; } = true;

        public VuelosModel(Itinerario? itinerario)
        {
            if (itinerario == null)
            {
                EsConsulta = true;
            }
            else
            {
                this.Itinerario = itinerario;
            }
        }

        public List<OfertaVuelo> GetVuelosDisponibles(string origen, string destino, int cantAdulto, int cantMenor, int cantInfante, char clase, DateTime? fechaDesde, DateTime? fechaHasta, int precioMin, int precioMax)
        {
            return AlmacenVuelos.getVuelos(origen, destino, cantAdulto, cantMenor, cantInfante, clase, fechaDesde, fechaHasta, precioMin, precioMax);
        }
    }
}
