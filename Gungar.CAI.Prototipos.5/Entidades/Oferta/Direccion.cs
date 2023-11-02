using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gungar.CAI.Prototipos._5.Entidades.Oferta
{
    public class Direccion
    {
        public string Calle;
        public string Numero;
        public string CP;
        public string Latitud;
        public string Longitud;

        public Direccion(
            string Calle,
            string Numero,
            string CP,
            string Latitud,
            string Longitud
            )
        {
            this.Calle = Calle;
            this.Numero = Numero;
            this.CP = CP;
            this.Latitud = Latitud;
            this.Longitud = Longitud;
        }
    }
}
