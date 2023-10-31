using Gungar.CAI.Prototipos._5.Entidades.DeItinerario;
using Gungar.CAI.Prototipos._5.Entidades.DeItinerario.Reservas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gungar.CAI.Prototipos._5.Modulos
{
    public static class VentasModulo
    {
        public static void EliminarItinerario(Itinerario itinerario)
        {
            AlmacenItinerarios.EliminarItinerario(itinerario);
        }

        public static List<Itinerario> GetItinerariosFiltrados(string textoBusqueda)
        {
            string textoBusquedaLower = textoBusqueda.ToLower();

            List<Itinerario> Itinerarios = AlmacenItinerarios.Itinerarios;
            if (textoBusqueda == "")
                return Itinerarios;

            List<Itinerario> ItinerarioFiltrados = Itinerarios.Where(itinerario =>
            {
                if (itinerario.ItinerarioId.ToString().ToLower().Contains(textoBusquedaLower))
                    return true;
                if (itinerario.Cliente == null)
                    return false;
                if (itinerario.Cliente.GetNombreYApellido().ToLower().Contains(textoBusquedaLower))
                    return true;
                if (itinerario.Cliente.Documento != null && itinerario.Cliente.Documento.ToLower().Contains(textoBusquedaLower))
                    return true;

                return false;
            }).ToList();

            return ItinerarioFiltrados;
        }

        public static void AgregarItinerario(Itinerario itinerario)
        {
            AlmacenItinerarios.AgregarItinerario(itinerario);
        }

        public static List<IReservaProducto> GetProductosAgregados(int itinerarioId)
        {
            Itinerario? itinerario = AlmacenItinerarios.Itinerarios.FirstOrDefault(itinerario => itinerario.ItinerarioId == itinerarioId);
            if (itinerario == null)
                return new List<IReservaProducto>();

            List<IReservaProducto> ReservaProductos = new List<IReservaProducto>();

            ReservaProductos.AddRange(itinerario.HotelesSeleccionados);
            ReservaProductos.AddRange(itinerario.VuelosAgregados);

            return ReservaProductos;
        }
    }
}
