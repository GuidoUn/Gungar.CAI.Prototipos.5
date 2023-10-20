using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Gungar.CAI.Prototipos._5.Entidades
{
    internal class TarifaHotel
    {
        public string clase; // E, P, B, F
        public string tipoDePasajero; // A, M, I
        public float precio;
        public int disponibilidad;
    }

    internal class Habitacion
    {
        public DateOnly Fecha;
        public int Cantidad; //Cantidad de habitaciones disponibles para la fecha.

        public Habitacion(DateOnly fecha, int cantidad)
        {
            Fecha = fecha;
            Cantidad = cantidad;
        }
    }

    internal class Disponibilidad
    {
        public string Nombre; // Nombre de la habitación (Ej.: Doble especial, Penthouse, etc.). Es puramente descriptivo.
        public float Tarifa; // precio en US$
        public int Capacidad; // Capacidad total de la habitación.
        public int CapacidadAdultos; // Cantidad máxima de adultos. Debe haber al menos un adulto por habitación.
        public int CapacidadMenores; // Cantidad máxima de menores. 
        public int CapacidadInfantes; // Cantidad máxima de infantes.
        public List<Habitacion> Habitaciones; //Lista que indica cuántas habitaciones hay disponibles para cada fecha.

        public Disponibilidad(string nombre, float tarifa, int capacidad, int capacidadAdultos, int capacidadMenores, int capacidadInfantes, List<Habitacion> habitaciones)
        {
            Nombre = nombre;
            Tarifa = tarifa;
            Capacidad = capacidad;
            CapacidadAdultos = capacidadAdultos;
            CapacidadMenores = capacidadMenores;
            CapacidadInfantes = capacidadInfantes;
            Habitaciones = habitaciones;
        }
    }

    internal class OfertaHotel
    {
        public string CodigoOferta; // hasta 3 char (depende del hotel)
        public string NombreHotel;
        public string CodigoCiudad; // hasta 3 char (depende de la agencia)
        public string Direccion; // (Calle, número, CP, Latitud, Longitud)
        public int Calificacion; // 1, 2, 3, 4 ó 5
        public List<Disponibilidad> Disponibilidad; // 1, 2, 3, 4 ó 5

        public OfertaHotel(string codigoOferta, string nombreHotel, string codigoCiudad, List<Tarifa> tarifas, string direccion, int calificacion, List<Disponibilidad> disponibilidad)
        {
            CodigoOferta = codigoOferta;
            NombreHotel = nombreHotel;
            CodigoCiudad = codigoCiudad;
            Direccion = direccion;
            Calificacion = calificacion;
            Disponibilidad = disponibilidad;
        }
    }
}
