using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Gungar.CAI.Prototipos._5.Entidades.Oferta
{

    public class Direccion
    {
        public string Calle;
        public string Numero;
        public string CP;
        public string Latitud;
        public string Longitud;

        public Direccion(
            string Calle,
            string Numero,
            string CP,
            string Latitud,
            string Longitud
            )
        {
            this.Calle = Calle;
            this.Numero = Numero;
            this.CP = CP;
            this.Latitud = Latitud;
            this.Longitud = Longitud;
        }
    }
    public class Habitacion
    {
        public DateTime Fecha;
        public int Cantidad; //Cantidad de habitaciones disponibles para la fecha.

        public Habitacion(DateTime fecha, int cantidad)
        {
            Fecha = fecha;
            Cantidad = cantidad;
        }
    }

    public class Disponibilidad
    {
        public int Id = 0;
        public string Nombre; // Nombre de la habitación (Ej.: Doble especial, Penthouse, etc.). Es puramente descriptivo.
        public float Tarifa; // precio en US$
        public int Capacidad; // Capacidad total de la habitación.
        public int CapacidadAdultos; // Cantidad máxima de adultos. Debe haber al menos un adulto por habitación.
        public int CapacidadMenores; // Cantidad máxima de menores. 
        public int CapacidadInfantes; // Cantidad máxima de infantes.
        public DateTime Fecha;
        public List<DateTime> FechasOcupadas;
        public int Cantidad;
    }


    public class OfertaHotel
    {
        public string CodigoOferta; // hasta 3 char (depende del hotel)
        public string NombreHotel;
        public string CodigoCiudad; // hasta 3 char (depende de la agencia)
        public Direccion Direccion; // (Calle, número, CP, Latitud, Longitud)
        public int Calificacion; // 1, 2, 3, 4 ó 5
        public List<Disponibilidad> Disponibilidad; // 1, 2, 3, 4 ó 5
        public OfertaHotel()
        {
            // Constructor sin parámetros
        }
        public OfertaHotel(string nombreHotel, string codigoOferta, string codigoCiudad, int calificacion, List<Disponibilidad> disponibilidad, Direccion direccion)
        {
            CodigoOferta = codigoOferta;
            NombreHotel = nombreHotel;
            CodigoCiudad = codigoCiudad;
            Direccion = direccion;
            Calificacion = calificacion;
            Disponibilidad = disponibilidad;

        }
        public OfertaHotel(string nombreHotel, string codigoOferta, string codigoCiudad, int calificacion, Direccion direccion)
        {
            CodigoOferta = codigoOferta;
            NombreHotel = nombreHotel;
            CodigoCiudad = codigoCiudad;
            Direccion = direccion;
            Calificacion = calificacion;


        }
        public static Dictionary<string, int> Calificaciones = new Dictionary<string, int>()
            {
            {"Todas",0 },
    { "1 Estrella", 1 },
    { "2 Estrellas", 2 },
    { "3 Estrellas", 3 },
    { "4 Estrellas", 4 },
    { "5 Estrellas", 5 }
};

        public static Dictionary<string, string> CodigoACiudad = new Dictionary<string, string>(){
            {
                "BUE", "Buenos Aires"
            },
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

    }



}
