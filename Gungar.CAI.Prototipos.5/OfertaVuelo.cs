using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Gungar.CAI.Prototipos._5
{
    internal class TarifaVuelo
    {
        public string Clase; // E, P, B, F
        public string TipoDePasajero; // A, M, I
        public float Precio;
        public int Disponibilidad; // Cantidad de asientos disponibles

        public TarifaVuelo(string clase, string tipoDePasajero, float precio, int disponibilidad)
        {
            Clase = clase;
            TipoDePasajero = tipoDePasajero;
            Precio = precio;
            Disponibilidad = disponibilidad;
        }
    }

    internal class OfertaVuelo
    {
        public string CodigoOferta; //hasta 15 char (depende de la aerolinea)
        public string Origen;
        public string Destino;
        public DateTime FechaSalida;
        public DateTime FechaArribo;
        public TimeOnly TiempoDeVuelo;
        public string Aerolinea;
        public List<Tarifa> Tarifas;

        public OfertaVuelo(string codigoOferta, string origen, string destino, DateTime fechaSalida, DateTime fechaArribo, TimeOnly tiempoDeVuelo, string aerolinea, List<Tarifa> tarifas)
        {
            CodigoOferta = codigoOferta;
            Origen = origen;
            Destino = destino;
            FechaSalida = fechaSalida;
            FechaArribo = fechaArribo;
            TiempoDeVuelo = tiempoDeVuelo;
            Aerolinea = aerolinea;
            Tarifas = tarifas;
        }
    }
}
