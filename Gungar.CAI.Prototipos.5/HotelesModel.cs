using Gungar.CAI.Prototipos._5.Entidades;
using Gungar.CAI.Prototipos._5.Entidades.Oferta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gungar.CAI.Prototipos._5
{
    public static class HotelesModel // TODO: Reemplazar por AlmacenHoteles y HotelesFormModel
    {
        private static List<OfertaHotel>? ofertaHotelesEnAlmacen;

        public static List<DateTime> ObtenerRangoDeFechas(DateTime FechaDesde, DateTime FechaHasta)
        {
            List<DateTime> listaDeFechas = new List<DateTime>();

            DateTime fechaEnUso = FechaDesde.Date;
            while (fechaEnUso <= FechaHasta.Date)
            {
                listaDeFechas.Add(fechaEnUso);
                fechaEnUso = fechaEnUso.AddDays(1);
            }
            Console.WriteLine(listaDeFechas.ToString());
            return listaDeFechas;
        }
        private static bool estaEntreFechas(List<DateTime> fechaOcupadasHotel, DateTime? fechaDesde, DateTime? fechaHasta)
        {
            bool resultado = true;
            foreach (var fechaOcupada in fechaOcupadasHotel)
            {
                if (fechaOcupada.Date >= fechaDesde?.Date && (fechaOcupada.Date <= fechaHasta?.Date || fechaHasta == null))
                {
                    return false;
                }
            }

            return resultado;
        }
        public static double ObtenerPrecioTotal(List<Hotel> hoteles)
        {
            double precioTotal = 0.0;
            hoteles.ForEach(hotel =>
            {
                precioTotal += hotel.Disponibilidad.Tarifa;
            });
            return precioTotal;
        }

        private static bool esMismaCiudad(string codigoCiudadHotel, string ciudadBusqueda)
        {
            if (Constantes.Ciudades[codigoCiudadHotel].ToLower().Contains(ciudadBusqueda.ToLower()))
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

        private static bool esEnMismoRangoDePrecio(float precioHotel, decimal? precioMaximo = 999999999, decimal? precioMinimo = 0)
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
                if (!estaEntreFechas(hotel.Disponibilidad.FechasOcupadas, fechaDesde, fechaHasta))
                    return false;
                if (Constantes.Calificaciones[calificacion] != Constantes.Calificaciones["Todas"] && !esMismaCalificacion(hotel.Calificacion, Constantes.Calificaciones[calificacion]))
                    return false;
                if ((precioMinimo != null || precioMaximo != null) && (precioMinimo != 0 || precioMaximo != 0) && !esEnMismoRangoDePrecio(hotel.Disponibilidad.Tarifa, precioMaximo, precioMinimo))
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
            List<Hotel> listaDeHoteles = new List<Hotel>();

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

        public static void ModificarDisponibilidadHotel(Hotel hotel, bool rollback)
        {
            if (ofertaHotelesEnAlmacen == null) return;
            ofertaHotelesEnAlmacen.ForEach(_hotel =>
             {
                 var disponibilidadAModificar = _hotel.Disponibilidad.Find(h => h.Nombre == hotel.Disponibilidad.Nombre);
                 if (_hotel.CodigoOferta == hotel.CodigoOferta && disponibilidadAModificar != null)
                 {
                     if (rollback)
                     {
                         disponibilidadAModificar.Cantidad++;



                     }
                     else
                     {
                         disponibilidadAModificar.Cantidad--;
                         List<DateTime> fechasOcupadasAAgregar = ObtenerRangoDeFechas(hotel.FechaDesde, hotel.FechaHasta);
                         disponibilidadAModificar.FechasOcupadas.AddRange(fechasOcupadasAAgregar);


                     }

                 }
             }
             );

            DataBase.GuardarHoteles(ofertaHotelesEnAlmacen);

        }

        public static void CargaInicial()
        {
            ofertaHotelesEnAlmacen = DataBase.LeerHoteles();

            if (ofertaHotelesEnAlmacen != null)
            {
                ofertaHoteles = DesagruparHotelesPorDisponibilidad(ofertaHotelesEnAlmacen);
            }
        }

        public static void GuardarDatos()
        {
            DataBase.GuardarHoteles(ofertaHotelesEnAlmacen);
        }
    }
}
