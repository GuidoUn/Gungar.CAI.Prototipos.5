using Gungar.CAI.Prototipos._5.Entidades.DeItinerario;
using Gungar.CAI.Prototipos._5.Modulos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gungar.CAI.Prototipos._5.Forms.MenuPrincipal
{
    public static class MenuPrincipalFormModel
    {
        public static Itinerario GenerarNuevoItinerario()
        {
            Itinerario nuevoItinerario = new Itinerario();
            VentasModulo.AgregarItinerario(nuevoItinerario);
            return nuevoItinerario;
        }
    }
}
