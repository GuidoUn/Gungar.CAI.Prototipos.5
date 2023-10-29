using Gungar.CAI.Prototipos._5.Entidades.Oferta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gungar.CAI.Prototipos._5.Entidades.DeItinerario
{
    public class ReservaVuelo : ReservaProducto
    {
        public OfertaVuelo Vuelo { get; set; }
        public List<Pasajero> Pasajeros { get; set; }

        public ReservaVuelo(OfertaVuelo vuelo)
        {
            Vuelo = vuelo;
            Pasajeros = new List<Pasajero>();
        }
    }
}
