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
        const string FILE_LOCATION = @"..\..\..\Archivos\Itinerarios.json";

        public static List<Itinerario> Itinerarios { get; set; } = new List<Itinerario>();

        static AlmacenItinerarios()
        {
            if (File.Exists(FILE_LOCATION))
            {
                string json = File.ReadAllText(FILE_LOCATION);

                Itinerarios = JsonSerializer.Deserialize<List<Itinerario>>(json) ?? new List<Itinerario>();
            }
        }

        public static void GuardarItinerarios()
        {
            if (File.Exists(FILE_LOCATION))
            {
                File.Delete(FILE_LOCATION);
            }

            File.WriteAllText(FILE_LOCATION, JsonSerializer.Serialize(Itinerarios));
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
            return Itinerarios.Last().ItinerarioId + 1;
        }

        public static List<Itinerario> GetItinerariosFiltrados(string textoBusqueda)
        {
            List<Itinerario> ItinerarioFiltrados = Itinerarios.Where(itinerario =>
            {
                if (itinerario.ItinerarioId.ToString().Contains(textoBusqueda))
                    return true;
                if (itinerario.Cliente == null)
                    return false;
                if (itinerario.Cliente.GetNombreYApellido().Contains(textoBusqueda))
                    return true;
                if (itinerario.Cliente.Documento != null && itinerario.Cliente.Documento.Contains(textoBusqueda))
                    return true;

                return false;
            }).ToList();

            return ItinerarioFiltrados;
        }
    }
}
