using Gungar.CAI.Prototipos._5.Entidades.DeItinerario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gungar.CAI.Prototipos._5
{
    public static class AppModel
    {
        public static List<Itinerario> itinerarios { get; private set; } = new List<Itinerario> {
            new Itinerario(new Cliente("Pedro", "Martinez", "1193692693"), new DateTime(2023, 05, 17)),
            new Itinerario(new Cliente("Diego", "Maradona", "1245325433"), new DateTime(2023, 06, 1)),
            new Itinerario(new Cliente("Lionel", "Messi", "32213573"), new DateTime(2023, 06, 3))
        };

        public static void agregarItinerario(Itinerario itinerario)
        {
            itinerarios.Add(itinerario);
        }
    }
}
