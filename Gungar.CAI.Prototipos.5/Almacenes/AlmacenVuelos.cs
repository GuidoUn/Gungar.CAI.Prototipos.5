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
        const string FILE_LOCATION = @"..\..\..\Almacenes\Archivos\Vuelos.json";

        public static List<OfertaVuelo> OfertaVuelos { get; set; } = new List<OfertaVuelo>();

        static AlmacenVuelos()
        {
            if (File.Exists(FILE_LOCATION))
            {
                string json = File.ReadAllText(FILE_LOCATION);

                OfertaVuelos = JsonSerializer.Deserialize<List<OfertaVuelo>>(json) ?? new List<OfertaVuelo>();
            }
        }

        public static void GuardarVuelos()
        {
            if (File.Exists(FILE_LOCATION))
            {
                File.Delete(FILE_LOCATION);
            }

            File.WriteAllText(FILE_LOCATION, JsonSerializer.Serialize(OfertaVuelos));
        }

        public static List<OfertaVuelo> GetVuelos(string origen, string destino, int cantidadAdultos, int cantidadMenores, int cantidadInfantes, char clase, DateTime? fechaDesde = null, DateTime? fechaHasta = null, int precioMinimo = 0, int precioMaximo = 0)
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
                if (!estaEntrePrecios(vuelo.Tarifas.FindAll(tarifa => tarifa.Clase == clase)[0].Precio, precioMinimo, precioMaximo))
                    return false;
                if (!hayDisponibilidad(vuelo.Tarifas.FindAll(tarifa => tarifa.Clase == clase), cantidadAdultos, cantidadMenores, cantidadInfantes))
                    return false;

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
            return fechaVuelo.Date >= fechaDesde?.Date && (fechaVuelo.Date <= fechaHasta?.Date || fechaHasta == null);
        }

        private static bool estaEntrePrecios(float precioVuelo, int precioMinimo, int precioMaximo)
        {
            if (precioVuelo < precioMinimo)
                return false;
            if (precioMaximo != 0 && precioVuelo > precioMaximo)
                return false;

            return true;
        }

        private static bool hayDisponibilidad(List<TarifaVuelo> tarifas, int cantAdult, int cantMen, int canInf)
        {
            if (tarifas[0].Disponibilidad < cantAdult)
                return false;
            if (tarifas[1].Disponibilidad < cantMen)
                return false;
            if (tarifas[2].Disponibilidad < canInf)
                return false;

            return true;
        }
    }
}
