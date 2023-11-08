using Gungar.CAI.Prototipos._5.Entidades.DeItinerario;
using Gungar.CAI.Prototipos._5.Entidades.DeItinerario.Reservas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gungar.CAI.Prototipos._5.Entidades.Oferta
{
    public class PasajeroReservaProducto
    {
        public IReservaProducto ReservaProducto { get; set; }
        public Pasajero Pasajero;

        public PasajeroReservaProducto(IReservaProducto reservaProducto, Pasajero pasajero)
        {
            ReservaProducto = reservaProducto;
            Pasajero = pasajero;
        }
    }
}
