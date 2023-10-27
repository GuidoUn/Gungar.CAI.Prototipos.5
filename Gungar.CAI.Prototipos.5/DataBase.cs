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
    public static class DataBase
    {
        static JsonSerializerOptions serializerOptions = new JsonSerializerOptions { IncludeFields = true };

        const string ITINERARIOS_FILE = @"..\..\..\Almacenes\Itinerarios.json";
        const string VUELOS_FILE = @"..\..\..\Almacenes\Vuelos.json";
        const string HOTELES_FILE = @"..\..\..\Almacenes\Hoteles.json";



        static DataBase()
        {
            // hacer la lectura aca para el archivo almacen correspondiente a CADA archivo
        }

        public static List<Itinerario>? LeerItinerarios()
        {
            if (!File.Exists(ITINERARIOS_FILE))
            {
                return null;
            }

            string json = File.ReadAllText(ITINERARIOS_FILE);

            List<Itinerario>? itinerariosEnAlmacen = JsonSerializer.Deserialize<List<Itinerario>>(json, serializerOptions);

            return itinerariosEnAlmacen;

        }

        public static void GuardarItinerarios(List<Itinerario> itinerarios)
        {
            if (File.Exists(ITINERARIOS_FILE))
            {
                File.Delete(ITINERARIOS_FILE);
            }

            File.WriteAllText(ITINERARIOS_FILE, JsonSerializer.Serialize(itinerarios, serializerOptions));
        }

        public static List<OfertaVuelo>? LeerVuelos()
        {
            if (!File.Exists(VUELOS_FILE))
            {
                return null;
            }

            string json = File.ReadAllText(VUELOS_FILE);

            List<OfertaVuelo>? ofertaVuelos = JsonSerializer.Deserialize<List<OfertaVuelo>>(json, serializerOptions);

            //--------- Para eliminar o modificar rápido vuelos, por ejemplo para borrar los viejos ------------------------------------------------

            //List<OfertaVuelo>? ofertaVuelosAReemplazar = new List<OfertaVuelo>();

            //ofertaVuelos.ForEach(vuelo =>
            //{
            //    if (vuelo.FechaSalida >= DateTime.Now)
            //        ofertaVuelosAReemplazar.Add(vuelo);


            //});

            //List<OfertaVuelo>? ofertaVuelosAReemplazarOrdenada = ofertaVueloslarga.OrderBy(vuelo => vuelo.FechaSalida).ToList();
            //return ofertaVuelosAReemplazarOrdenada;

            //--------------------------------------------------------------------------------------------------------------------------------------

            return ofertaVuelos;
        }

        public static void GuardarVuelos(List<OfertaVuelo> vuelos)
        {
            if (File.Exists(VUELOS_FILE))
            {
                File.Delete(VUELOS_FILE);
            }

            File.WriteAllText(VUELOS_FILE, JsonSerializer.Serialize(vuelos, serializerOptions));
        }




        public static List<OfertaHotel>? LeerHoteles()
        {
            if (!File.Exists(HOTELES_FILE))
            {
                return null;
            }

            string json = File.ReadAllText(HOTELES_FILE);

            List<OfertaHotel>? ofertaHotel = JsonSerializer.Deserialize<List<OfertaHotel>>(json, serializerOptions);

            // Agregar control de fecha
            return ofertaHotel;
        }

        public static void GuardarHoteles(List<OfertaHotel> hoteles)
        {
            if (File.Exists(HOTELES_FILE))
            {
                File.Delete(HOTELES_FILE);
            }

            File.WriteAllText(HOTELES_FILE, JsonSerializer.Serialize(hoteles, serializerOptions));
        }

    }
}
