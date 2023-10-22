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

        private static bool esMismaCiudad(string codigoCiudadHotel, string ciudadBusqueda)
        {
           

            if (OfertaHotel.CodigoACiudad[codigoCiudadHotel].ToLower().Contains(ciudadBusqueda.ToLower()))
            {
                return true;
            }
            if (codigoCiudadHotel.ToLower().Contains(ciudadBusqueda.ToLower()))
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

        public static List<Hotel> ofertaHoteles { get; private set; } = new List<Hotel>();

        public static List<Hotel> getHoteles(string destino, int cantidadAdultos, int cantidadMenores, int cantidadInfantes, string calificacion, DateTime? fechaDesde = null, DateTime? fechaHasta = null, decimal? precioMinimo = null, decimal? precioMaximo = null)
        {

            List<Hotel> hotelesFiltrados = ofertaHoteles.Where(hotel =>
            {
                if (destino != "" && !esMismaCiudad(hotel.CodigoCiudad, destino))
                    return false;
                if (fechaDesde != null && !estaEntreFechas(hotel.Disponibilidad.Fecha, fechaDesde, fechaHasta))
                    return false;
                if (OfertaHotel.Calificaciones[calificacion]!= OfertaHotel.Calificaciones["Todas"]&& !esMismaCalificacion(hotel.Calificacion,OfertaHotel.Calificaciones[calificacion]))
                    return false;
                if ((precioMinimo!=null || precioMaximo!=null) && (precioMinimo != 0 || precioMaximo != 0) && !esEnMismoRangoDePrecio(hotel.Disponibilidad.Tarifa, precioMaximo, precioMinimo))
                    return false;
                if (cantidadAdultos > hotel.Disponibilidad.CapacidadAdultos || cantidadMenores > hotel.Disponibilidad.CapacidadMenores || cantidadInfantes > hotel.Disponibilidad.CapacidadInfantes)
                    return false;

                return true;
                
            }).ToList();

            return hotelesFiltrados;
        }
        private static List<Hotel> DesagruparHotelesPorDisponibilidad(List<OfertaHotel> hotelesAgrupados)
        {
            if (hotelesAgrupados == null)
            {
                return null;
            }
            List<Hotel> listaDeHoteles=new List<Hotel>();

            hotelesAgrupados.ForEach(hotel =>
            {

                hotel.Disponibilidad.ForEach(disponibilidadHotel =>
                {
                    Hotel hotelAAgregar = new Hotel(hotel.NombreHotel, hotel.CodigoOferta, hotel.CodigoCiudad, hotel.Calificacion, disponibilidadHotel, hotel.Direccion);
                    listaDeHoteles.Add(hotelAAgregar);
                });

            });
            return listaDeHoteles;
        }

        private static List<OfertaHotel> AgruparHotelesPorDisponibilidad(List<Hotel> hotelesDesagrupados)
        {
            List<OfertaHotel> listaDeHoteles = new List<OfertaHotel>();
          var codigosDeHotelesDisponibles= hotelesDesagrupados.Select(h=>h.CodigoOferta).ToList();
            codigosDeHotelesDisponibles.ForEach(codigoHotel =>
            {
                Hotel hotel = hotelesDesagrupados.First(h=>h.CodigoOferta==codigoHotel);
                List<Disponibilidad> disponiblidadDelHotel = new List<Disponibilidad>();
                var ofertaDelHotel = hotelesDesagrupados.Where(hotel => hotel.CodigoOferta == codigoHotel).ToList();
                ofertaDelHotel.ForEach(h =>
                {
                    disponiblidadDelHotel.Add(h.Disponibilidad);
                });

                listaDeHoteles.Add(new OfertaHotel(hotel.NombreHotel,codigoHotel,hotel.CodigoCiudad,hotel.Calificacion, disponiblidadDelHotel,hotel.Direccion));
            });
            return listaDeHoteles;
        }
        public static void CargaInicial()
        {
           ofertaHotelesEnAlmacen = DataBase.LeerHoteles();

            if (ofertaHotelesEnAlmacen != null)
            {
                ofertaHoteles = DesagruparHotelesPorDisponibilidad(ofertaHotelesEnAlmacen) ;
            }
        }

        public static void GuardarDatos()
        {
            DataBase.GuardarHoteles(AgruparHotelesPorDisponibilidad(ofertaHoteles));
        }
    }
}
