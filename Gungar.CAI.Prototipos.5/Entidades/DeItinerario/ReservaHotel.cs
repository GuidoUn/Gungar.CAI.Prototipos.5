using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gungar.CAI.Prototipos._5.Entidades.DeItinerario
{
    public class ReservaHotel: ReservaProducto
    {
       

        public Hotel Hotel { get; set; }
        public List<Pasajero> Pasajeros { get; set; } // Implementación de la propiedad Pasajeros

        public ReservaHotel(Hotel hotel)
        {
          
            Hotel = hotel;
            Pasajeros = new List<Pasajero>(); // Puedes inicializar la lista aquí o en el constructor
        }

        public ReservaHotel() { }



    }
}
