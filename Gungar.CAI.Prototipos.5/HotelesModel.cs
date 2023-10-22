using Gungar.CAI.Prototipos._5.Entidades;
using Gungar.CAI.Prototipos._5.Entidades.Oferta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gungar.CAI.Prototipos._5
{
    public static class HotelesModel
    {

        private static List<OfertaHotel>? ofertaHotelesEnAlmacen;
        private static bool estaEntreFechas(DateTime fechaHotel, DateTime? fechaDesde, DateTime? fechaHasta)
        {
            if (fechaHotel.Date >= fechaDesde?.Date && (fechaHotel.Date <= fechaHasta?.Date || fechaHasta == null))
            {
                return true;
            }
            return false;
        }

        private static bool esMismaCiudad(string ciudadHotel, string ciudadBusqueda)
        {
            if (ciudadHotel==ciudadBusqueda)
            {
                return true;
            }
            
            return false;
        }

        private static bool esMismaCalificacion(int calificacionHotel, int calificacionBusqueda)
        {
            if (calificacionHotel == calificacionBusqueda)
            {
                return true;
            }

            return false;
        }

        private static bool esEnMismoRangoDePrecio(float precioHotel, decimal? precioMaximo=999999999, decimal? precioMinimo=0)
        {
            decimal precioHotelEnDecimal = (decimal)precioHotel;
            if (precioHotel <= 0)
            {
                precioHotelEnDecimal = 999999999;
            }

            return precioHotelEnDecimal <= precioMaximo && precioHotelEnDecimal >= precioMinimo;
          
        }

        public static List<OfertaHotel> ofertaHoteles { get; private set; } = new List<OfertaHotel>();

        public static List<OfertaHotel> getHoteles(string destino, int cantidadAdultos, int cantidadMenores, int cantidadInfantes, string calificacion, DateTime? fechaDesde = null, DateTime? fechaHasta = null, decimal? precioMinimo = null, decimal? precioMaximo = null)
        {

            List<OfertaHotel> hotelesFiltrados = ofertaHoteles.Where(hotel =>
            {
                if (destino != "" && !esMismaCiudad(hotel.CodigoCiudad, destino))
                    return false;
                if (fechaDesde != null && !estaEntreFechas(hotel.Disponibilidad.First().Fecha, fechaDesde, fechaHasta))
                    return false;
                if (OfertaHotel.Calificaciones[calificacion]!= OfertaHotel.Calificaciones["Todas"]&& !esMismaCalificacion(hotel.Calificacion,OfertaHotel.Calificaciones[calificacion]))
                    return false;
                if ((precioMinimo!=null || precioMaximo!=null) && (precioMinimo != 0 || precioMaximo != 0) && !esEnMismoRangoDePrecio(hotel.Disponibilidad.First().Tarifa, precioMaximo, precioMinimo))
                    return false;
                if (cantidadAdultos > hotel.Disponibilidad.First().CapacidadAdultos || cantidadMenores > hotel.Disponibilidad.First().CapacidadMenores || cantidadInfantes > hotel.Disponibilidad.First().CapacidadInfantes)
                    return false;

                return true;
                
            }).ToList();

            return hotelesFiltrados;
        }
        /*private List<OfertaHotel> ProcesarListaDeHoteles(List<OfertaHotel> hoteles)
        {
            if (hoteles == null)
            {
                return null;
            }
            List<OfertaHotel> listaDeHoteles=new List<OfertaHotel>();

            hoteles.ForEach(hotel =>
            {
               
                hotel.Disponibilidad.ForEach(h =>
                {
                    OfertaHotel hotelAAgregar;
                    hotelAAgregar = new OfertaHotel(hotel.NombreHotel, hotel.CodigoOferta, hotel.Calificacion, h, );
                    listaDeHoteles.Add(hotelAAgregar);
                })

            })
        }*/
        public static void CargaInicial()
        {
           ofertaHotelesEnAlmacen = DataBase.LeerHoteles();

            if (ofertaHotelesEnAlmacen != null)
            {
                ofertaHoteles = ofertaHotelesEnAlmacen;
            }
        }

        public static void GuardarDatos()
        {
            DataBase.GuardarHoteles(ofertaHoteles);
        }
    }
}
