using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gungar.CAI.Prototipos._5
{
    public static class Constantes
    {
        public const string FORMATO_FECHA_CORTA = "yyyy-MM-dd";

        public const string FORMATO_FECHA_LARGA = "yyyy'-'MM'-'dd'T'HH':'mm";

        public static readonly Dictionary<string, string> Ciudades = new(){
            {
                "BUE", "Buenos Aires"
            }, {
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

        public static readonly Dictionary<string, string> Aerolineas = new(){
            {
                "AR", "Aerolineas Argentinas"
            },  {
                "FO", "Fly Bondi"
            },  {
                "WJ", "Jet Smart"
            }
        };

        public static readonly Dictionary<char, string> Clases = new(){
            {
                'E', "Economy"
            },  {
                'P', "Premium"
            },  {
                'B', "Business"
            }, {
                'F', "First"
            }
        };

        public static readonly Dictionary<string, int> Calificaciones = new(){
            {
                "Todas", 0
            },  {
                "1 Estrella", 1
            },  {
                "2 Estrellas", 2
            },  {
                "3 Estrellas", 3
            },  {
                "4 Estrellas", 4
            },  {
                "5 Estrellas", 5
            }
        };
    }
}
