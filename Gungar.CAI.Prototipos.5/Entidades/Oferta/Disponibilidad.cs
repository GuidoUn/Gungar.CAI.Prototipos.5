using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gungar.CAI.Prototipos._5.Entidades.Oferta
{
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
}
