﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gungar.CAI.Prototipos._5.Entidades.DeItinerario;
using Gungar.CAI.Prototipos._5.Forms.DeItinerario.SeleccionItinerario;
using Gungar.CAI.Prototipos._5.Modulos;

namespace Gungar.CAI.Prototipos._5
{
    public partial class SeleccionItinerarioForm : Form
    {
        SeleccionItinerarioFormModel model;

        public SeleccionItinerarioForm()
        {
            InitializeComponent();
        }

        private void SeleccionItinerarioForm_Load(object sender, EventArgs e)
        {
            model = new();
            itinerarioSeleccionadoLabel.Text = "Por favor, seleccione un itinerario";
            refrescar();
        }

        private void refrescar()
        {
            itinerariosListView.Items.Clear();
            model.ItinerariosEnPantalla.ForEach(itinerario =>
            {
                var item = new ListViewItem();
                item.Text = itinerario.ItinerarioId.ToString();
                item.SubItems.Add(itinerario?.Cliente?.GetNombreYApellido());
                item.SubItems.Add(itinerario?.Cliente?.Documento);
                item.SubItems.Add(itinerario?.FechaCreacion.ToString(Constantes.FORMATO_FECHA_LARGA));
                item.SubItems.Add(itinerario?.Estado.ToString());
                item.Tag = itinerario;

                itinerariosListView.Items.Add(item);
            });
        }

        private void evaluarEstadoBtns()
        {
            continuarBtn.Enabled = model.ItinerarioSeleccionado != null;
            eliminarItinerarioBtn.Enabled = model.ItinerarioSeleccionado != null;
        }

        private void itinerariosListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itinerariosListView.SelectedItems.Count == 0)
            {
                model.ItinerarioSeleccionado = null;
                evaluarEstadoBtns();
                itinerarioSeleccionadoLabel.Text = "Por favor, seleccione un itinerario";
                return;
            }

            ListViewItem selected = itinerariosListView.SelectedItems[0];
            model.ItinerarioSeleccionado = selected.Tag as Itinerario;

            itinerarioSeleccionadoLabel.Text = $"{model.ItinerarioSeleccionado?.Cliente?.Nombre} ({model.ItinerarioSeleccionado?.ItinerarioId})";

            evaluarEstadoBtns();
        }

        private void continuarBtn_Click(object sender, EventArgs e)
        {
            if (model.ItinerarioSeleccionado != null)
            {
                VentasModulo.ActualizarItinerarioSeleccionado(model.ItinerarioSeleccionado);
                MenuItinerarioForm menuItinerarioForm = new();
                menuItinerarioForm.ShowDialog();
                refrescar();
            }
        }

        private void filtrarBtn_Click(object sender, EventArgs e)
        {
            model.ItinerarioSeleccionado = null;
            evaluarEstadoBtns();
            itinerarioSeleccionadoLabel.Text = "Por favor, seleccione un itinerario";
            model.FiltrarItinerarios(parametroTextBox.Text);
            refrescar();
        }

        private void eliminarItinerarioBtn_Click(object sender, EventArgs e)
        {
            var confirmar = MessageBox.Show("¿Estás seguro que deseas eliminar el itinerario?", "Eliminar itinerario", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (confirmar == DialogResult.OK)
            {
                model.EliminarItinerarioSeleccionado();
            }

            itinerarioSeleccionadoLabel.Text = "Por favor, seleccione un itinerario";
            refrescar();
            evaluarEstadoBtns();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
