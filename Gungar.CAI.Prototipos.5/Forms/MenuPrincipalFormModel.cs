using Gungar.CAI.Prototipos._5.Entidades.DeItinerario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gungar.CAI.Prototipos._5.Forms
{
    public static class MenuPrincipalFormModel
    {
        public static Itinerario GenerarNuevoItinerario()
        {
            Itinerario nuevoItinerario = new Itinerario();
            AlmacenItinerarios.AgregarItinerario(nuevoItinerario);
            return nuevoItinerario;
        }
    }
}
