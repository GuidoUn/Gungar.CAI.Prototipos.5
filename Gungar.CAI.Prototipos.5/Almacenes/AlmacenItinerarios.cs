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
        static JsonSerializerOptions serializerOptions = new JsonSerializerOptions { IncludeFields = true };

        const string FILE_LOCATION = @"..\..\..\Archivos\Itinerarios.json";

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
        public static void agregarItinerario(Itinerario itinerario)
        {
            Itinerarios.Add(itinerario);
        }

        public static void eliminarItinerario(Itinerario itinerario)
        {
            Itinerarios.Remove(itinerario);
        }

        public static int obtenerNuevoId()
        {
            if (Itinerarios.Count == 0)
            {
                return 0;
            }
            return Itinerarios.Last().itinerarioId + 1;
        }
    }
}
