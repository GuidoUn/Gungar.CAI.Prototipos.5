using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gungar.CAI.Prototipos._5.Entidades.Oferta
{
    public class Habitacion // Se usa?
    {
        public DateTime Fecha;
        public int Cantidad; //Cantidad de habitaciones disponibles para la fecha.

        public Habitacion(DateTime fecha, int cantidad)
        {
            Fecha = fecha;
            Cantidad = cantidad;
        }
    }
}
