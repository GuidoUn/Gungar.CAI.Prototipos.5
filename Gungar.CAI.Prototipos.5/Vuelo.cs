using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Gungar.CAI.Prototipos._5
{
    internal class Tarifa
    {
        public string clase; // E, P, B, F
        public string tipoDePasajero; // A, M, I
        public float precio;
        public int disponibilidad;
    }

    internal class Vuelo : Producto
    {
        public int codigoOferta; //hasta 15 char (depende de la aerolinea)
        public TimeOnly tiempoDeVuelo;
        public string aerolinea;
        public List<Tarifa> tarifas;

        public Vuelo(int codigoOferta, TimeOnly tiempoDeVuelo, string aerolinea, List<Tarifa> tarifas) : base()
        {
            this.codigoOferta = codigoOferta;
            this.tiempoDeVuelo = tiempoDeVuelo;
            this.aerolinea = aerolinea;
            this.tarifas = tarifas;
        }
    }
}
