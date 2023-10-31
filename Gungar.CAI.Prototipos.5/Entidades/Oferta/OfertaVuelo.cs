using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Gungar.CAI.Prototipos._5.Entidades.Oferta
{

    public class TarifaVuelo
    {
        public char Clase { get; set; } // E, P, B, F
        public char TipoDePasajero { get; set; } // A, M, I
        public float Precio { get; set; }
        public int Disponibilidad { get; set; } // Cantidad de asientos disponibles

        public TarifaVuelo(char clase, char tipoDePasajero, float precio, int disponibilidad)
        {
            Clase = clase;
            TipoDePasajero = tipoDePasajero;
            Precio = precio;
            Disponibilidad = disponibilidad;
        }
    }

    public class OfertaVuelo
    {
        public string CodigoOferta { get; set; } //hasta 15 char (depende de la aerolinea)
        public string Origen { get; set; }
        public string Destino { get; set; }
        public DateTime FechaSalida { get; set; }
        public DateTime FechaArribo { get; set; }
        public string TiempoDeVuelo { get; set; }
        public string Aerolinea { get; set; }
        public List<TarifaVuelo> Tarifas { get; set; }

        public OfertaVuelo(string codigoOferta, string origen, string destino, DateTime fechaSalida, DateTime fechaArribo, string tiempoDeVuelo, string aerolinea, List<TarifaVuelo> tarifas)
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
