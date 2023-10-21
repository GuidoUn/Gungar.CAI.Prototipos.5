using Gungar.CAI.Prototipos._5.Entidades.DeItinerario;
using Gungar.CAI.Prototipos._5.Entidades.Oferta;
//using Newtonsoft.Json;
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

        public static List<Itinerario>? LeerItinerarios()
        {
            if (!File.Exists(ITINERARIOS_FILE))
            {
                return null;
            }

            string json = File.ReadAllText(ITINERARIOS_FILE);

            //List<Itinerario>? itinerariosEnAlmacen = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Itinerario>>(json);

            List<Itinerario>? itinerariosEnAlmacen = JsonSerializer.Deserialize<List<Itinerario>>(json, serializerOptions);

            return itinerariosEnAlmacen;

        }

        public static void GuardarItinerarios(List<Itinerario> itinerarios)
        {
            if (File.Exists(ITINERARIOS_FILE))
            {
                File.Delete(ITINERARIOS_FILE);
            }

            //File.WriteAllText(ITINERARIOS_FILE, JsonConvert.SerializeObject(itinerarios));
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
            //    if (vuelo.FechaSalida >= DateTime.Now.AddDays(9))
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

            //File.WriteAllText(VUELOS_FILE, Newtonsoft.Json.JsonConvert.SerializeObject(vuelos));
            File.WriteAllText(VUELOS_FILE, JsonSerializer.Serialize(vuelos, serializerOptions));
        }
    }
}
