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

        const string HOTELES_FILE = @"..\..\..\Archivos\Hoteles.json";

        public static List<OfertaHotel>? LeerHoteles()
        {
            if (!File.Exists(HOTELES_FILE))
            {
                return null;
            }

            string json = File.ReadAllText(HOTELES_FILE);

            List<OfertaHotel>? ofertaHotel = JsonSerializer.Deserialize<List<OfertaHotel>>(json, serializerOptions);

         
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
