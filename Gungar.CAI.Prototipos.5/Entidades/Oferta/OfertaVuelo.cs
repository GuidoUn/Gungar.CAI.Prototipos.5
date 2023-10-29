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
        public string TipoDePasajero { get; set; } // A, M, I
        public float Precio { get; set; }
        public int Disponibilidad { get; set; } // Cantidad de asientos disponibles

        public TarifaVuelo(char clase, string tipoDePasajero, float precio, int disponibilidad)
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

        public static Dictionary<string, string> Ciudades = new Dictionary<string, string>(){
            {
                "AEP", "Buenos Aires"
            },  {
                "COR", "Cordoba"
            },  {
                "MDZ", "Mendoza"
            },  {
                "ROS", "Rosario"
            },  {
                "BRC", "Bariloche"
            },  {
                "SLA", "Salta"
            },  {
                "TUC", "Tucuman"
            },  {
                "NQN", "Neuquen"
            },  {
                "MDQ", "Mar del Plata"
            },  {
                "RES", "Resistencia"
            }, {
                "SFN", "Santa Fe"
            }, {
                "PSS", "Posadas"
            }, {
                "BHI", "Bahia Blanca"
            }, {
                "FTE", "Calafate"
            }, {
                "USH", "Ushuaia"
            }, {
                "IGR", "Iguazu"
            }, {
                "CRD", "Comodoro Rivadavia"
            }, {
                "JUJ", "Jujuy"
            },
        };

        public static Dictionary<string, string> Aerolineas = new Dictionary<string, string>(){
            {
                "AR", "Aerolineas Argentinas"
            },  {
                "FO", "Fly Bondi"
            },  {
                "WJ", "Jet Smart"
            }
        };

        public enum Clases
        {
            Economy = 'E',
            Premium = 'P',
            Business = 'B',
            First = 'F',
        }
    }
}
