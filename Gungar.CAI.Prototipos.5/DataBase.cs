﻿using Gungar.CAI.Prototipos._5.Entidades.DeItinerario;
using Gungar.CAI.Prototipos._5.Entidades.Oferta;
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
        const string VUELOS_FILE = @"..\..\..\Almacenes\Vuelos.json";

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

        public static List<OfertaVuelo>? LeerVuelos()
        {
            if (!File.Exists(VUELOS_FILE))
            {
                return null;
            }

            string json = File.ReadAllText(VUELOS_FILE);

            List<OfertaVuelo>? ofertaVuelos = JsonConvert.DeserializeObject<List<OfertaVuelo>>(json);

            //List<OfertaVuelo>? ofertaVueloslarga = new List<OfertaVuelo>();

            //ofertaVuelos.ForEach(vuelo =>
            //{
            //    ofertaVueloslarga.Add(vuelo);
            //    if (vuelo.FechaSalida.Month == 11)
            //    {
            //        string newCodigo = vuelo.CodigoOferta.Remove(vuelo.CodigoOferta.Length - 1, 1) + "d";
            //        ofertaVueloslarga.Add(new OfertaVuelo(newCodigo, vuelo.Origen, vuelo.Destino, vuelo.FechaSalida.AddMonths(-1), vuelo.FechaArribo.AddMonths(-1), vuelo.TiempoDeVuelo, vuelo.Aerolinea, vuelo.Tarifas));
            //    }

            //});

            //List<OfertaVuelo>? ofertaVuelosnueva = ofertaVueloslarga.OrderBy(vuelo => vuelo.FechaSalida).ToList();
            //return ofertaVuelosnueva;

            return ofertaVuelos;
        }

        public static void GuardarVuelos(List<OfertaVuelo> vuelos)
        {
            if (File.Exists(VUELOS_FILE))
            {
                File.Delete(VUELOS_FILE);
            }

            File.WriteAllText(VUELOS_FILE, JsonConvert.SerializeObject(vuelos));
        }
    }
}
