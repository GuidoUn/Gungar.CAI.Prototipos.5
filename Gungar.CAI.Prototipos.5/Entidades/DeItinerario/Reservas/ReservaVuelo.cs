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
        public OfertaVuelo Vuelo { get; set; } //A reemplazar por vueloId capaz?

        public List<Pasajero> Pasajeros { get; set; } = new List<Pasajero>();

        public char Clase { get; set; }
        public int CantidadAdultos { get; set; }
        public int CantidadMenores { get; set; }
        public int CantidadInfantes { get; set; }

        public float PrecioTotal { get; set; } = 0;

        public ReservaVuelo(OfertaVuelo vuelo, char clase, int cantidadAdultos, int cantidadMenores, int cantidadInfantes)
        {
            Vuelo = vuelo;
            Clase = clase;
            CantidadAdultos = cantidadAdultos;
            CantidadMenores = cantidadMenores;
            CantidadInfantes = cantidadInfantes;

            List<TarifaVuelo> tarifas = vuelo.Tarifas.Where(tarifa => tarifa.Clase == clase).ToList();

            PrecioTotal += vuelo.Tarifas[0].Precio * cantidadAdultos;
            PrecioTotal += vuelo.Tarifas[1].Precio * cantidadMenores;
            PrecioTotal += vuelo.Tarifas[2].Precio * cantidadInfantes;
        }
    }
}
