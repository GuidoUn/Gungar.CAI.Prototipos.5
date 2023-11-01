using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gungar.CAI.Prototipos._5.Entidades.Oferta
{
    public class Hotel : OfertaHotel
    {
        private static int ultimoID = 0;

        public int Id;
        public Disponibilidad Disponibilidad;
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }

        public Hotel(string nombreHotel, string codigoOferta, string codigoCiudad, int calificacion, Disponibilidad disponibilidad, Direccion direccion)
            : base(nombreHotel, codigoOferta, codigoCiudad, calificacion, direccion)
        {
            Disponibilidad = disponibilidad;
            Id = ultimoID;
            ultimoID++;
        }

    }
}
