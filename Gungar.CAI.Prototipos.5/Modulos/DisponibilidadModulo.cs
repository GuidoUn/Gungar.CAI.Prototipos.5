using Gungar.CAI.Prototipos._5.Almacenes;
using Gungar.CAI.Prototipos._5.Entidades;
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
                if (vueloEnAlmacen == null)
                    throw new Exception();

                vueloEnAlmacen.Tarifas.ForEach(tarifa =>
                {
                    if (tarifa.Clase != vuelo.Clase)
                        return;

                    if (tarifa.TipoDePasajero == 'A')
                        tarifa.Disponibilidad -= vuelo.CantidadAdultos;
                    if (tarifa.TipoDePasajero == 'M')
                        tarifa.Disponibilidad -= vuelo.CantidadMenores;
                    if (tarifa.TipoDePasajero == 'I')
                        tarifa.Disponibilidad -= vuelo.CantidadInfantes;

                    if (tarifa.Disponibilidad < 0)
                    {
                        throw new Exception("Disponibilidad insuficiente");
                    }
                });
            });

            itinerario.HotelesSeleccionados.ForEach(reservaHotel => AlmacenHoteles.ModificarDisponibilidad(reservaHotel.Hotel, false));
        }

        public static void liberarDisponibilidad(Itinerario itinerario)
        {
            itinerario.VuelosAgregados.ForEach(vuelo =>
            {
                var vueloEnAlmacen = AlmacenVuelos.OfertaVuelos.Find(oferta => oferta.CodigoOferta == vuelo.Vuelo.CodigoOferta);
                if (vueloEnAlmacen == null)
                    throw new Exception();

                vueloEnAlmacen.Tarifas.ForEach(tarifa =>
                {
                    if (tarifa.Clase != vuelo.Clase)
                        return;

                    if (tarifa.TipoDePasajero == 'A')
                        tarifa.Disponibilidad += vuelo.CantidadAdultos;
                    if (tarifa.TipoDePasajero == 'M')
                        tarifa.Disponibilidad += vuelo.CantidadMenores;
                    if (tarifa.TipoDePasajero == 'I')
                        tarifa.Disponibilidad += vuelo.CantidadInfantes;
                });
            });

            itinerario.HotelesSeleccionados.ForEach(reservaHotel => AlmacenHoteles.ModificarDisponibilidad(reservaHotel.Hotel, true));

        }

    }
}
