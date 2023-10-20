﻿using Gungar.CAI.Prototipos._5.Entidades.DeItinerario;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gungar.CAI.Prototipos._5
{
    public static class DataBase
    {
        const string ITINERARIOS_FILE = @"..\..\..\Almacenes\Itinerarios.json";

        public static List<Itinerario>? LeerItinerarios()
        {
            if (!File.Exists(ITINERARIOS_FILE))
            {
                return null;
            }

            string json = File.ReadAllText(ITINERARIOS_FILE);

            List<Itinerario>? itinerariosEnAlmacen = JsonConvert.DeserializeObject<List<Itinerario>>(json);

            return itinerariosEnAlmacen;

        }

        public static void GuardarItinerarios(List<Itinerario> itinerarios)
        {
            if (File.Exists(ITINERARIOS_FILE))
            {
                File.Delete(ITINERARIOS_FILE);
            }

            File.WriteAllText(ITINERARIOS_FILE, JsonConvert.SerializeObject(itinerarios));
        }
    }
}
