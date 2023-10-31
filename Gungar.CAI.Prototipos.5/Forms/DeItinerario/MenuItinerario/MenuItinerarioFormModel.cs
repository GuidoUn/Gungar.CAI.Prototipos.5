﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gungar.CAI.Prototipos._5.Entidades.DeItinerario;
using Gungar.CAI.Prototipos._5.Entidades.DeItinerario.Reservas;

namespace Gungar.CAI.Prototipos._5.Forms.DeItinerario.MenuItinerario
{
    public class MenuItinerarioFormModel
    {
        public Itinerario Itinerario { get; set; }

        public MenuItinerarioFormModel(Itinerario itinerario)
        {
            Itinerario = itinerario;
        }
        public void GenerarReserva()
        {
            Itinerario.GenerarReserva();
        }

        public void CancelarItinerario()
        {
            Itinerario.CancelarItinerario();
        }

        private bool puedeConfirmar()
        {
            if (Itinerario.Estado != Estado.Presupuesto && Itinerario.Estado != Estado.Prereserva)
                return false;

            return (Itinerario.HotelesSeleccionados.Count > 0 || Itinerario.VuelosAgregados.Count > 0) && Itinerario.Cliente != null;
        }

        public bool puedePrereserva()
        {
            return Itinerario.Estado == Estado.Presupuesto && puedeConfirmar();
        }

        public bool PuedeReserva()
        {
            return puedeConfirmar() && Itinerario.ItinerarioPagado;
        }

        public List<ReservaVuelo> GetVuelosAgregados()
        {
            return Itinerario?.VuelosAgregados ?? new();
        }

        //public bool GetPagado()
        //{
        //    return Itinerario.ItinerarioPagado;
        //}
    }
}
