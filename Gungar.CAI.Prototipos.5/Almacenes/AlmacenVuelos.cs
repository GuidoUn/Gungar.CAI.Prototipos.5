using Gungar.CAI.Prototipos._5.Entidades.DeItinerario;
using Gungar.CAI.Prototipos._5.Entidades.Oferta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Gungar.CAI.Prototipos._5
{
    public static class AlmacenVuelos
    {
        static JsonSerializerOptions serializerOptions = new JsonSerializerOptions { IncludeFields = true };

        const string FILE_LOCATION = @"..\..\..\Archivos\Vuelos.json";

        public static List<OfertaVuelo> OfertaVuelos { get; set; } = new List<OfertaVuelo>();

        static AlmacenVuelos()
        {
            if (File.Exists(FILE_LOCATION))
            {
                string json = File.ReadAllText(FILE_LOCATION);

                OfertaVuelos = JsonSerializer.Deserialize<List<OfertaVuelo>>(json, serializerOptions) ?? new List<OfertaVuelo>();
            }
        }

        public static void GuardarVuelos()
        {
            if (File.Exists(FILE_LOCATION))
            {
                File.Delete(FILE_LOCATION);
            }

            File.WriteAllText(FILE_LOCATION, JsonSerializer.Serialize(OfertaVuelos, serializerOptions));
        }

        public static List<OfertaVuelo> GetVuelos(string origen, string destino, int cantidadAdultos, int cantidadMenores, int cantidadInfantes, char clase, DateTime? fechaDesde = null, DateTime? fechaHasta = null, int? precioMinimo = null, int? precioMaximo = null)
        {
            List<OfertaVuelo> vuelosFiltrados = OfertaVuelos.Where(vuelo =>
            {
                if (origen != "" && !esMismaCiudad(vuelo.Origen, origen))
                    return false;
                if (destino != "" && !esMismaCiudad(vuelo.Destino, destino))
                    return false;
                if (fechaDesde != null && !estaEntreFechas(vuelo.FechaSalida, fechaDesde, fechaHasta))
                    return false;
                if (!vuelo.Tarifas.Exists(tarifa => tarifa.Clase == clase))
                    return false;


                // Todo: Terminar filtros

                return true;
            }
             ).ToList();

            return vuelosFiltrados;
        }

        private static bool esMismaCiudad(string ciudadVuelo, string ciudadBusqueda)
        {
            if (OfertaVuelo.Ciudades[ciudadVuelo].ToLower().Contains(ciudadBusqueda.ToLower()))
            {
                return true;
            }
            if (ciudadVuelo.ToLower().Contains(ciudadBusqueda.ToLower()))
            {
                return true;
            }
            return false;
        }

        private static bool estaEntreFechas(DateTime fechaVuelo, DateTime? fechaDesde, DateTime? fechaHasta)
        {
            if (fechaVuelo.Date >= fechaDesde?.Date && (fechaVuelo.Date <= fechaHasta?.Date || fechaHasta == null))
            {
                return true;
            }
            return false;
        }
    }
}
