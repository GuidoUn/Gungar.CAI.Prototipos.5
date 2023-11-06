using Gungar.CAI.Prototipos._5.Entidades.DeItinerario;
using Gungar.CAI.Prototipos._5.Entidades.DeItinerario.Reservas;
using Gungar.CAI.Prototipos._5.Modulos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gungar.CAI.Prototipos._5.Forms.DeItinerario.AgregarDatos
{
    public class AgregarDatosFormModel
    {
       
        public Itinerario Itinerario { get; set; }

        public Pasajero? PasajeroItinerarioSeleccionado { get; set; } 

        public Pasajero? PasajeroProductoSeleccionado { get; set; }

        public List<Pasajero> PasajerosItinerario { get; set; }

        public bool EditandoPasajero = false;

        public IReservaProducto ProductoSeleccionado { get; set; }
        public AgregarDatosFormModel(Itinerario itinerario)
        {
            itinerario.EvaluarVencimientoPrereserva();
            Itinerario = itinerario;
        }
        public bool TodosLosProductosTienenPasajeros()
        {
            var resultado = true;
            Itinerario.HotelesSeleccionados.ForEach(reservaHotel =>
            {
                if (reservaHotel.Pasajeros.Count <= 0)
                {
                    resultado = false;
                    return;
                }
            });
            Itinerario.VuelosAgregados.ForEach(reservaVuelo => { 
                if(reservaVuelo.Pasajeros.Count <= 0) {
                    resultado = false;
                    return;
                }

            });
            return resultado;
        }

        public List<IReservaProducto> GetProductosAgregados(int ItinerarioId)
        {
            return VentasModulo.GetProductosAgregados(ItinerarioId);
        }
    }
}
