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
        public char Clase; // E, P, B, F
        public string TipoDePasajero; // A, M, I
        public float Precio;
        public int Disponibilidad; // Cantidad de asientos disponibles

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
        public string CodigoOferta; //hasta 15 char (depende de la aerolinea)
        public string Origen;
        public string Destino;
        public DateTime FechaSalida;
        public DateTime FechaArribo;
        public string TiempoDeVuelo;
        //public int HorasDeVuelo;
        //public int MinutosDeVuelo;
        public string Aerolinea;
        public List<TarifaVuelo> Tarifas;

        //public OfertaVuelo(string codigoOferta, string origen, string destino, DateTime fechaSalida, DateTime fechaArribo, TimeOnly tiempoDeVuelo, string aerolinea, List<TarifaVuelo> tarifas)
        //{
        //    CodigoOferta = codigoOferta;
        //    Origen = origen;
        //    Destino = destino;
        //    FechaSalida = fechaSalida;
        //    FechaArribo = fechaArribo;
        //    TiempoDeVuelo = tiempoDeVuelo;
        //    Aerolinea = aerolinea;
        //    Tarifas = tarifas;
        //}
        //("AEP", "COR", "MDZ", "ROS", "BRC", "SLA", "TUC", "NQN", "MDQ", "RES", "SFN", "PSS", "BHI", "FTE", "USH", "IGR", "CRD", "JUJ"
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

        public static Dictionary<string, string> Clases = new Dictionary<string, string>(){
            {
                "E", "Economy"
            },  {
                "P", "Premium"
            },  {
                "B", "Business"
            }, {
                "F", "First"
            }
        };

    }
}
