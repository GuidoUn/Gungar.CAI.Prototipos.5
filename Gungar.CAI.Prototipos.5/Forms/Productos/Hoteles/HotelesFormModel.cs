using Gungar.CAI.Prototipos._5.Almacenes;
using Gungar.CAI.Prototipos._5.Entidades.DeItinerario;
using Gungar.CAI.Prototipos._5.Entidades.Oferta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gungar.CAI.Prototipos._5.Forms.Productos.Hoteles
{
    public class HotelesFormModel
    {
        public Itinerario? Itinerario { get; set; } = null;
        public bool EsConsulta { get; } = false;
        public bool EsSoloIda { get; set; } = false;
        public bool FormValido { get; set; } = true;

        public HotelesFormModel(Itinerario? itinerario)
        {
            if (itinerario == null)
            {
                EsConsulta = true;
            }
            else
            {
                Itinerario = itinerario;
            }
        }

        public List<Hotel> GetHotelesDisponibles(string destino, int cantidadAdultos, int cantidadMenores, int cantidadInfantes, string calificacion, DateTime? fechaDesde = null, DateTime? fechaHasta = null, decimal? precioMinimo = null, decimal? precioMaximo = null)
        {
            //TODO: Esto tiene que llamar al modulo ventas
            return AlmacenHoteles.GetHoteles(destino, cantidadAdultos, cantidadMenores, cantidadInfantes, calificacion, fechaDesde, fechaHasta, precioMinimo, precioMaximo);
        }

        public void ModificarDisponibilidad(Hotel hotel, bool isRollback)
        {
            //TODO: Esto tiene que llamar al modulo disponibilidad
            AlmacenHoteles.ModificarDisponibilidad(hotel, isRollback);
        }
    }
}
