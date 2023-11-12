using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Gungar.CAI.Prototipos._5.Entidades.Oferta
{
    public class OfertaHotel
    {
        public string CodigoOferta; // hasta 3 char (depende del hotel)
        public string NombreHotel;
        public string CodigoCiudad; // hasta 3 char (depende de la agencia)
        public Direccion Direccion; // (Calle, número, CP, Latitud, Longitud)
        public int Calificacion; // 1, 2, 3, 4 ó 5
        public List<Disponibilidad> Disponibilidad;

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
    }
}
