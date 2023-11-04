using Gungar.CAI.Prototipos._5.Entidades.DeItinerario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gungar.CAI.Prototipos._5.Forms.DeItinerario.AgregarDatos
{
    public class AgregarDatosFormModel
    {
        // TODO: Hacer model
        public Itinerario Itinerario { get; set; }
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
    }
}
