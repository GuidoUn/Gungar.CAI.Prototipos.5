using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gungar.CAI.Prototipos._5.Entidades.DeItinerario;

namespace Gungar.CAI.Prototipos._5.Forms.MenuItinerario
{
    public class MenuItinerarioFormModel
    {
        public Itinerario Itinerario { get; set; }

        public MenuItinerarioFormModel(Itinerario itinerario)
        {
            Itinerario = itinerario;
        }

        public void GenerarPrereserva()
        {
            if (Itinerario.Estado == Estado.Prereserva)
            {
                Itinerario.GenerarPrereserva();
            }
        }
        public void GenerarReserva()
        {
            Itinerario.GenerarReserva();
        }

        public void CancelarItinerario()
        {
            Itinerario.CancelarItinerario();
        }
    }
}
