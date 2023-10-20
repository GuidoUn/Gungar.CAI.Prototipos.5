using Gungar.CAI.Prototipos._5.Entidades.DeItinerario;
using Gungar.CAI.Prototipos._5.Entidades.Oferta;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gungar.CAI.Prototipos._5
{
    public static class AppModel
    {
        public static List<Itinerario> itinerarios { get; private set; } = new List<Itinerario>();

        public static void agregarItinerario(Itinerario itinerario)
        {
            itinerarios.Add(itinerario);
        }

        public static void CargaInicial()
        {
            List<Itinerario>? itinerariosEnAlmacen = DataBase.LeerItinerarios();
            if (itinerariosEnAlmacen != null)
            {
                itinerarios = itinerariosEnAlmacen;
            }
        }

        public static void GuardarDatos()
        {
            DataBase.GuardarItinerarios(itinerarios);
        }
    }

}
