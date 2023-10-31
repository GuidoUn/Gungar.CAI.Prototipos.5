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
    public static class AlmacenItinerarios
    {
        const string FILE_LOCATION = @"..\..\..\Almacenes\Archivos\Itinerarios.json";

        static JsonSerializerOptions serializerOptions = new JsonSerializerOptions { IncludeFields = true };

        public static List<Itinerario> Itinerarios { get; set; } = new List<Itinerario>();

        static AlmacenItinerarios()
        {
            if (File.Exists(FILE_LOCATION))
            {
                string json = File.ReadAllText(FILE_LOCATION);

                Itinerarios = JsonSerializer.Deserialize<List<Itinerario>>(json, serializerOptions) ?? new List<Itinerario>();
            }
        }

        public static void GuardarItinerarios()
        {
            if (File.Exists(FILE_LOCATION))
            {
                File.Delete(FILE_LOCATION);
            }

            File.WriteAllText(FILE_LOCATION, JsonSerializer.Serialize(Itinerarios, serializerOptions));
        }

        public static void AgregarItinerario(Itinerario itinerario)
        {
            Itinerarios.Add(itinerario);
        }

        public static void EliminarItinerario(Itinerario itinerario)
        {
            Itinerarios.Remove(itinerario);
        }

        public static int ObtenerNuevoId()
        {
            if (Itinerarios.Count == 0)
                return 0;

            List<Itinerario> itinerariosOrdenados = Itinerarios.OrderBy(itinerario => itinerario.ItinerarioId).ToList();

            return itinerariosOrdenados.Last().ItinerarioId + 1;
        }
    }
}
