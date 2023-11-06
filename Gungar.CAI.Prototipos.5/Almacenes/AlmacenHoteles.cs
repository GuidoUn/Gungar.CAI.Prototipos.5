using Gungar.CAI.Prototipos._5.Entidades.Oferta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Gungar.CAI.Prototipos._5.Almacenes
{
    public static class AlmacenHoteles
    {
        static JsonSerializerOptions serializerOptions = new JsonSerializerOptions { IncludeFields = true };

        const string FILE_LOCATION = @"..\..\..\Almacenes\Archivos\Hoteles.json";

        public static List<Hotel>? OfertaHotelesDesagrupados;

        public static List<OfertaHotel>? OfertaHotelesEnAlmacen;

        static AlmacenHoteles()
        {
            if (File.Exists(FILE_LOCATION))
            {
                string json = File.ReadAllText(FILE_LOCATION);

                OfertaHotelesEnAlmacen = JsonSerializer.Deserialize<List<OfertaHotel>>(json, serializerOptions) ?? new List<OfertaHotel>();
                if (OfertaHotelesEnAlmacen != null)
                {
                    OfertaHotelesDesagrupados = DesagruparHotelesPorDisponibilidad(OfertaHotelesEnAlmacen);

                }
            }
        }

        public static void GuardarHoteles()
        {
            if (File.Exists(FILE_LOCATION))
            {
                File.Delete(FILE_LOCATION);
            }

            File.WriteAllText(FILE_LOCATION, JsonSerializer.Serialize(OfertaHotelesEnAlmacen, serializerOptions));
        }

        private static List<Hotel> DesagruparHotelesPorDisponibilidad(List<OfertaHotel> hotelesAgrupados)
        {
            List<Hotel> listaDeHoteles = new List<Hotel>();
            if (hotelesAgrupados == null)
            {
                return listaDeHoteles;
            }

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

        public static List<Hotel> GetHoteles(string destino, int cantidadAdultos, int cantidadMenores, int cantidadInfantes, string calificacion, DateTime? fechaDesde = null, DateTime? fechaHasta = null, decimal? precioMinimo = null, decimal? precioMaximo = null)
        {
            if (OfertaHotelesDesagrupados == null) return new List<Hotel>();

            List<Hotel> hotelesFiltrados = OfertaHotelesDesagrupados.Where(hotel =>
            {
                if (destino != "" && !EsMismaCiudad(hotel.CodigoCiudad, destino))
                    return false;
                if (!EstaEntreFechas(hotel.Disponibilidad.FechasOcupadas, fechaDesde, fechaHasta))
                    return false;
                if (Constantes.Calificaciones[calificacion] != Constantes.Calificaciones["Todas"] && !EsMismaCalificacion(hotel.Calificacion, Constantes.Calificaciones[calificacion]))
                    return false;
                if ((precioMinimo != null || precioMaximo != null) && (precioMinimo != 0 || precioMaximo != 0) && !EsEnMismoRangoDePrecio(hotel.Disponibilidad.Tarifa, precioMaximo, precioMinimo))
                    return false;
                if (cantidadAdultos > hotel.Disponibilidad.CapacidadAdultos || cantidadMenores > hotel.Disponibilidad.CapacidadMenores || cantidadInfantes > hotel.Disponibilidad.CapacidadInfantes)
                    return false;

                return true;

            }).ToList();

            return hotelesFiltrados;
        }

        public static void ModificarDisponibilidad(Hotel hotel, bool isRollback)
        {
            if (OfertaHotelesEnAlmacen == null) return;
            OfertaHotelesEnAlmacen.ForEach(_hotel =>
            {
                var disponibilidadAModificar = _hotel.Disponibilidad.Find(h => h.Nombre == hotel.Disponibilidad.Nombre);
                if (_hotel.CodigoOferta == hotel.CodigoOferta && disponibilidadAModificar != null)
                {
                    if (isRollback)
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
            });
        }

        private static List<DateTime> ObtenerRangoDeFechas(DateTime FechaDesde, DateTime FechaHasta)
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

        private static bool EstaEntreFechas(List<DateTime> fechaOcupadasHotel, DateTime? fechaDesde, DateTime? fechaHasta)
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

        public static double ObtenerPrecioTotal(List<Hotel> hoteles) // TODO: Borrar si no se usa mover a modulo ventas
        {
            double precioTotal = 0.0;
            hoteles.ForEach(hotel =>
            {
                precioTotal += hotel.Disponibilidad.Tarifa;
            });

            return precioTotal;
        }

        private static bool EsMismaCiudad(string codigoCiudadHotel, string ciudadBusqueda)
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

        private static bool EsMismaCalificacion(int calificacionHotel, int calificacionBusqueda)
        {
            if (calificacionHotel == calificacionBusqueda)
            {
                return true;
            }

            return false;
        }

        private static bool EsEnMismoRangoDePrecio(float precioHotel, decimal? precioMaximo = 999999999, decimal? precioMinimo = 0)
        {
            decimal precioHotelEnDecimal = (decimal)precioHotel;
            if (precioHotel <= 0)
            {
                precioHotelEnDecimal = 999999999;
            }

            return precioHotelEnDecimal <= precioMaximo && precioHotelEnDecimal >= precioMinimo;
        }
    }
}
