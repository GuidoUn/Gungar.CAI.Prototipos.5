using Gungar.CAI.Prototipos._5.Entidades.DeItinerario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gungar.CAI.Prototipos._5.Modulos
{
    public static class DisponibilidadModulo //Será Reservas y disponibilidad?
    {
        public static void bloquearDisponibilidad(Itinerario itinerario)
        {
            itinerario.VuelosAgregados.ForEach(vuelo =>
            {
                var vueloEnAlmacen = AlmacenVuelos.OfertaVuelos.Find(oferta => oferta.CodigoOferta == vuelo.Vuelo.CodigoOferta);

                int i = vuelo.Clase == 'E' ? 0 : 3;

                vueloEnAlmacen.Tarifas[i].Disponibilidad -= vuelo.CantidadAdultos;
                vueloEnAlmacen.Tarifas[i + 1].Disponibilidad -= vuelo.CantidadMenores;
                vueloEnAlmacen.Tarifas[i + 2].Disponibilidad -= vuelo.CantidadInfantes;
            });

            // TODO: Bloquear disponibilidad hoteles acá
        }

        public static void liberarDisponibilidad(Itinerario itinerario)
        {
            itinerario.VuelosAgregados.ForEach(vuelo =>
            {
                var vueloEnAlmacen = AlmacenVuelos.OfertaVuelos.Find(oferta => oferta.CodigoOferta == vuelo.Vuelo.CodigoOferta);

                int i = vuelo.Clase == 'E' ? 0 : 3;

                vueloEnAlmacen.Tarifas[i].Disponibilidad += vuelo.CantidadAdultos;
                vueloEnAlmacen.Tarifas[i + 1].Disponibilidad += vuelo.CantidadMenores;
                vueloEnAlmacen.Tarifas[i + 2].Disponibilidad += vuelo.CantidadInfantes;
            });

            // TODO: Liberar disponibilidad hoteles acá
        }
    }
}
