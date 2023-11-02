using System;
using System.Collections.Generic;
using System.Linq;
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
}
