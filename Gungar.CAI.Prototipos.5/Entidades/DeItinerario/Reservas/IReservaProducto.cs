using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gungar.CAI.Prototipos._5.Entidades.DeItinerario.Reservas
{
    public interface IReservaProducto
    {
        public List<Pasajero> Pasajeros { get; set; }
        public float PrecioTotal { get; set; }
    }
}
