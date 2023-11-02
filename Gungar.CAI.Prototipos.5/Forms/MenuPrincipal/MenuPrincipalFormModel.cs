using Gungar.CAI.Prototipos._5.Entidades.DeItinerario;
using Gungar.CAI.Prototipos._5.Modulos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gungar.CAI.Prototipos._5.Forms.MenuPrincipal
{
    public class MenuPrincipalFormModel
    {
        public Itinerario GenerarNuevoItinerario()
        {
            Itinerario nuevoItinerario = new Itinerario();
            VentasModulo.AgregarItinerario(nuevoItinerario);
            return nuevoItinerario;
        }
    }
}
