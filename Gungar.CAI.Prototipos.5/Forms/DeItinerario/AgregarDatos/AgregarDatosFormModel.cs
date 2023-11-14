using Gungar.CAI.Prototipos._5.Entidades.DeItinerario;
using Gungar.CAI.Prototipos._5.Entidades.DeItinerario.Reservas;
using Gungar.CAI.Prototipos._5.Entidades.Oferta;
using Gungar.CAI.Prototipos._5.Modulos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Gungar.CAI.Prototipos._5.Forms.DeItinerario.AgregarDatos
{
    public class AgregarDatosFormModel
    {

        public Itinerario Itinerario { get; set; }

        public Pasajero? PasajeroItinerarioSeleccionado { get; set; }

        public PasajeroReservaProducto? PasajeroReservaProductoSeleccionado { get; set; }

        public List<Pasajero> PasajerosItinerario { get; set; }


        public IReservaProducto ProductoSeleccionado { get; set; }
        public AgregarDatosFormModel(Itinerario itinerario)
        {
            itinerario.EvaluarVencimientoPrereserva();
            Itinerario = itinerario;
        }
        public bool TodosLosProductosTienenPasajeros()
        {
            var resultado = true;
            Itinerario.HotelesSeleccionados.ForEach(reservaHotel =>
            {
                if (reservaHotel.Pasajeros.Count <= 0)
                {
                    resultado = false;
                    return;
                }
            });
            Itinerario.VuelosAgregados.ForEach(reservaVuelo =>
            {
                if (reservaVuelo.Pasajeros.Count <= 0)
                {
                    resultado = false;
                    return;
                }

            });
            return resultado;
        }

        public List<IReservaProducto> GetProductosAgregados(int ItinerarioId)
        {
            return VentasModulo.GetProductosAgregados(ItinerarioId);
        }

        public void EliminarPasajeroSeleccionadoDeTodosLosProductos()
        {
            VentasModulo.EliminarPasajeroDeTodosLosProductos(Itinerario.ItinerarioId, PasajeroItinerarioSeleccionado);
        }

        public void EliminarPasajeroSeleccionadoDelProducto(int ItinerarioId,IReservaProducto reservaProducto, Pasajero pasajero)
        {
            VentasModulo.EliminarPasajeroDeProducto(ItinerarioId,reservaProducto, pasajero);
        }

        private bool esInfante(DateTime fechaNacimiento)
        {
            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - fechaNacimiento.Year;
            if (fechaNacimiento.Date > fechaActual.AddYears(-edad))
            {
                edad--;
            }

           return edad<2;
        }

        private bool esMenor(DateTime fechaNacimiento)
        {
            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - fechaNacimiento.Year;
            if (fechaNacimiento.Date > fechaActual.AddYears(-edad))
            {
                edad--;
            }

            return edad < 18;
        }

        public bool ConcidenPasajerosConProductos(int ItinerarioId)
        {
            bool resultado = true;
            this.GetProductosAgregados(ItinerarioId).ForEach(producto =>
            {
              if( producto is ReservaHotel reservaHotel)
                {
                    if(!ProductoTienePasajerosCorrecto(producto, reservaHotel.CantidadAdultos, reservaHotel.CantidadInfantes, reservaHotel.CantidadMenores)){
                        resultado = false;
                        return;

                    }
                   
                }

              else if( producto is ReservaVuelo reservaVuelo)
                {
                    if (!ProductoTienePasajerosCorrecto(producto, reservaVuelo.CantidadAdultos, reservaVuelo.CantidadInfantes, reservaVuelo.CantidadMenores))
                    {
                        resultado = false;
                        return;

                    }
                }

               

            });

                return resultado;
        }

        public bool ProductoTienePasajerosCorrecto(IReservaProducto producto,int PasajeroAdulto,int PasajeroInfante, int PasajeroMenor) {
            int _adulto=PasajeroAdulto;
            int _menor=PasajeroMenor;
            int _infante=PasajeroInfante;

            producto.Pasajeros.ForEach(pasajero =>
            {
                if (esInfante(pasajero.FechaNacimiento))
                {
                    _infante--;
                }
                else if (esMenor(pasajero.FechaNacimiento))
                {
                    _menor--;
                }
                else
                {
                    _adulto--;
                }

            });

            return _adulto == 0 && _menor == 0 && _infante==0 ;

        }

        public bool PasajeroExiste(string documento)
        {
            return PasajerosItinerario.Any(pasajero => pasajero.Documento == documento);
        }
    }
}
