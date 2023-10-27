﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gungar.CAI.Prototipos._5.Entidades;
using Gungar.CAI.Prototipos._5.Entidades.DeItinerario;
using Gungar.CAI.Prototipos._5.Entidades.Oferta;

namespace Gungar.CAI.Prototipos._5
{
    public partial class HotelesForm : Form
    {
        Itinerario? itinerario;
        bool esConsulta = false;
        List<Hotel> listaDeHotelesDisponibles;
        DateTime hastaFechaSeleccionada;
        DateTime desdeFechaSeleccionada;

        Hotel hotelAAgregar;

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

        const string FORMATO_FECHA = "yyyy'-'MM'-'dd'T'HH':'mm";

        int nroProductoAAgregar = 0;




        private void HotelesForm_Load(object sender, EventArgs e)
        {
            if (esConsulta)
            {
                titleLabel.Text = "Consulta disponibilidad de productos";
                itinerarioLabel.Text = "";
                modificarItinerarioBox.Visible = false;
            }
            else
            {
                itinerarioLabel.Text = $"{itinerario?.cliente?.nombre} ({itinerario?.itinerarioId})";
            }

            clasesCombo.SelectedIndex = 0;

            desdeFechaDatePicker.MinDate = DateTime.Now;
            hastaFechaDatePicker.MinDate = DateTime.Now;
            borrarFechas();
        }
        private void poblarHoteles()
        {
            listaDeHotelesDisponibles = HotelesModel.getHoteles(destinoText.Text, Decimal.ToInt32(cantidadAdultosNumeric.Value), Decimal.ToInt32(cantidadMenoresNumeric.Value), Decimal.ToInt32(cantidadInfantesNumeric.Value), clasesCombo.SelectedItem.ToString(), desdeFechaSeleccionada, hastaFechaSeleccionada, desdePreciosNumeric.Value, hastaPreciosNumeric.Value);

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
                    item.SubItems.Add(hotel.CodigoCiudad);
                    item.SubItems.Add(hotel.Disponibilidad.Tarifa.ToString());
                    item.SubItems.Add(hotel.Disponibilidad.Fecha.ToString());
                    item.SubItems.Add(hotel.Disponibilidad.CapacidadAdultos.ToString());
                    item.SubItems.Add(hotel.Disponibilidad.CapacidadMenores.ToString());
                    item.SubItems.Add(hotel.Disponibilidad.CapacidadInfantes.ToString());


                    item.Tag = hotel;

                    hotelesListView.Items.Add(item);
                }
                if (listaDeHotelesDisponibles.Count <= 0)
                {
                    MessageBox.Show("No hay tenemos hoteles disponibles para los filtros seleccionados", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            };
               
        }

        private void poblarProductosAgregados()
        {
            itinerarioListView.Items.Clear();
            foreach (var hotel in itinerario.hoteles)
            {
                var item = new ListViewItem();
                item.Text = hotel.NombreHotel;
                item.SubItems.Add(hotel.Disponibilidad.Nombre);



                item.Tag = hotel;

                itinerarioListView.Items.Add(item);
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
            /*desdeFechaDatePicker.Format = DateTimePickerFormat.Custom;
            desdeFechaDatePicker.CustomFormat = " ";
            desdeFechaSeleccionada = DateTime.MinValue;

            hastaFechaDatePicker.Format = DateTimePickerFormat.Custom;
            hastaFechaDatePicker.CustomFormat = " ";
            hastaFechaSeleccionada = DateTime.MaxValue;*/
            desdeFechaDatePicker.Value = DateTime.Now;
            hastaFechaDatePicker.Value = DateTime.Now;
        }

        private void borrarFechasBtn_Click(object sender, EventArgs e)
        {
            borrarFechas();
        }

        private void hotelesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hotelesListView.SelectedItems.Count <= 0)
            {
                return;
            }
            hotelAAgregar = (Hotel)hotelesListView.SelectedItems[0].Tag;
        }

        private void agregarProductoBtn_Click(object sender, EventArgs e)
        {
            if (hotelAAgregar == null)
            {
                MessageBox.Show("Debe seleccionar un hotel", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            hotelAAgregar.FechaDesde = desdeFechaSeleccionada;
            hotelAAgregar.FechaHasta = hastaFechaSeleccionada;
            itinerario.AgregarHotel(hotelAAgregar);
            poblarProductosAgregados();
        }
    }
}
