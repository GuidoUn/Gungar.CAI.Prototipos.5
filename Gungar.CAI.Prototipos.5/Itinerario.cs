using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gungar.CAI.Prototipos._5
{
    //public static List<string[]> itinerarios = new List<string[]> {
    //        new string[3] { "1", "Pedro Martinez", new DateTime(2023, 05, 17).ToString(FORMATO_FECHA) },
    //        new string[3] { "2", "Diego Maradona", new DateTime(2023, 06, 1).ToString(FORMATO_FECHA) },
    //        new string[3] { "3", "Lionel Messi", new DateTime(2023, 06, 3).ToString(FORMATO_FECHA) }
    //    };

    internal class Itinerario
    {
        public int itinerarioId;
        public string? nombreCliente;
        public DateTime fechaCreacion;
    }
}
