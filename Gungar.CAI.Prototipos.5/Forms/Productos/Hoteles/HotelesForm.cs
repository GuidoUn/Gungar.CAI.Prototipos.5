﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gungar.CAI.Prototipos._5.Almacenes;
using Gungar.CAI.Prototipos._5.Entidades.DeItinerario;
using Gungar.CAI.Prototipos._5.Entidades.DeItinerario.Reservas;
using Gungar.CAI.Prototipos._5.Entidades.Oferta;
using Gungar.CAI.Prototipos._5.Forms.Productos.Hoteles;

namespace Gungar.CAI.Prototipos._5
{
    public partial class HotelesForm : Form
    {
        Itinerario? itinerario; // mover a model                
        bool esConsulta = false; // mover a model
        List<Hotel> listaDeHotelesDisponibles; // mover a model
        DateTime hastaFechaSeleccionada; // mover a model
        DateTime desdeFechaSeleccionada; // mover a model
        HotelesFormModel hotelesFormModel;

        Hotel hotelSeleccionado; // mover a model

        ReservaHotel hotelAgregadoSeleccionado; // mover a model

        public HotelesForm(Itinerario? itinerario)
        {
            InitializeComponent();
            if (itinerario == null)
            {
                esConsulta = true;
            }
            else
            {
                this.itinerario = itinerario;
            }
        }

        int nroProductoAAgregar = 0; // TODO: Borrarlo si no se usa

        private void HotelesForm_Load(object sender, EventArgs e)
        {
            hotelesFormModel = new HotelesFormModel(itinerario);
            if (esConsulta)
            {
                titleLabel.Text = "Consulta disponibilidad de productos";
                itinerarioLabel.Text = "";
                modificarItinerarioBox.Visible = false;
            }
            else
            {
                itinerarioLabel.Text = $"{itinerario?.Cliente?.Nombre} ({itinerario?.ItinerarioId})";
            }

            clasesCombo.SelectedIndex = 0;

            desdeFechaDatePicker.MinDate = DateTime.Now;
            hastaFechaDatePicker.MinDate = DateTime.Now;
            borrarFechas();
            poblarProductosAgregados();
        }
        private void poblarHoteles()
        {
            // TODO: Esto tiene que pedirle los hoteles al model, y el model tiene que pedirselo al módulo ventas
            listaDeHotelesDisponibles = AlmacenHoteles.GetHoteles(destinoText.Text, Decimal.ToInt32(cantidadAdultosNumeric.Value), Decimal.ToInt32(cantidadMenoresNumeric.Value), Decimal.ToInt32(cantidadInfantesNumeric.Value), clasesCombo.Text, desdeFechaSeleccionada, hastaFechaSeleccionada, desdePreciosNumeric.Value, hastaPreciosNumeric.Value);

            hotelesListView.Items.Clear();
            foreach (var hotel in listaDeHotelesDisponibles)
            {
                if (hotel.Disponibilidad.Cantidad > 0)
                {
                    var item = new ListViewItem();
                    item.Text = hotel.NombreHotel;
                    item.SubItems.Add(hotel.Disponibilidad.Nombre);
                    item.SubItems.Add(hotel.Disponibilidad.Capacidad.ToString());
                    item.SubItems.Add(hotel.Direccion.Calle);
                    item.SubItems.Add(hotel.Calificacion.ToString());
                    item.SubItems.Add(Constantes.Ciudades[hotel.CodigoCiudad]);
                    item.SubItems.Add("$" + hotel.Disponibilidad.Tarifa.ToString());
                    item.SubItems.Add(hotel.Disponibilidad.Fecha.ToString(Constantes.FORMATO_FECHA_CORTA));
                    item.SubItems.Add(hotel.Disponibilidad.CapacidadAdultos.ToString());
                    item.SubItems.Add(hotel.Disponibilidad.CapacidadMenores.ToString());
                    item.SubItems.Add(hotel.Disponibilidad.CapacidadInfantes.ToString());
                    item.Tag = hotel;

                    hotelesListView.Items.Add(item);
                }
                if (listaDeHotelesDisponibles.Count <= 0)
                {
                    MessageBox.Show("No tenemos hoteles disponibles para los filtros seleccionados", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };
        }

        private void poblarProductosAgregados()
        {
            if (!esConsulta)
            {
                hotelesAgregadosListView.Items.Clear();
                foreach (var reservaHotel in itinerario?.HotelesSeleccionados)
                {
                    var item = new ListViewItem();
                    item.Text = reservaHotel.Hotel.NombreHotel;
                    item.SubItems.Add(reservaHotel.Hotel.Disponibilidad.Nombre);
                    item.Tag = reservaHotel;

                    hotelesAgregadosListView.Items.Add(item);
                }
            }
        }

        private void aplicarFiltrosBtn_Click(object sender, EventArgs e)
        {
            poblarHoteles();
        }

        private void desdeFechaDatePicker_ValueChanged(object sender, EventArgs e)
        {
            desdeFechaDatePicker.Format = DateTimePickerFormat.Short;
            desdeFechaSeleccionada = desdeFechaDatePicker.Value;
        }

        private void hastaFechaDatePicker_ValueChanged(object sender, EventArgs e)
        {
            hastaFechaDatePicker.Format = DateTimePickerFormat.Short;
            hastaFechaSeleccionada = hastaFechaDatePicker.Value;
        }

        private void borrarFechas()
        {
            desdeFechaDatePicker.Value = DateTime.Now;
            hastaFechaDatePicker.Value = DateTime.Now.AddDays(1);
        }

        private void borrarFechasBtn_Click(object sender, EventArgs e)
        {
            borrarFechas();
        }

        private void hotelesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hotelesListView.SelectedItems.Count <= 0)
                return;

            hotelSeleccionado = (Hotel)hotelesListView.SelectedItems[0].Tag;
        }

        private bool HotelYaFueAgregado(Hotel Hotel)
        {
            return itinerario.HotelesSeleccionados.Any(reservaHotel => reservaHotel.Hotel.Equals(Hotel)); //Mejor sería usar Exists, que any
        }

        private void agregarProductoBtn_Click(object sender, EventArgs e)
        {
            if (hotelSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un hotel", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            hotelSeleccionado.FechaDesde = desdeFechaSeleccionada;
            hotelSeleccionado.FechaHasta = hastaFechaSeleccionada;
            if (HotelYaFueAgregado(hotelSeleccionado))
            {

                MessageBox.Show("El Hotel seleccionado ya fue agregado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ReservaHotel reservaHotel = new ReservaHotel(hotelSeleccionado);

            itinerario?.AgregarReservaHotel(reservaHotel);
            poblarProductosAgregados();
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void quitarHotelBtn_Click(object sender, EventArgs e)
        {
            if (hotelAgregadoSeleccionado == null)
                return;

            itinerario?.QuitarReservaHotel(hotelAgregadoSeleccionado);
            poblarProductosAgregados();
        }

        private void hotelesAgregadosListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hotelesAgregadosListView.SelectedItems.Count <= 0)
                return;

            hotelAgregadoSeleccionado = (ReservaHotel)hotelesAgregadosListView.SelectedItems[0].Tag;
        }
    }
}
