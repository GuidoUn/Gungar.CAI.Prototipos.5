using Gungar.CAI.Prototipos._5.Entidades.DeItinerario;
using Gungar.CAI.Prototipos._5.Modulos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gungar.CAI.Prototipos._5.Forms.DeItinerario.SeleccionItinerario
{
    public class SeleccionItinerarioFormModel
    {
        public Itinerario? ItinerarioSeleccionado { get; set; }

        public List<Itinerario> ItinerariosEnPantalla { get; set; }

        public SeleccionItinerarioFormModel()
        {
            VentasModulo.EvaluarEstadoItinerarios();
            ItinerariosEnPantalla = VentasModulo.GetItinerariosFiltrados("");
        }

        public void EliminarItinerarioSeleccionado()
        {
            if (ItinerarioSeleccionado != null)
            {
                VentasModulo.EliminarItinerario(ItinerarioSeleccionado);
            }
            ItinerarioSeleccionado = null;
        }

        public void FiltrarItinerarios(string textoBusqueda)
        {
            ItinerariosEnPantalla = VentasModulo.GetItinerariosFiltrados(textoBusqueda);
        }
    }
}
