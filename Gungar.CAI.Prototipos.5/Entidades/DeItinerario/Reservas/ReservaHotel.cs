using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gungar.CAI.Prototipos._5.Entidades.Oferta;

namespace Gungar.CAI.Prototipos._5.Entidades.DeItinerario.Reservas
{
    public class ReservaHotel : IReservaProducto
    {
        
        public Hotel Hotel { get; set; }
        public List<Pasajero> Pasajeros { get; set; } // Implementación de la propiedad Pasajeros
        public float PrecioTotal { get; set; }

        public int CantidadAdultos { get; set; }
        public int CantidadMenores { get; set; }
        public int CantidadInfantes { get; set; }


        public ReservaHotel(Hotel hotel)
        {

            Hotel = hotel;
            Pasajeros = new List<Pasajero>(); // Puedes inicializar la lista aquí o en el constructor
            PrecioTotal = Hotel.Disponibilidad.Tarifa;
         
        }

        public ReservaHotel() { }
       


    }
}
