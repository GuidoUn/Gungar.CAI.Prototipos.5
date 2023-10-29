using Gungar.CAI.Prototipos._5.Entidades.DeItinerario;
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
            ItinerariosEnPantalla = AlmacenItinerarios.Itinerarios;
        }

        public void EliminarItinerarioSeleccionado()
        {
            if (ItinerarioSeleccionado != null)
            {
                AlmacenItinerarios.eliminarItinerario(ItinerarioSeleccionado);
            }
            ItinerarioSeleccionado = null;
        }

        public void FiltrarItinerarios(string textoBusqueda)
        {
            ItinerariosEnPantalla = AlmacenItinerarios.GetItinerariosFiltrados(textoBusqueda);
        }
    }
}
