using Gungar.CAI.Prototipos._5.Entidades.Oferta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gungar.CAI.Prototipos._5.Entidades.DeItinerario.Reservas
{
    public class ReservaVuelo : IReservaProducto
    {
        public OfertaVuelo Vuelo { get; set; } //A reemplazar por vueloId capaz

        public List<Pasajero> Pasajeros { get; set; } = new List<Pasajero>();

        public int CantidadAdultos { get; set; }
        public int CantidadMenores { get; set; }
        public int CantidadInfantes { get; set; }

        public ReservaVuelo(OfertaVuelo vuelo, int cantidadAdultos, int cantidadMenores, int cantidadInfantes)
        {
            Vuelo = vuelo;
            CantidadAdultos = cantidadAdultos;
            CantidadMenores = cantidadMenores;
            CantidadInfantes = cantidadInfantes;
        }
    }
}
